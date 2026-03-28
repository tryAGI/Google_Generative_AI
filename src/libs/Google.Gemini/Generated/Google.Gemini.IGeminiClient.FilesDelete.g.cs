#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Deletes the `File`.
        /// </summary>
        /// <param name="filesId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Empty> FilesDeleteAsync(
            string filesId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}