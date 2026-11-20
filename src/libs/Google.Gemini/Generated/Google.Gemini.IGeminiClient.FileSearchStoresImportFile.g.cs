#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Imports a `File` from File Service to a `FileSearchStore`.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Operation> FileSearchStoresImportFileAsync(
            string fileSearchStoresId,

            global::Google.Gemini.ImportFileRequest request,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Imports a `File` from File Service to a `FileSearchStore`.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.AutoSDKHttpResponse<global::Google.Gemini.Operation>> FileSearchStoresImportFileAsResponseAsync(
            string fileSearchStoresId,

            global::Google.Gemini.ImportFileRequest request,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Imports a `File` from File Service to a `FileSearchStore`.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="customMetadata">
        /// Custom metadata to be associated with the file.
        /// </param>
        /// <param name="fileName">
        /// Required. The name of the `File` to import. Example: `files/abc-123`
        /// </param>
        /// <param name="chunkingConfig">
        /// Parameters for telling the service how to chunk the file. inspired by google3/cloud/ai/platform/extension/lib/retrieval/config/chunker_config.proto
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Operation> FileSearchStoresImportFileAsync(
            string fileSearchStoresId,
            global::System.Collections.Generic.IList<global::Google.Gemini.CustomMetadata>? customMetadata = default,
            string? fileName = default,
            global::Google.Gemini.ChunkingConfig? chunkingConfig = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}