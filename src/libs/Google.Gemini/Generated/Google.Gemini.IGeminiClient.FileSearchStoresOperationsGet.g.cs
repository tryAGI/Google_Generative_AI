#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result at intervals as recommended by the API service.
        /// </summary>
        /// <param name="fileSearchStoresId"></param>
        /// <param name="operationsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Operation> FileSearchStoresOperationsGetAsync(
            string fileSearchStoresId,
            string operationsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}