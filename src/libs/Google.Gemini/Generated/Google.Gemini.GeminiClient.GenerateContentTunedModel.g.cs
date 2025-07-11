
#nullable enable

namespace Google.Gemini
{
    public partial class GeminiClient
    {
        partial void PrepareGenerateContentTunedModelArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string tunedModelId,
            global::Google.Gemini.GenerateContentRequest request);
        partial void PrepareGenerateContentTunedModelRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string tunedModelId,
            global::Google.Gemini.GenerateContentRequest request);
        partial void ProcessGenerateContentTunedModelResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateContentTunedModelResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generates a response from the model given an input `GenerateContentRequest`.
        /// </summary>
        /// <param name="tunedModelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Google.Gemini.GenerateContentResponse> GenerateContentTunedModelAsync(
            string tunedModelId,
            global::Google.Gemini.GenerateContentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGenerateContentTunedModelArguments(
                httpClient: HttpClient,
                tunedModelId: ref tunedModelId,
                request: request);

            var __pathBuilder = new global::Google.Gemini.PathBuilder(
                path: $"/tunedModels/{tunedModelId}:generateContent",
                baseUri: HttpClient.BaseAddress);
            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Query")
                {
                    __pathBuilder = __pathBuilder.AddRequiredParameter(__authorization.Name, __authorization.Value);
                }
            } 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGenerateContentTunedModelRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                tunedModelId: tunedModelId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGenerateContentTunedModelResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessGenerateContentTunedModelResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Google.Gemini.GenerateContentResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Google.Gemini.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Google.Gemini.GenerateContentResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Google.Gemini.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// Generates a response from the model given an input `GenerateContentRequest`.
        /// </summary>
        /// <param name="tunedModelId"></param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model. For single-turn queries, this is a single instance. For multi-turn queries, this is a repeated field that contains conversation history + latest request.
        /// </param>
        /// <param name="generationConfig">
        /// Configuration options for model generation and outputs. Not all parameters may be configurable for every model.
        /// </param>
        /// <param name="safetySettings">
        /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content. This will be enforced on the `GenerateContentRequest.contents` and `GenerateContentResponse.candidates`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT are supported.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Google.Gemini.GenerateContentResponse> GenerateContentTunedModelAsync(
            string tunedModelId,
            global::System.Collections.Generic.IList<global::Google.Gemini.Content>? contents = default,
            global::Google.Gemini.GenerationConfig? generationConfig = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? safetySettings = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Google.Gemini.GenerateContentRequest
            {
                Contents = contents,
                GenerationConfig = generationConfig,
                SafetySettings = safetySettings,
            };

            return await GenerateContentTunedModelAsync(
                tunedModelId: tunedModelId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}