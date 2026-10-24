#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Deleting an interaction<br/>
        /// Deletes the interaction by id.
        /// </summary>
        /// <param name="apiVersion"></param>
        /// <param name="id"></param>
        /// <param name="interactionsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X DELETE "https://generativelanguage.googleapis.com/v1beta/interactions/$INTERACTION_ID" \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task DeleteAsync(
            string apiVersion,
            string id,
            string interactionsId,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deleting an interaction<br/>
        /// Deletes the interaction by id.
        /// </summary>
        /// <param name="apiVersion"></param>
        /// <param name="id"></param>
        /// <param name="interactionsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X DELETE "https://generativelanguage.googleapis.com/v1beta/interactions/$INTERACTION_ID" \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse> DeleteAsResponseAsync(
            string apiVersion,
            string id,
            string interactionsId,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}