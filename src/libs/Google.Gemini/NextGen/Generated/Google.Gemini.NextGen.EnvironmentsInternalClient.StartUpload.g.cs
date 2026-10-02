
#nullable enable

namespace Google.Gemini.NextGen
{
    public partial class EnvironmentsInternalClient
    {


        private static readonly global::Google.Gemini.NextGen.EndPointSecurityRequirement s_StartUploadSecurityRequirement0 =
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
        private static readonly global::Google.Gemini.NextGen.EndPointSecurityRequirement[] s_StartUploadSecurityRequirements =
            new global::Google.Gemini.NextGen.EndPointSecurityRequirement[]
            {                s_StartUploadSecurityRequirement0,
            };
        partial void PrepareStartUploadArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? extract,
            ref bool? overwrite,
            ref string xGoogUploadCommand,
            ref long xGoogUploadHeaderContentLength,
            ref string xGoogUploadHeaderContentType,
            ref string xGoogUploadProtocol,
            ref string environment,
            ref string path);
        partial void PrepareStartUploadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? extract,
            bool? overwrite,
            string xGoogUploadCommand,
            long xGoogUploadHeaderContentLength,
            string xGoogUploadHeaderContentType,
            string xGoogUploadProtocol,
            string environment,
            string path);
        partial void ProcessStartUploadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Start an environment file upload<br/>
        /// Starts a resumable upload session for a file in an environment workspace.<br/>
        /// Upload the file bytes to the URL returned in the `X-Goog-Upload-URL`<br/>
        /// response header, using the resumable upload protocol.
        /// </summary>
        /// <param name="extract"></param>
        /// <param name="overwrite"></param>
        /// <param name="xGoogUploadCommand">
        /// Default Value: start
        /// </param>
        /// <param name="xGoogUploadHeaderContentLength"></param>
        /// <param name="xGoogUploadHeaderContentType"></param>
        /// <param name="xGoogUploadProtocol">
        /// Default Value: resumable
        /// </param>
        /// <param name="environment"></param>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -i -X PUT \<br/>
        ///   'https://generativelanguage.googleapis.com/upload/v1beta/environments/env_abc123/files/main.py?overwrite=true' \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H 'X-Goog-Upload-Protocol: resumable' \<br/>
        ///   -H 'X-Goog-Upload-Command: start' \<br/>
        ///   -H "X-Goog-Upload-Header-Content-Length: $(wc -c &lt; main.py)" \<br/>
        ///   -H 'X-Goog-Upload-Header-Content-Type: text/x-python'
        /// </remarks>
        public async global::System.Threading.Tasks.Task StartUploadAsync(
            long xGoogUploadHeaderContentLength,
            string xGoogUploadHeaderContentType,
            string environment,
            string path,
            bool? extract = default,
            bool? overwrite = default,
            string xGoogUploadCommand = "start",
            string xGoogUploadProtocol = "resumable",
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            await StartUploadAsResponseAsync(
                xGoogUploadHeaderContentLength: xGoogUploadHeaderContentLength,
                xGoogUploadHeaderContentType: xGoogUploadHeaderContentType,
                environment: environment,
                path: path,
                extract: extract,
                overwrite: overwrite,
                xGoogUploadCommand: xGoogUploadCommand,
                xGoogUploadProtocol: xGoogUploadProtocol,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);
        }
        /// <summary>
        /// Start an environment file upload<br/>
        /// Starts a resumable upload session for a file in an environment workspace.<br/>
        /// Upload the file bytes to the URL returned in the `X-Goog-Upload-URL`<br/>
        /// response header, using the resumable upload protocol.
        /// </summary>
        /// <param name="extract"></param>
        /// <param name="overwrite"></param>
        /// <param name="xGoogUploadCommand">
        /// Default Value: start
        /// </param>
        /// <param name="xGoogUploadHeaderContentLength"></param>
        /// <param name="xGoogUploadHeaderContentType"></param>
        /// <param name="xGoogUploadProtocol">
        /// Default Value: resumable
        /// </param>
        /// <param name="environment"></param>
        /// <param name="path"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -i -X PUT \<br/>
        ///   'https://generativelanguage.googleapis.com/upload/v1beta/environments/env_abc123/files/main.py?overwrite=true' \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H 'X-Goog-Upload-Protocol: resumable' \<br/>
        ///   -H 'X-Goog-Upload-Command: start' \<br/>
        ///   -H "X-Goog-Upload-Header-Content-Length: $(wc -c &lt; main.py)" \<br/>
        ///   -H 'X-Goog-Upload-Header-Content-Type: text/x-python'
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse> StartUploadAsResponseAsync(
            long xGoogUploadHeaderContentLength,
            string xGoogUploadHeaderContentType,
            string environment,
            string path,
            bool? extract = default,
            bool? overwrite = default,
            string xGoogUploadCommand = "start",
            string xGoogUploadProtocol = "resumable",
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareStartUploadArguments(
                httpClient: HttpClient,
                extract: ref extract,
                overwrite: ref overwrite,
                xGoogUploadCommand: ref xGoogUploadCommand,
                xGoogUploadHeaderContentLength: ref xGoogUploadHeaderContentLength,
                xGoogUploadHeaderContentType: ref xGoogUploadHeaderContentType,
                xGoogUploadProtocol: ref xGoogUploadProtocol,
                environment: ref environment,
                path: ref path);


            var __authorizations = global::Google.Gemini.NextGen.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_StartUploadSecurityRequirements,
                operationName: "StartUploadAsync");

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
                                path: $"/upload/v1beta/environments/{environment}/files/{path}",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("extract", extract?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("overwrite", overwrite?.ToString().ToLowerInvariant())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Put,
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

                __httpRequest.Headers.TryAddWithoutValidation("X-Goog-Upload-Command", xGoogUploadCommand.ToString());
                __httpRequest.Headers.TryAddWithoutValidation("X-Goog-Upload-Header-Content-Length", xGoogUploadHeaderContentLength.ToString());
                __httpRequest.Headers.TryAddWithoutValidation("X-Goog-Upload-Header-Content-Type", xGoogUploadHeaderContentType.ToString());
                __httpRequest.Headers.TryAddWithoutValidation("X-Goog-Upload-Protocol", xGoogUploadProtocol.ToString());

                global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareStartUploadRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    extract: extract,
                    overwrite: overwrite,
                    xGoogUploadCommand: xGoogUploadCommand,
                    xGoogUploadHeaderContentLength: xGoogUploadHeaderContentLength,
                    xGoogUploadHeaderContentType: xGoogUploadHeaderContentType,
                    xGoogUploadProtocol: xGoogUploadProtocol,
                    environment: environment,
                    path: path);

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
                                operationId: "StartUpload",
                                methodName: "StartUploadAsync",
                                pathTemplate: "$\"/upload/v1beta/environments/{environment}/files/{path}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "StartUpload",
                                methodName: "StartUploadAsync",
                                pathTemplate: "$\"/upload/v1beta/environments/{environment}/files/{path}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "StartUpload",
                                methodName: "StartUploadAsync",
                                pathTemplate: "$\"/upload/v1beta/environments/{environment}/files/{path}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                ProcessStartUploadResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Google.Gemini.NextGen.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StartUpload",
                                methodName: "StartUploadAsync",
                                pathTemplate: "$\"/upload/v1beta/environments/{environment}/files/{path}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "StartUpload",
                                methodName: "StartUploadAsync",
                                pathTemplate: "$\"/upload/v1beta/environments/{environment}/files/{path}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                            //
                            if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
                            {
                                string? __content_4XX = null;
                                global::System.Exception? __exception_4XX = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_4XX = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_4XX = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_4XX = __ex;
                                }


                                throw global::Google.Gemini.NextGen.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_4XX ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_4XX,
                                    responseBody: __content_4XX,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            //
                            if ((int)__response.StatusCode >= 500 && (int)__response.StatusCode <= 599)
                            {
                                string? __content_5XX = null;
                                global::System.Exception? __exception_5XX = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_5XX = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_5XX = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_5XX = __ex;
                                }


                                throw global::Google.Gemini.NextGen.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_5XX ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_5XX,
                                    responseBody: __content_5XX,
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

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                return new global::Google.Gemini.NextGen.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::Google.Gemini.NextGen.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
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
                                    return new global::Google.Gemini.NextGen.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::Google.Gemini.NextGen.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
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