#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Updates a batch of EmbedContent requests for batch processing.
        /// </summary>
        /// <param name="batchesId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.EmbedContentBatch> BatchesUpdateEmbedContentBatchAsync(
            string batchesId,

            global::Google.Gemini.EmbedContentBatch request,
            string? updateMask = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a batch of EmbedContent requests for batch processing.
        /// </summary>
        /// <param name="batchesId"></param>
        /// <param name="updateMask"></param>
        /// <param name="model">
        /// Required. The name of the `Model` to use for generating the completion. Format: `models/{model}`.
        /// </param>
        /// <param name="priority">
        /// Optional. The priority of the batch. Batches with a higher priority value will be processed before batches with a lower priority value. Negative values are allowed. Default is 0.
        /// </param>
        /// <param name="batchStats">
        /// Stats about the batch.
        /// </param>
        /// <param name="inputConfig">
        /// Configures the input to the batch request.
        /// </param>
        /// <param name="displayName">
        /// Required. The user-defined name of this batch.
        /// </param>
        /// <param name="output">
        /// The output of a batch request. This is returned in the `AsyncBatchEmbedContentResponse` or the `EmbedContentBatch.output` field.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.EmbedContentBatch> BatchesUpdateEmbedContentBatchAsync(
            string batchesId,
            string? updateMask = default,
            string? model = default,
            string? priority = default,
            global::Google.Gemini.EmbedContentBatchStats? batchStats = default,
            global::Google.Gemini.InputEmbedContentConfig? inputConfig = default,
            string? displayName = default,
            global::Google.Gemini.EmbedContentBatchOutput? output = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}