#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Deletes a tuned model.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TunedModelsDeleteAsync(
            string tunedModelsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}