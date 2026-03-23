#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Deletes a `FileSearchStore`.
        /// </summary>
        /// <param name="force"></param>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> FileSearchStoresDeleteAsync(
            string fileSearchStoresId,
            bool? force = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}