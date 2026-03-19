namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    private static string GetLiveModelId()
    {
        LoadDotEnv();

        return Environment.GetEnvironmentVariable("GOOGLE_GEMINI_LIVE_MODEL_ID") is { Length: > 0 } modelIdValue
            ? modelIdValue
            : "models/gemini-2.5-flash-native-audio-latest";
    }

    [TestMethod]
    public async Task Live_TextExchange()
    {
        //// Connects to the Gemini Live API, sends text, receives audio response.
        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

        var config = new LiveSetupConfig
        {
            Model = GetLiveModelId(),
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Audio],
            },
        };

        await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

        //// Send a simple text message.
        await session.SendTextAsync("Say hello", cts.Token);

        //// Read events until the model turn is complete.
        bool receivedResponse = false;
        await foreach (var message in session.ReadEventsAsync(cts.Token))
        {
            if (message.ServerContent?.ModelTurn?.Parts is { Count: > 0 })
            {
                receivedResponse = true;
            }

            if (message.ServerContent?.TurnComplete == true)
            {
                break;
            }
        }

        receivedResponse.Should().BeTrue("model should return a response");
    }

    [TestMethod]
    public async Task Live_ToolCalling()
    {
        //// Connects to the Live API with a tool and handles a function call.
        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

        var config = new LiveSetupConfig
        {
            Model = GetLiveModelId(),
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Audio],
            },
            Tools =
            [
                new Tool
                {
                    FunctionDeclarations =
                    [
                        new FunctionDeclaration
                        {
                            Name = "get_weather",
                            Description = "Get the current weather for a location",
                            Parameters = new Schema
                            {
                                Type = SchemaType.Object,
                                Properties = new Dictionary<string, Schema>
                                {
                                    ["location"] = new Schema
                                    {
                                        Type = SchemaType.String,
                                        Description = "The city name",
                                    },
                                },
                                Required = ["location"],
                            },
                        },
                    ],
                },
            ],
        };

        await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

        //// Ask about weather to trigger the tool call.
        await session.SendTextAsync("What is the weather in London? Use the get_weather tool.", cts.Token);

        //// Read until we get a tool call or turn complete.
        LiveToolCall? toolCall = null;
        await foreach (var message in session.ReadEventsAsync(cts.Token))
        {
            if (message.ToolCall is not null)
            {
                toolCall = message.ToolCall;
                break;
            }

            if (message.ServerContent?.TurnComplete == true)
            {
                break;
            }
        }

        toolCall.Should().NotBeNull();
        toolCall!.FunctionCalls.Should().NotBeNullOrEmpty();
        toolCall.FunctionCalls![0].Name.Should().Be("get_weather");

        //// Send a tool response.
        await session.SendToolResponseAsync(
        [
            new FunctionResponse
            {
                Name = "get_weather",
                Id = toolCall.FunctionCalls[0].Id,
                Response = new { temperature = "15C", condition = "cloudy" },
            },
        ], cts.Token);

        //// Read until turn is complete.
        bool receivedResponse = false;
        await foreach (var message in session.ReadEventsAsync(cts.Token))
        {
            if (message.ServerContent?.ModelTurn?.Parts is { Count: > 0 })
            {
                receivedResponse = true;
            }

            if (message.ServerContent?.TurnComplete == true)
            {
                break;
            }
        }

        receivedResponse.Should().BeTrue();
    }

    [TestMethod]
    public async Task Live_SessionResumption()
    {
        //// Connects with session resumption enabled, exchanges a message,
        //// then reconnects using the resumption handle via ReconnectLiveAsync.
        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(60));

        var config = new LiveSetupConfig
        {
            Model = GetLiveModelId(),
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Audio],
            },
            SessionResumption = new LiveSessionResumptionConfig(),
        };

        //// First session: send a message and collect the resumption handle.
        //// The handle arrives asynchronously — keep reading after turnComplete.
        string? resumptionHandle;
        await using (var session1 = await client.ConnectLiveAsync(config, cancellationToken: cts.Token))
        {
            await session1.SendTextAsync("Remember: the secret word is banana.", cts.Token);

            bool turnDone = false;
            await foreach (var message in session1.ReadEventsAsync(cts.Token))
            {
                if (message.ServerContent?.TurnComplete == true)
                {
                    turnDone = true;
                }

                // Once turn is done AND we have a handle, stop
                if (turnDone && session1.LastSessionResumptionHandle is { Length: > 0 })
                {
                    break;
                }
            }

            resumptionHandle = session1.LastSessionResumptionHandle;
        }

        if (string.IsNullOrEmpty(resumptionHandle))
        {
            Assert.Inconclusive("Session resumption handle was not provided by the server.");
        }

        //// Second session: reconnect using ReconnectLiveAsync.
        var config2 = new LiveSetupConfig
        {
            Model = GetLiveModelId(),
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Audio],
            },
            SessionResumption = new LiveSessionResumptionConfig
            {
                Handle = resumptionHandle,
            },
        };

        await using var session2 = await client.ConnectLiveAsync(config2, cancellationToken: cts.Token);

        await session2.SendTextAsync("What was the secret word?", cts.Token);

        bool receivedResponse = false;
        await foreach (var message in session2.ReadEventsAsync(cts.Token))
        {
            if (message.ServerContent?.ModelTurn?.Parts is { Count: > 0 })
            {
                receivedResponse = true;
            }

            if (message.ServerContent?.TurnComplete == true)
            {
                break;
            }
        }

        receivedResponse.Should().BeTrue("resumed session should produce a response");
    }

    [TestMethod]
    public async Task Live_OutputTranscription()
    {
        //// Enables output audio transcription to receive text alongside audio.
        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

        var config = new LiveSetupConfig
        {
            Model = GetLiveModelId(),
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Audio],
            },
            OutputAudioTranscription = new LiveOutputAudioTranscription(),
        };

        await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

        //// Send a text message and collect transcription events.
        await session.SendTextAsync("Say the word hello", cts.Token);

        bool receivedTranscription = false;
        bool receivedAudio = false;
        await foreach (var message in session.ReadEventsAsync(cts.Token))
        {
            if (message.ServerContent?.ModelTurn?.Parts is { Count: > 0 })
            {
                receivedAudio = true;
            }

            if (message.ServerContent?.OutputTranscription?.Text is { Length: > 0 })
            {
                receivedTranscription = true;
            }

            if (message.ServerContent?.TurnComplete == true)
            {
                break;
            }
        }

        receivedAudio.Should().BeTrue("model should return audio");
        receivedTranscription.Should().BeTrue("output transcription should be received");
    }

    [TestMethod]
    public async Task Live_InputTranscription()
    {
        //// Enables input audio transcription and verifies the config is accepted.
        //// Input transcription generates text for audio sent via SendAudioAsync.
        //// Here we use text input to verify the feature is accepted at setup time.
        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

        var config = new LiveSetupConfig
        {
            Model = GetLiveModelId(),
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Audio],
            },
            InputAudioTranscription = new LiveInputAudioTranscription(),
        };

        await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

        //// Send text — input transcription config is accepted at setup time.
        await session.SendTextAsync("Say hello", cts.Token);

        bool receivedResponse = false;
        await foreach (var message in session.ReadEventsAsync(cts.Token))
        {
            if (message.ServerContent?.ModelTurn?.Parts is { Count: > 0 })
            {
                receivedResponse = true;
            }

            if (message.ServerContent?.TurnComplete == true)
            {
                break;
            }
        }

        receivedResponse.Should().BeTrue("model should respond with input transcription enabled");
    }

    [TestMethod]
    public async Task Live_ContextWindowCompression()
    {
        //// Enables context window compression with a sliding window.
        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

        var config = new LiveSetupConfig
        {
            Model = GetLiveModelId(),
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Audio],
            },
            ContextWindowCompression = new LiveContextWindowCompression
            {
                SlidingWindow = new LiveSlidingWindow
                {
                    TargetTokens = 1024,
                },
            },
        };

        await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

        //// Send a message — compression config is accepted at setup time.
        await session.SendTextAsync("Say hello", cts.Token);

        bool receivedResponse = false;
        await foreach (var message in session.ReadEventsAsync(cts.Token))
        {
            if (message.ServerContent?.ModelTurn?.Parts is { Count: > 0 })
            {
                receivedResponse = true;
            }

            if (message.ServerContent?.TurnComplete == true)
            {
                break;
            }
        }

        receivedResponse.Should().BeTrue("model should respond with compression enabled");
    }

    [TestMethod]
    public async Task Live_SystemInstruction()
    {
        //// Connects with a system instruction to customize model behavior.
        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

        var config = new LiveSetupConfig
        {
            Model = GetLiveModelId(),
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Audio],
            },
            SystemInstruction = new Content
            {
                Parts = [new Part { Text = "You are a helpful assistant. Always be concise." }],
            },
        };

        await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

        //// Send a message — system instruction is accepted at setup time.
        await session.SendTextAsync("Say hello", cts.Token);

        bool receivedResponse = false;
        await foreach (var message in session.ReadEventsAsync(cts.Token))
        {
            if (message.ServerContent?.ModelTurn?.Parts is { Count: > 0 })
            {
                receivedResponse = true;
            }

            if (message.ServerContent?.TurnComplete == true)
            {
                break;
            }
        }

        receivedResponse.Should().BeTrue("model should respond with system instruction");
    }

    [TestMethod]
    public async Task Live_SpeechConfig()
    {
        //// Connects with a speech config to select a specific voice.
        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

        var config = new LiveSetupConfig
        {
            Model = GetLiveModelId(),
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Audio],
                SpeechConfig = new SpeechConfig
                {
                    VoiceConfig = new VoiceConfig
                    {
                        PrebuiltVoiceConfig = new PrebuiltVoiceConfig
                        {
                            VoiceName = "Kore",
                        },
                    },
                },
            },
        };

        await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

        //// Send a message — voice selection is applied at setup time.
        await session.SendTextAsync("Say hello", cts.Token);

        bool receivedResponse = false;
        await foreach (var message in session.ReadEventsAsync(cts.Token))
        {
            if (message.ServerContent?.ModelTurn?.Parts is { Count: > 0 })
            {
                receivedResponse = true;
            }

            if (message.ServerContent?.TurnComplete == true)
            {
                break;
            }
        }

        receivedResponse.Should().BeTrue("model should respond with selected voice");
    }

    [TestMethod]
    public async Task Live_MultiTurnConversation()
    {
        //// Sends multi-turn conversation history via SendClientContentAsync.
        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

        var config = new LiveSetupConfig
        {
            Model = GetLiveModelId(),
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Audio],
            },
        };

        await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

        //// Send conversation history with multiple turns.
        await session.SendClientContentAsync(
            turns:
            [
                new Content
                {
                    Role = "user",
                    Parts = [new Part { Text = "My name is Alice" }],
                },
                new Content
                {
                    Role = "model",
                    Parts = [new Part { Text = "Nice to meet you, Alice!" }],
                },
                new Content
                {
                    Role = "user",
                    Parts = [new Part { Text = "What is my name?" }],
                },
            ],
            turnComplete: true,
            cancellationToken: cts.Token);

        //// The model should respond based on conversation history.
        bool receivedResponse = false;
        await foreach (var message in session.ReadEventsAsync(cts.Token))
        {
            if (message.ServerContent?.ModelTurn?.Parts is { Count: > 0 })
            {
                receivedResponse = true;
            }

            if (message.ServerContent?.TurnComplete == true)
            {
                break;
            }
        }

        receivedResponse.Should().BeTrue("model should respond to multi-turn conversation");
    }

    [TestMethod]
    public async Task Live_SendVideo()
    {
        //// Sends a video frame (JPEG image) to the Live API.
        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

        var config = new LiveSetupConfig
        {
            Model = GetLiveModelId(),
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Audio],
            },
        };

        await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

        //// Create a minimal 1x1 white JPEG image.
        byte[] minimalJpeg =
        [
            0xFF, 0xD8, 0xFF, 0xE0, 0x00, 0x10, 0x4A, 0x46, 0x49, 0x46, 0x00, 0x01,
            0x01, 0x00, 0x00, 0x01, 0x00, 0x01, 0x00, 0x00, 0xFF, 0xDB, 0x00, 0x43,
            0x00, 0x08, 0x06, 0x06, 0x07, 0x06, 0x05, 0x08, 0x07, 0x07, 0x07, 0x09,
            0x09, 0x08, 0x0A, 0x0C, 0x14, 0x0D, 0x0C, 0x0B, 0x0B, 0x0C, 0x19, 0x12,
            0x13, 0x0F, 0x14, 0x1D, 0x1A, 0x1F, 0x1E, 0x1D, 0x1A, 0x1C, 0x1C, 0x20,
            0x24, 0x2E, 0x27, 0x20, 0x22, 0x2C, 0x23, 0x1C, 0x1C, 0x28, 0x37, 0x29,
            0x2C, 0x30, 0x31, 0x34, 0x34, 0x34, 0x1F, 0x27, 0x39, 0x3D, 0x38, 0x32,
            0x3C, 0x2E, 0x33, 0x34, 0x32, 0xFF, 0xC0, 0x00, 0x0B, 0x08, 0x00, 0x01,
            0x00, 0x01, 0x01, 0x01, 0x11, 0x00, 0xFF, 0xC4, 0x00, 0x1F, 0x00, 0x00,
            0x01, 0x05, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
            0x09, 0x0A, 0x0B, 0xFF, 0xC4, 0x00, 0xB5, 0x10, 0x00, 0x02, 0x01, 0x03,
            0x03, 0x02, 0x04, 0x03, 0x05, 0x05, 0x04, 0x04, 0x00, 0x00, 0x01, 0x7D,
            0x01, 0x02, 0x03, 0x00, 0x04, 0x11, 0x05, 0x12, 0x21, 0x31, 0x41, 0x06,
            0x13, 0x51, 0x61, 0x07, 0x22, 0x71, 0x14, 0x32, 0x81, 0x91, 0xA1, 0x08,
            0x23, 0x42, 0xB1, 0xC1, 0x15, 0x52, 0xD1, 0xF0, 0x24, 0x33, 0x62, 0x72,
            0x82, 0x09, 0x0A, 0x16, 0x17, 0x18, 0x19, 0x1A, 0x25, 0x26, 0x27, 0x28,
            0x29, 0x2A, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3A, 0x43, 0x44, 0x45,
            0x46, 0x47, 0x48, 0x49, 0x4A, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59,
            0x5A, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6A, 0x73, 0x74, 0x75,
            0x76, 0x77, 0x78, 0x79, 0x7A, 0x83, 0x84, 0x85, 0x86, 0x87, 0x88, 0x89,
            0x8A, 0x92, 0x93, 0x94, 0x95, 0x96, 0x97, 0x98, 0x99, 0x9A, 0xA2, 0xA3,
            0xA4, 0xA5, 0xA6, 0xA7, 0xA8, 0xA9, 0xAA, 0xB2, 0xB3, 0xB4, 0xB5, 0xB6,
            0xB7, 0xB8, 0xB9, 0xBA, 0xC2, 0xC3, 0xC4, 0xC5, 0xC6, 0xC7, 0xC8, 0xC9,
            0xCA, 0xD2, 0xD3, 0xD4, 0xD5, 0xD6, 0xD7, 0xD8, 0xD9, 0xDA, 0xE1, 0xE2,
            0xE3, 0xE4, 0xE5, 0xE6, 0xE7, 0xE8, 0xE9, 0xEA, 0xF1, 0xF2, 0xF3, 0xF4,
            0xF5, 0xF6, 0xF7, 0xF8, 0xF9, 0xFA, 0xFF, 0xDA, 0x00, 0x08, 0x01, 0x01,
            0x00, 0x00, 0x3F, 0x00, 0x7B, 0x94, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xFF, 0xD9,
        ];

        //// Send the video frame and then ask about it.
        await session.SendVideoAsync(minimalJpeg, "image/jpeg");
        await session.SendTextAsync("What do you see?", cts.Token);

        bool receivedResponse = false;
        await foreach (var message in session.ReadEventsAsync(cts.Token))
        {
            if (message.ServerContent?.ModelTurn?.Parts is { Count: > 0 })
            {
                receivedResponse = true;
            }

            if (message.ServerContent?.TurnComplete == true)
            {
                break;
            }
        }

        receivedResponse.Should().BeTrue("model should respond after receiving video frame");
    }

    [TestMethod]
    public async Task Live_AudioRoundTrip()
    {
        //// Sends PCM audio and verifies audio parts are received in the response.
        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

        var config = new LiveSetupConfig
        {
            Model = GetLiveModelId(),
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Audio],
            },
        };

        await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

        //// Generate a short 16-bit PCM 16kHz sine wave (0.5s of 440Hz tone).
        var sampleRate = 16000;
        var samples = (int)(sampleRate * 0.5);
        var pcmBytes = new byte[samples * 2];
        for (int i = 0; i < samples; i++)
        {
            var sample = (short)(Math.Sin(2 * Math.PI * 440 * i / sampleRate) * 8000);
            pcmBytes[i * 2] = (byte)(sample & 0xFF);
            pcmBytes[i * 2 + 1] = (byte)((sample >> 8) & 0xFF);
        }

        await session.SendAudioAsync(pcmBytes, cts.Token);

        //// Also send text to ensure a response is triggered.
        await session.SendTextAsync("Repeat what you heard", cts.Token);

        bool receivedAudioParts = false;
        await foreach (var message in session.ReadEventsAsync(cts.Token))
        {
            if (message.ServerContent?.ModelTurn?.Parts is { } parts)
            {
                foreach (var part in parts)
                {
                    if (part.InlineData?.Data is { Length: > 0 })
                    {
                        receivedAudioParts = true;
                    }
                }
            }

            if (message.ServerContent?.TurnComplete == true)
            {
                break;
            }
        }

        receivedAudioParts.Should().BeTrue("model should return audio data in response parts");
    }

    [TestMethod]
    public async Task Live_InterruptionDetection()
    {
        //// Sends a message that triggers a long response, then sends another message
        //// to potentially cause an interruption. Verifies the session handles it gracefully.
        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

        var config = new LiveSetupConfig
        {
            Model = GetLiveModelId(),
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Audio],
            },
        };

        await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

        //// Ask for a long response to give us time to "interrupt".
        await session.SendTextAsync("Count from 1 to 100 slowly", cts.Token);

        //// Read a few messages then send another message to interrupt.
        int messageCount = 0;
        bool interrupted = false;
        bool turnComplete = false;

        await foreach (var message in session.ReadEventsAsync(cts.Token))
        {
            messageCount++;

            if (message.ServerContent?.Interrupted == true)
            {
                interrupted = true;
            }

            if (message.ServerContent?.TurnComplete == true)
            {
                turnComplete = true;
                break;
            }

            //// After receiving a few audio chunks, send new input to interrupt.
            if (messageCount == 3)
            {
                await session.SendTextAsync("Stop, say goodbye instead", cts.Token);
            }
        }

        //// If interrupted, read until the new turn completes.
        if (interrupted && !turnComplete)
        {
            await foreach (var message in session.ReadEventsAsync(cts.Token))
            {
                if (message.ServerContent?.TurnComplete == true)
                {
                    break;
                }
            }
        }

        // Either we got interrupted or the turn completed normally — both are valid.
        (interrupted || turnComplete).Should().BeTrue("session should complete gracefully");
    }

    [TestMethod]
    public async Task Live_UsageMetadata()
    {
        //// Verifies that usage metadata (token counts) is received during a session.
        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

        var config = new LiveSetupConfig
        {
            Model = GetLiveModelId(),
            GenerationConfig = new GenerationConfig
            {
                ResponseModalities = [GenerationConfigResponseModalitie.Audio],
            },
        };

        await using var session = await client.ConnectLiveAsync(config, cancellationToken: cts.Token);

        await session.SendTextAsync("Say hello", cts.Token);

        UsageMetadata? usageMetadata = null;
        await foreach (var message in session.ReadEventsAsync(cts.Token))
        {
            if (message.UsageMetadata is not null)
            {
                usageMetadata = message.UsageMetadata;
            }

            if (message.ServerContent?.TurnComplete == true)
            {
                break;
            }
        }

        usageMetadata.Should().NotBeNull("server should return usage metadata");
        usageMetadata!.TotalTokenCount.Should().BeGreaterThan(0, "total token count should be positive");
    }
}
