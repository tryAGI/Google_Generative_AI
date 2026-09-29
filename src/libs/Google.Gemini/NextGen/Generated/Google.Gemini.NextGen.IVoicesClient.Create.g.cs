#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Creates a custom voice from a natural-language prompt<br/>
        /// (`VOICE_TYPE_PROMPTED`) or from reference and consent audio recordings<br/>
        /// (`VOICE_TYPE_REPLICATED`).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://generativelanguage.googleapis.com/v1beta/voices \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "store": true,<br/>
        ///     "voice": {<br/>
        ///       "type": "prompted",<br/>
        ///       "display_name": "Warm Narrator",<br/>
        ///       "language_code": "en-US",<br/>
        ///       "prompted": {<br/>
        ///         "input": "A warm, friendly narrator voice with a calm pace."<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Voice> CreateAsync(

            global::Google.Gemini.NextGen.CreateVoiceRequest request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a custom voice from a natural-language prompt<br/>
        /// (`VOICE_TYPE_PROMPTED`) or from reference and consent audio recordings<br/>
        /// (`VOICE_TYPE_REPLICATED`).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X POST https://generativelanguage.googleapis.com/v1beta/voices \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "store": true,<br/>
        ///     "voice": {<br/>
        ///       "type": "prompted",<br/>
        ///       "display_name": "Warm Narrator",<br/>
        ///       "language_code": "en-US",<br/>
        ///       "prompted": {<br/>
        ///         "input": "A warm, friendly narrator voice with a calm pace."<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.Voice>> CreateAsResponseAsync(

            global::Google.Gemini.NextGen.CreateVoiceRequest request,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a custom voice from a natural-language prompt<br/>
        /// (`VOICE_TYPE_PROMPTED`) or from reference and consent audio recordings<br/>
        /// (`VOICE_TYPE_REPLICATED`).
        /// </summary>
        /// <param name="store">
        /// Optional. Whether the created voice is persisted and managed by Google.<br/>
        /// * When `true`, Google stores the voice and returns `Voice.id` (for example,<br/>
        ///   `voice_abc123def456`), which can be managed via `GetVoice`, `ListVoices`,<br/>
        ///   and `DeleteVoice` and referenced by ID in synthesis requests. Projects<br/>
        ///   are subject to a maximum active stored voice quota; exceeding the quota<br/>
        ///   returns `RESOURCE_EXHAUSTED`.<br/>
        /// * When `false` (default), the voice is not stored by Google and `Voice.key`<br/>
        ///   (for example, `voicekey_...`) is returned for client-side storage and<br/>
        ///   synthesis. Optional discovery metadata fields on `voice` are not<br/>
        ///   persisted or returned when `store` is `false`.<br/>
        /// * Required to be `true` when `voice.type` is `"prompted"`<br/>
        ///   (otherwise fails with `INVALID_ARGUMENT`).
        /// </param>
        /// <param name="voice">
        /// A voice resource representing either a custom voice (created via<br/>
        /// `CreateVoice`) or a prebuilt system voice (returned by `ListVoices`).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Voice> CreateAsync(
            global::Google.Gemini.NextGen.Voice voice,
            bool? store = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}