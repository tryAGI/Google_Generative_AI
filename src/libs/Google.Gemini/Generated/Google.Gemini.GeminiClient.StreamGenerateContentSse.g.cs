#nullable enable

namespace Google.Gemini;

public sealed partial class GeminiClient
{
#pragma warning disable CA1822 // Generated partial hooks must remain instance methods.
    partial void PrepareModelsStreamGenerateContentAsStreamRequest(
        HttpClient httpClient, HttpRequestMessage httpRequestMessage, string modelsId, GenerateContentRequest request)
        => RequireSseResponse(httpRequestMessage);

    partial void PrepareDynamicStreamGenerateContentAsStreamRequest(
        HttpClient httpClient, HttpRequestMessage httpRequestMessage, string dynamicId, GenerateContentRequest request)
        => RequireSseResponse(httpRequestMessage);

    partial void PrepareTunedModelsStreamGenerateContentAsStreamRequest(
        HttpClient httpClient, HttpRequestMessage httpRequestMessage, string tunedModelsId, GenerateContentRequest request)
        => RequireSseResponse(httpRequestMessage);
#pragma warning restore CA1822

    private static void RequireSseResponse(HttpRequestMessage request)
    {
        var uri = new UriBuilder(request.RequestUri ?? throw new InvalidOperationException("Request URI is missing."));
        var parameters = uri.Query.TrimStart('?').Split('&', StringSplitOptions.RemoveEmptyEntries)
            .Where(parameter => !string.Equals(
                Uri.UnescapeDataString(parameter.Split('=', 2)[0]), "alt", StringComparison.OrdinalIgnoreCase));
        uri.Query = string.Join("&", parameters.Append("alt=sse"));
        request.RequestUri = uri.Uri;
    }
}
