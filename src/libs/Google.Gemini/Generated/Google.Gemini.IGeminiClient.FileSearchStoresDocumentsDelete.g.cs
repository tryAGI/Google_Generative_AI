#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Deletes a `Document`.
        /// </summary>
        /// <param name="documentsId"></param>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="force"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> FileSearchStoresDocumentsDeleteAsync(
            string documentsId,
            string fileSearchStoresId,
            bool? force = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}