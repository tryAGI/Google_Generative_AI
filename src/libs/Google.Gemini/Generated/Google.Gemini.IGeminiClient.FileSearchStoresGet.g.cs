#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Gets information about a specific `FileSearchStore`.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.FileSearchStore> FileSearchStoresGetAsync(
            string fileSearchStoresId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}