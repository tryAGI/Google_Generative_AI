#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Creates a token that can be used to constrain the behavior of a BidiGenerateContent session.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.AuthToken> AuthTokensCreateAsync(

            global::Google.Gemini.AuthToken request,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a token that can be used to constrain the behavior of a BidiGenerateContent session.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.AutoSDKHttpResponse<global::Google.Gemini.AuthToken>> AuthTokensCreateAsResponseAsync(

            global::Google.Gemini.AuthToken request,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a token that can be used to constrain the behavior of a BidiGenerateContent session.
        /// </summary>
        /// <param name="expireTime">
        /// Optional. Input only. Immutable. An optional time after which, when using the resulting token, messages in BidiGenerateContent sessions will be rejected. (Gemini may preemptively close the session after this time.) If not set then this defaults to 30 minutes in the future. If set, this value must be less than 20 hours in the future.
        /// </param>
        /// <param name="newSessionExpireTime">
        /// Optional. Input only. Immutable. The time after which new Live API sessions using the token resulting from this request will be rejected. If not set this defaults to 60 seconds in the future. If set, this value must be less than 20 hours in the future.
        /// </param>
        /// <param name="uses">
        /// Optional. Input only. Immutable. The number of times the token can be used. If this value is zero then no limit is applied. Resuming a Live API session does not count as a use. If unspecified, the default is 1.
        /// </param>
        /// <param name="fieldMask">
        /// Optional. Input only. Immutable. If field_mask is empty, and `bidi_generate_content_setup` is not present, then the effective `BidiGenerateContentSetup` message is taken from the Live API connection. If field_mask is empty, and `bidi_generate_content_setup` _is_ present, then the effective `BidiGenerateContentSetup` message is taken entirely from `bidi_generate_content_setup` in this request. The setup message from the Live API connection is ignored. If field_mask is not empty, then the corresponding fields from `bidi_generate_content_setup` will overwrite the fields from the setup message in the Live API connection.
        /// </param>
        /// <param name="bidiGenerateContentSetup">
        /// Message to be sent in the first (and only in the first) `BidiGenerateContentClientMessage`. Contains configuration that will apply for the duration of the streaming RPC. Clients should wait for a `BidiGenerateContentSetupComplete` message before sending any additional messages.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.AuthToken> AuthTokensCreateAsync(
            string? expireTime = default,
            string? newSessionExpireTime = default,
            int? uses = default,
            string? fieldMask = default,
            global::Google.Gemini.BidiGenerateContentSetup? bidiGenerateContentSetup = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}