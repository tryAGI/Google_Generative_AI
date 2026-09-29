#nullable enable

namespace Google.Gemini.NextGen
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Retrieves the full details of a single interaction based on its<br/>
        /// `Interaction.id`.
        /// </summary>
        /// <param name="includeInput"></param>
        /// <param name="interactionsId"></param>
        /// <param name="lastEventId"></param>
        /// <param name="stream"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X GET "https://generativelanguage.googleapis.com/v1beta/interactions/$INTERACTION_ID" \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H "Api-Revision: 2026-05-20"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.Interaction> GetAsync(
            string interactionsId,
            bool? includeInput = default,
            string? lastEventId = default,
            bool? stream = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the full details of a single interaction based on its<br/>
        /// `Interaction.id`.
        /// </summary>
        /// <param name="includeInput"></param>
        /// <param name="interactionsId"></param>
        /// <param name="lastEventId"></param>
        /// <param name="stream"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.NextGen.ApiException"></exception>
        /// <remarks>
        /// curl -X GET "https://generativelanguage.googleapis.com/v1beta/interactions/$INTERACTION_ID" \<br/>
        ///   -H "x-goog-api-key: $GEMINI_API_KEY" \<br/>
        ///   -H "Api-Revision: 2026-05-20"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Google.Gemini.NextGen.AutoSDKHttpResponse<global::Google.Gemini.NextGen.Interaction>> GetAsResponseAsync(
            string interactionsId,
            bool? includeInput = default,
            string? lastEventId = default,
            bool? stream = default,
            global::Google.Gemini.NextGen.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}