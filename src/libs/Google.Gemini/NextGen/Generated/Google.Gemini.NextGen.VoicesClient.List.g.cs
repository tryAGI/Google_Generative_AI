
#nullable enable

namespace Google.Gemini.NextGen
{
    public partial class VoicesClient
    {


        private static readonly global::Google.Gemini.NextGen.EndPointSecurityRequirement s_ListSecurityRequirement0 =
            new global::Google.Gemini.NextGen.EndPointSecurityRequirement
            {
                Authorizations = new global::Google.Gemini.NextGen.EndPointAuthorizationRequirement[]
                {                    new global::Google.Gemini.NextGen.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyXGoogApiKey",
                        Location = "Header",
                        Name = "x-goog-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::Google.Gemini.NextGen.EndPointSecurityRequirement[] s_ListSecurityRequirements =
            new global::Google.Gemini.NextGen.EndPointSecurityRequirement[]
            {                s_ListSecurityRequirement0,
            };
        partial void PrepareListArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<string>? accent,
            global::System.Collections.Generic.IList<string>? contexts,
            global::System.Collections.Generic.IList<string>? gender,
            global::System.Collections.Generic.IList<string>? languageCode,
            ref int? pageSize,
            ref string? pageToken,
            global::System.Collections.Generic.IList<string>? persona,
            global::System.Collections.Generic.IList<string>? pitch,
            global::System.Collections.Generic.IList<string>? regionCode,
            ref string? search,
            global::System.Collections.Generic.IList<string>? type);
        partial void PrepareListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<string>? accent,
            global::System.Collections.Generic.IList<string>? contexts,
            global::System.Collections.Generic.IList<string>? gender,
            global::System.Collections.Generic.IList<string>? languageCode,
            int? pageSize,
            string? pageToken,
            global::System.Collections.Generic.IList<string>? persona,
            global::System.Collections.Generic.IList<string>? pitch,
            global::System.Collections.Generic.IList<string>? regionCode,
            string? search,
            global::System.Collections.Generic.IList<string>? type);
        partial void ProcessListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Lists custom stored voices owned by the caller (ordered newest first)<br/>
        /// followed by prebuilt system voices from Google's voice catalog.
        /// </summary>
        /// <param name="accent"></param>
        /// <param name="contexts"></param>
        /// <param name="gender"></param>
        /// <param name="languageCode"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="persona"></param>
        /// <param name="pitch"></param>
        /// <param name="regionCode"></param>
        /// <param name="search"></param>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X GET https://generativelanguage.googleapis.com/v1beta/voices \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.ListVoicesResponse> ListAsync(
            global::System.Collections.Generic.IList<string>? accent = default,
            global::System.Collections.Generic.IList<string>? contexts = default,
            global::System.Collections.Generic.IList<string>? gender = default,
            global::System.Collections.Generic.IList<string>? languageCode = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Collections.Generic.IList<string>? persona = default,
            global::System.Collections.Generic.IList<string>? pitch = default,
            global::System.Collections.Generic.IList<string>? regionCode = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? type = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListAsResponseAsync(
                accent: accent,
                contexts: contexts,
                gender: gender,
                languageCode: languageCode,
                pageSize: pageSize,
                pageToken: pageToken,
                persona: persona,
                pitch: pitch,
                regionCode: regionCode,
                search: search,
                type: type,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Lists custom stored voices owned by the caller (ordered newest first)<br/>
        /// followed by prebuilt system voices from Google's voice catalog.
        /// </summary>
        /// <param name="accent"></param>
        /// <param name="contexts"></param>
        /// <param name="gender"></param>
        /// <param name="languageCode"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="persona"></param>
        /// <param name="pitch"></param>
        /// <param name="regionCode"></param>
        /// <param name="search"></param>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X GET https://generativelanguage.googleapis.com/v1beta/voices \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.ListVoicesResponse>> ListAsResponseAsync(
            global::System.Collections.Generic.IList<string>? accent = default,
            global::System.Collections.Generic.IList<string>? contexts = default,
            global::System.Collections.Generic.IList<string>? gender = default,
            global::System.Collections.Generic.IList<string>? languageCode = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Collections.Generic.IList<string>? persona = default,
            global::System.Collections.Generic.IList<string>? pitch = default,
            global::System.Collections.Generic.IList<string>? regionCode = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? type = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListArguments(
                httpClient: HttpClient,
                accent: accent,
                contexts: contexts,
                gender: gender,
                languageCode: languageCode,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                persona: persona,
                pitch: pitch,
                regionCode: regionCode,
                search: ref search,
                type: type);


            var __authorizations = global::Google.Gemini.NextGen.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListSecurityRequirements,
                operationName: "ListAsync");

            using var __timeoutCancellationTokenSource = global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Google.Gemini.NextGen.PathBuilder(
                                path: "/v1beta/voices",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("accent", accent, delimiter: ",", explode: true)
                                .AddOptionalParameter("contexts", contexts, delimiter: ",", explode: true)
                                .AddOptionalParameter("gender", gender, delimiter: ",", explode: true)
                                .AddOptionalParameter("language_code", languageCode, delimiter: ",", explode: true)
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("page_token", pageToken)
                                .AddOptionalParameter("persona", persona, delimiter: ",", explode: true)
                                .AddOptionalParameter("pitch", pitch, delimiter: ",", explode: true)
                                .AddOptionalParameter("region_code", regionCode, delimiter: ",", explode: true)
                                .AddOptionalParameter("search", search)
                                .AddOptionalParameter("type", type, delimiter: ",", explode: true)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    accent: accent,
                    contexts: contexts,
                    gender: gender,
                    languageCode: languageCode,
                    pageSize: pageSize,
                    pageToken: pageToken,
                    persona: persona,
                    pitch: pitch,
                    regionCode: regionCode,
                    search: search,
                    type: type);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "List",
                                methodName: "ListAsync",
                                pathTemplate: "\"/v1beta/voices\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "List",
                                methodName: "ListAsync",
                                pathTemplate: "\"/v1beta/voices\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "List",
                                methodName: "ListAsync",
                                pathTemplate: "\"/v1beta/voices\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessListResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "List",
                                methodName: "ListAsync",
                                pathTemplate: "\"/v1beta/voices\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "List",
                                methodName: "ListAsync",
                                pathTemplate: "\"/v1beta/voices\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Successful operation
                            if (!__response.IsSuccessStatusCode)
                            {
                                string? __content_default = null;
                                global::System.Exception? __exception_default = null;
                                global::Google.Gemini.NextGen.ListVoicesResponse? __value_default = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_default = global::Google.Gemini.NextGen.ListVoicesResponse.FromJson(__content_default, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_default = global::Google.Gemini.NextGen.ListVoicesResponse.FromJson(__content_default, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_default = __ex;
                                }


                                throw global::Google.Gemini.NextGen.ApiException<global::Google.Gemini.NextGen.ListVoicesResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_default,
                                    responseBody: __content_default,
                                    responseObject: __value_default,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessListResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Google.Gemini.NextGen.ListVoicesResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.ListVoicesResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Google.Gemini.NextGen.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Google.Gemini.NextGen.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Google.Gemini.NextGen.ListVoicesResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.ListVoicesResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Google.Gemini.NextGen.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Google.Gemini.NextGen.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}