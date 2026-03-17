#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Gets information about a specific `Document`.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="documentsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Document> FileSearchStoresDocumentsGetAsync(
            string fileSearchStoresId,
            string documentsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}