#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Cancels an interaction by id. This only applies to background interactions<br/>
        /// that are still running.
        /// </summary>
        /// <param name="interactionsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X POST "https://generativelanguage.googleapis.com/v1beta/interactions/$INTERACTION_ID/cancel" \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Interaction> CancelAsync(
            string interactionsId,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancels an interaction by id. This only applies to background interactions<br/>
        /// that are still running.
        /// </summary>
        /// <param name="interactionsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X POST "https://generativelanguage.googleapis.com/v1beta/interactions/$INTERACTION_ID/cancel" \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.Interaction>> CancelAsResponseAsync(
            string interactionsId,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}