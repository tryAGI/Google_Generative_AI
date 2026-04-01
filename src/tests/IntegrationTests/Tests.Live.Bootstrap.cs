namespace Google.Gemini.IntegrationTests;

using System.Reflection;

public partial class Tests
{
    [TestMethod]
    public async Task Live_Bootstrap_AllowsSessionResumptionUpdateBeforeSetupComplete()
    {
        var invocations = 0;

        await InvokeWaitForSetupCompleteAsync(_ =>
        {
            invocations++;

            return Task.FromResult(invocations switch
            {
                1 => new LiveServerMessage
                {
                    SessionResumptionUpdate = new LiveSessionResumptionUpdate
                    {
                        NewHandle = "resume-handle",
                    },
                },
                2 => new LiveServerMessage
                {
                    SetupComplete = new LiveSetupComplete(),
                },
                _ => null,
            });
        });

        invocations.Should().Be(2);
    }

    [TestMethod]
    public async Task Live_Bootstrap_AllowsUsageMetadataBeforeSetupComplete()
    {
        var invocations = 0;

        await InvokeWaitForSetupCompleteAsync(_ =>
        {
            invocations++;

            return Task.FromResult(invocations switch
            {
                1 => new LiveServerMessage
                {
                    UsageMetadata = new UsageMetadata
                    {
                        ResponseTokenCount = 1,
                    },
                },
                2 => new LiveServerMessage
                {
                    SetupComplete = new LiveSetupComplete(),
                },
                _ => null,
            });
        });

        invocations.Should().Be(2);
    }

    [TestMethod]
    public async Task Live_Bootstrap_ThrowsWhenConnectionClosesBeforeSetupComplete()
    {
        var invocations = 0;
        Func<Task> act = () => InvokeWaitForSetupCompleteAsync(_ =>
        {
            invocations++;

            return Task.FromResult(invocations switch
            {
                1 => new LiveServerMessage
                {
                    UsageMetadata = new UsageMetadata(),
                },
                _ => null,
            });
        });

        var exception = await act.Should().ThrowAsync<InvalidOperationException>();
        exception.Which.Message.Should().Contain("connection closed before SetupComplete");
        invocations.Should().Be(2);
    }

    [TestMethod]
    public async Task Live_Bootstrap_ThrowsForUnexpectedMessageBeforeSetupComplete()
    {
        var invocations = 0;
        Func<Task> act = () => InvokeWaitForSetupCompleteAsync(_ =>
        {
            invocations++;

            return Task.FromResult(invocations switch
            {
                1 => new LiveServerMessage
                {
                    ServerContent = new LiveServerContent
                    {
                        TurnComplete = false,
                    },
                },
                _ => null,
            });
        });

        var exception = await act.Should().ThrowAsync<InvalidOperationException>();
        exception.Which.Message.Should().Contain("unexpected bootstrap message");
        exception.Which.Message.Should().Contain(nameof(LiveServerMessage.ServerContent));
        invocations.Should().Be(1);
    }

    private static async Task InvokeWaitForSetupCompleteAsync(
        Func<CancellationToken, Task<LiveServerMessage?>> receiveAsync)
    {
        var method = typeof(GeminiClientLiveExtensions).GetMethod(
            "WaitForSetupCompleteAsync",
            BindingFlags.NonPublic | BindingFlags.Static);

        Assert.IsNotNull(method);

        var task = method.Invoke(null, [receiveAsync, CancellationToken.None]) as Task;
        Assert.IsNotNull(task);

        await task;
    }
}
