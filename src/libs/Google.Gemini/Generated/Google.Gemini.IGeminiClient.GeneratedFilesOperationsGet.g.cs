#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result at intervals as recommended by the API service.
        /// </summary>
        /// <param name="operationsId"></param>
        /// <param name="generatedFilesId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Operation> GeneratedFilesOperationsGetAsync(
            string operationsId,
            string generatedFilesId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}