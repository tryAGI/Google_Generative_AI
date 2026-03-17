#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Enqueues a batch of `GenerateContent` requests for batch processing.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Operation> TunedModelsBatchGenerateContentAsync(
            string tunedModelsId,

            global::Google.Gemini.BatchGenerateContentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Enqueues a batch of `GenerateContent` requests for batch processing.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="batch">
        /// A resource representing a batch of `GenerateContent` requests.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Operation> TunedModelsBatchGenerateContentAsync(
            string tunedModelsId,
            global::Google.Gemini.GenerateContentBatch? batch = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}