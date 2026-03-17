#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Creates an empty `Corpus`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Corpus> CorporaCreateAsync(

            global::Google.Gemini.Corpus request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates an empty `Corpus`.
        /// </summary>
        /// <param name="displayName">
        /// Optional. The human-readable display name for the `Corpus`. The display name must be no more than 512 characters in length, including spaces. Example: "Docs on Semantic Retriever"
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Corpus> CorporaCreateAsync(
            string? displayName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}