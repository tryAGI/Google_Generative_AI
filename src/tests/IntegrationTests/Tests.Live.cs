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
}
