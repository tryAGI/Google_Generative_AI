#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Enqueues a batch of `EmbedContent` requests for batch processing. We have a `BatchEmbedContents` handler in `GenerativeService`, but it was synchronized. So we name this one to be `Async` to avoid confusion.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Operation> ModelsAsyncBatchEmbedContentAsync(
            string modelsId,

            global::Google.Gemini.AsyncBatchEmbedContentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enqueues a batch of `EmbedContent` requests for batch processing. We have a `BatchEmbedContents` handler in `GenerativeService`, but it was synchronized. So we name this one to be `Async` to avoid confusion.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="batch">
        /// A resource representing a batch of `EmbedContent` requests.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Operation> ModelsAsyncBatchEmbedContentAsync(
            string modelsId,
            global::Google.Gemini.EmbedContentBatch? batch = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}