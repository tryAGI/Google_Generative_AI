using System.Net;

namespace Google.Gemini.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task StreamGenerateContent_RequestsSse_ForEveryModelKind()
    {
        var paths = new[] { "models", "dynamic", "tunedModels" };
        foreach (var path in paths)
        {
            Uri? requestedUri = null;
            using var transport = new HttpClient(new StubHandler(request =>
            {
                requestedUri = request.RequestUri;
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("data: {}\n\n")
                };
            }));
            using var client = new GeminiClient("test-key", transport);
            var options = new AutoSDKRequestOptions();
            options.QueryParameters["alt"] = "json";
            var content = new GenerateContentRequest { Contents = [] };

            var events = path switch
            {
                "models" => client.ModelsStreamGenerateContentAsStreamAsync("test", content, options),
                "dynamic" => client.DynamicStreamGenerateContentAsStreamAsync("test", content, options),
                _ => client.TunedModelsStreamGenerateContentAsStreamAsync("test", content, options)
            };
            var count = 0;
            await foreach (var _ in events)
            {
                count++;
            }

            Assert.AreEqual(1, count);
            Assert.IsNotNull(requestedUri);
            StringAssert.Contains(requestedUri.AbsolutePath, $"/{path}/test:streamGenerateContent");
            StringAssert.Contains(requestedUri.Query, "alt=sse");
            Assert.AreEqual(1, requestedUri.Query.Split("alt=", StringSplitOptions.None).Length - 1);
        }
    }

    private sealed class StubHandler(Func<HttpRequestMessage, HttpResponseMessage> respond) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            => Task.FromResult(respond(request));
    }
}
