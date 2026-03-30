/*
order: 360
title: Live Tool Calling
slug: live-tool-calling
*/

using System.Net.WebSockets;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Live_ToolCalling()
    {
        using var client = GetAuthenticatedClient();

        try
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

            //// Connects to the Live API with a tool and handles a function call.
            var config = CreateLiveConfig();
            config.Tools =
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
            ];

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
        catch (WebSocketException ex)
        {
            Assert.Inconclusive("WebSocket error: " + ex.Message[..Math.Min(ex.Message.Length, 200)]);
        }
        catch (OperationCanceledException)
        {
            Assert.Inconclusive("Live API connection timed out.");
        }
    }
}
