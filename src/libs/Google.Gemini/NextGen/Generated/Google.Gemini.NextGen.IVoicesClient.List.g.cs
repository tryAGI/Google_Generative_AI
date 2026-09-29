#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IVoicesClient
    {
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
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.ListVoicesResponse> ListAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.ListVoicesResponse>> ListAsResponseAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}