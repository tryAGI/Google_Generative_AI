#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Creates an empty `FileSearchStore`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.FileSearchStore> FileSearchStoresCreateAsync(

            global::Google.Gemini.FileSearchStore request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates an empty `FileSearchStore`.
        /// </summary>
        /// <param name="displayName">
        /// Optional. The human-readable display name for the `FileSearchStore`. The display name must be no more than 512 characters in length, including spaces. Example: "Docs on Semantic Retriever"
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.FileSearchStore> FileSearchStoresCreateAsync(
            string? displayName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}