#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Gets a custom stored voice (`store = true`) by resource name.<br/>
        /// Prebuilt catalog voices (`VOICE_TYPE_PREBUILT`) cannot be retrieved via<br/>
        /// `GetVoice`; use `ListVoices` instead.
        /// </summary>
        /// <param name="voicesId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X GET https://generativelanguage.googleapis.com/v1beta/voices/voice_abc123 \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Voice> GetAsync(
            string voicesId,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a custom stored voice (`store = true`) by resource name.<br/>
        /// Prebuilt catalog voices (`VOICE_TYPE_PREBUILT`) cannot be retrieved via<br/>
        /// `GetVoice`; use `ListVoices` instead.
        /// </summary>
        /// <param name="voicesId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X GET https://generativelanguage.googleapis.com/v1beta/voices/voice_abc123 \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.Voice>> GetAsResponseAsync(
            string voicesId,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}