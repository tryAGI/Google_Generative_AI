
#nullable enable

namespace Google.Gemini
{
    public partial class GeminiClient
    {


        private static readonly global::Google.Gemini.EndPointSecurityRequirement s_MediaUploadToFileSearchStoreSecurityRequirement0 =
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
        private static readonly global::Google.Gemini.EndPointSecurityRequirement[] s_MediaUploadToFileSearchStoreSecurityRequirements =
            new global::Google.Gemini.EndPointSecurityRequirement[]
            {                s_MediaUploadToFileSearchStoreSecurityRequirement0,
            };
        partial void PrepareMediaUploadToFileSearchStoreArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string fileSearchStoresId,
            global::Google.Gemini.UploadToFileSearchStoreRequest request);
        partial void PrepareMediaUploadToFileSearchStoreRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string fileSearchStoresId,
            global::Google.Gemini.UploadToFileSearchStoreRequest request);
        partial void ProcessMediaUploadToFileSearchStoreResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMediaUploadToFileSearchStoreResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Uploads data to a FileSearchStore, preprocesses and chunks before storing it in a FileSearchStore Document.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Google.Gemini.CustomLongRunningOperation> MediaUploadToFileSearchStoreAsync(
            string fileSearchStoresId,

            global::Google.Gemini.UploadToFileSearchStoreRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareMediaUploadToFileSearchStoreArguments(
                httpClient: HttpClient,
                fileSearchStoresId: ref fileSearchStoresId,
                request: request);


            var __authorizations = global::Google.Gemini.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_MediaUploadToFileSearchStoreSecurityRequirements,
                operationName: "MediaUploadToFileSearchStoreAsync");

            var __pathBuilder = new global::Google.Gemini.PathBuilder(
                path: $"/fileSearchStores/{fileSearchStoresId}:uploadToFileSearchStore",
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
            PrepareMediaUploadToFileSearchStoreRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                fileSearchStoresId: fileSearchStoresId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessMediaUploadToFileSearchStoreResponse(
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
                ProcessMediaUploadToFileSearchStoreResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Google.Gemini.CustomLongRunningOperation.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Google.Gemini.CustomLongRunningOperation.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }
        /// <summary>
        /// Uploads data to a FileSearchStore, preprocesses and chunks before storing it in a FileSearchStore Document.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="customMetadata">
        /// Custom metadata to be associated with the data.
        /// </param>
        /// <param name="mimeType">
        /// Optional. MIME type of the data. If not provided, it will be inferred from the uploaded content.
        /// </param>
        /// <param name="chunkingConfig">
        /// Parameters for telling the service how to chunk the file. inspired by google3/cloud/ai/platform/extension/lib/retrieval/config/chunker_config.proto
        /// </param>
        /// <param name="displayName">
        /// Optional. Display name of the created document.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Google.Gemini.CustomLongRunningOperation> MediaUploadToFileSearchStoreAsync(
            string fileSearchStoresId,
            global::System.Collections.Generic.IList<global::Google.Gemini.CustomMetadata>? customMetadata = default,
            string? mimeType = default,
            global::Google.Gemini.ChunkingConfig? chunkingConfig = default,
            string? displayName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Google.Gemini.UploadToFileSearchStoreRequest
            {
                CustomMetadata = customMetadata,
                MimeType = mimeType,
                ChunkingConfig = chunkingConfig,
                DisplayName = displayName,
            };

            return await MediaUploadToFileSearchStoreAsync(
                fileSearchStoresId: fileSearchStoresId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}