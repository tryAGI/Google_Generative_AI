#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Uploads data to a FileSearchStore, preprocesses and chunks before storing it in a FileSearchStore Document.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.CustomLongRunningOperation> MediaUploadToFileSearchStoreAsync(
            string fileSearchStoresId,

            global::Google.Gemini.UploadToFileSearchStoreRequest request,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Uploads data to a FileSearchStore, preprocesses and chunks before storing it in a FileSearchStore Document.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="displayName">
        /// Optional. Display name of the created document.
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata to be associated with the data.
        /// </param>
        /// <param name="chunkingConfig">
        /// Parameters for telling the service how to chunk the file. inspired by google3/cloud/ai/platform/extension/lib/retrieval/config/chunker_config.proto
        /// </param>
        /// <param name="mimeType">
        /// Optional. MIME type of the data. If not provided, it will be inferred from the uploaded content.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.CustomLongRunningOperation> MediaUploadToFileSearchStoreAsync(
            string fileSearchStoresId,
            string? displayName = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.CustomMetadata>? customMetadata = default,
            global::Google.Gemini.ChunkingConfig? chunkingConfig = default,
            string? mimeType = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}