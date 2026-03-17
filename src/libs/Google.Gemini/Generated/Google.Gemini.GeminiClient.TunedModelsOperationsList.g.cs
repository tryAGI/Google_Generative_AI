
#nullable enable

namespace Google.Gemini
{
    public partial class GeminiClient
    {
        partial void PrepareTunedModelsOperationsListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string tunedModelsId,
            ref string? filter,
            ref int? pageSize,
            ref string? pageToken,
            ref bool? returnPartialSuccess);
        partial void PrepareTunedModelsOperationsListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string tunedModelsId,
            string? filter,
            int? pageSize,
            string? pageToken,
            bool? returnPartialSuccess);
        partial void ProcessTunedModelsOperationsListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTunedModelsOperationsListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method, it returns `UNIMPLEMENTED`.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="returnPartialSuccess"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Google.Gemini.ListOperationsResponse> TunedModelsOperationsListAsync(
            string tunedModelsId,
            string? filter = default,
            int? pageSize = default,
            string? pageToken = default,
            bool? returnPartialSuccess = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareTunedModelsOperationsListArguments(
                httpClient: HttpClient,
                tunedModelsId: ref tunedModelsId,
                filter: ref filter,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                returnPartialSuccess: ref returnPartialSuccess);

            var __pathBuilder = new global::Google.Gemini.PathBuilder(
                path: $"/tunedModels/{tunedModelsId}/operations",
                baseUri: HttpClient.BaseAddress);
            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Query")
                {
                    __pathBuilder = __pathBuilder.AddRequiredParameter(__authorization.Name, __authorization.Value);
                }
            } 
            __pathBuilder
                .AddOptionalParameter("filter", filter)
                .AddOptionalParameter("pageSize", pageSize?.ToString())
                .AddOptionalParameter("pageToken", pageToken)
                .AddOptionalParameter("returnPartialSuccess", returnPartialSuccess?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTunedModelsOperationsListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                tunedModelsId: tunedModelsId,
                filter: filter,
                pageSize: pageSize,
                pageToken: pageToken,
                returnPartialSuccess: returnPartialSuccess);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTunedModelsOperationsListResponse(
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
                ProcessTunedModelsOperationsListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Google.Gemini.ListOperationsResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Google.Gemini.ListOperationsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
    }
}