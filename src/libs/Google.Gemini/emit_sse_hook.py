#!/usr/bin/env python3
"""Emit the Gemini-specific SSE query hook after AutoSDK generation.

Google's Discovery document describes streamGenerateContent, but omits the
required ``alt=sse`` query option. AutoSDK already emits SSE readers for these
operations; this generated partial supplies the request-side protocol option.
"""

from pathlib import Path


output = Path(__file__).resolve().parent / "Generated" / "Google.Gemini.GeminiClient.StreamGenerateContentSse.g.cs"
output.write_text('''#nullable enable

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
''')
