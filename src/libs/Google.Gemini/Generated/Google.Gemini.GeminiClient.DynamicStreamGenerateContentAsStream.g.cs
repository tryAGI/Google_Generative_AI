
#nullable enable

namespace Google.Gemini
{
    public partial class GeminiClient
    {


        private static readonly global::Google.Gemini.EndPointSecurityRequirement s_DynamicStreamGenerateContentAsStreamSecurityRequirement0 =
            new global::Google.Gemini.EndPointSecurityRequirement
            {
                Authorizations = new global::Google.Gemini.EndPointAuthorizationRequirement[]
                {                    new global::Google.Gemini.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Query",
                        Name = "key",
                        FriendlyName = "ApiKeyInQuery",
                    },
                },
            };
        private static readonly global::Google.Gemini.EndPointSecurityRequirement[] s_DynamicStreamGenerateContentAsStreamSecurityRequirements =
            new global::Google.Gemini.EndPointSecurityRequirement[]
            {                s_DynamicStreamGenerateContentAsStreamSecurityRequirement0,
            };
        partial void PrepareDynamicStreamGenerateContentAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string dynamicId,
            global::Google.Gemini.GenerateContentRequest request);
        partial void PrepareDynamicStreamGenerateContentAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string dynamicId,
            global::Google.Gemini.GenerateContentRequest request);
        partial void ProcessDynamicStreamGenerateContentAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Generates a [streamed response](https://ai.google.dev/gemini-api/docs/text-generation?lang=python#generate-a-text-stream) from the model given an input `GenerateContentRequest`.
        /// </summary>
        /// <param name="dynamicId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Google.Gemini.GenerateContentResponse> DynamicStreamGenerateContentAsStreamAsync(
            string dynamicId,

            global::Google.Gemini.GenerateContentRequest request,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareDynamicStreamGenerateContentAsStreamArguments(
                httpClient: HttpClient,
                dynamicId: ref dynamicId,
                request: request);


            var __authorizations = global::Google.Gemini.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_DynamicStreamGenerateContentAsStreamSecurityRequirements,
                operationName: "DynamicStreamGenerateContentAsStreamAsync");

            var __pathBuilder = new global::Google.Gemini.PathBuilder(
                path: $"/dynamic/{dynamicId}:streamGenerateContent",
                baseUri: HttpClient.BaseAddress);
            foreach (var __authorization in __authorizations)
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
            PrepareDynamicStreamGenerateContentAsStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                dynamicId: dynamicId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDynamicStreamGenerateContentAsStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                string? __content = null;
                try
                {
                    __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);
                }
                catch (global::System.Exception)
                {
                }

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

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);

            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                .Create(__stream).EnumerateAsync(cancellationToken))
            {
                var __content = __sseEvent.Data;
                if (__content == "[DONE]")
                {
                    yield break;
                }

                var __streamedResponse = global::Google.Gemini.GenerateContentResponse.FromJson(__content, JsonSerializerContext) ??
                                       throw new global::Google.Gemini.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
            }
        }
        /// <summary>
        /// Generates a [streamed response](https://ai.google.dev/gemini-api/docs/text-generation?lang=python#generate-a-text-stream) from the model given an input `GenerateContentRequest`.
        /// </summary>
        /// <param name="dynamicId"></param>
        /// <param name="cachedContent">
        /// Optional. The name of the content [cached](https://ai.google.dev/gemini-api/docs/caching) to use as context to serve the prediction. Format: `cachedContents/{cachedContent}`
        /// </param>
        /// <param name="safetySettings">
        /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content. This will be enforced on the `GenerateContentRequest.contents` and `GenerateContentResponse.candidates`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT, HARM_CATEGORY_CIVIC_INTEGRITY are supported. Refer to the [guide](https://ai.google.dev/gemini-api/docs/safety-settings) for detailed information on available safety settings. Also refer to the [Safety guidance](https://ai.google.dev/gemini-api/docs/safety-guidance) to learn how to incorporate safety considerations in your AI applications.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model. For single-turn queries, this is a single instance. For multi-turn queries like [chat](https://ai.google.dev/gemini-api/docs/text-generation#chat), this is a repeated field that contains the conversation history and the latest request.
        /// </param>
        /// <param name="toolConfig">
        /// The Tool configuration containing parameters for specifying `Tool` use in the request.
        /// </param>
        /// <param name="serviceTier">
        /// Optional. The service tier of the request.
        /// </param>
        /// <param name="model">
        /// Required. The name of the `Model` to use for generating the completion. Format: `models/{model}`.
        /// </param>
        /// <param name="tools">
        /// Optional. A list of `Tools` the `Model` may use to generate the next response. A `Tool` is a piece of code that enables the system to interact with external systems to perform an action, or set of actions, outside of knowledge and scope of the `Model`. Supported `Tool`s are `Function` and `code_execution`. Refer to the [Function calling](https://ai.google.dev/gemini-api/docs/function-calling) and the [Code execution](https://ai.google.dev/gemini-api/docs/code-execution) guides to learn more.
        /// </param>
        /// <param name="store">
        /// Optional. Configures the logging behavior for a given request. If set, it takes precedence over the project-level logging config.
        /// </param>
        /// <param name="systemInstruction">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
        /// <param name="generationConfig">
        /// Configuration options for model generation and outputs. Not all parameters are configurable for every model.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Google.Gemini.GenerateContentResponse> DynamicStreamGenerateContentAsStreamAsync(
            string dynamicId,
            string? cachedContent = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? safetySettings = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.Content>? contents = default,
            global::Google.Gemini.ToolConfig? toolConfig = default,
            global::Google.Gemini.GenerateContentRequestServiceTier? serviceTier = default,
            string? model = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.Tool>? tools = default,
            bool? store = default,
            global::Google.Gemini.Content? systemInstruction = default,
            global::Google.Gemini.GenerationConfig? generationConfig = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Google.Gemini.GenerateContentRequest
            {
                CachedContent = cachedContent,
                SafetySettings = safetySettings,
                Contents = contents,
                ToolConfig = toolConfig,
                ServiceTier = serviceTier,
                Model = model,
                Tools = tools,
                Store = store,
                SystemInstruction = systemInstruction,
                GenerationConfig = generationConfig,
            };

            var __enumerable = DynamicStreamGenerateContentAsStreamAsync(
                dynamicId: dynamicId,
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}