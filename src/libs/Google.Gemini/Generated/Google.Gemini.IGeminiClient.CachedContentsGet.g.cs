#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Reads CachedContent resource.
        /// </summary>
        /// <param name="cachedContentsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.CachedContent> CachedContentsGetAsync(
            string cachedContentsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}