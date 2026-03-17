#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method, it returns `UNIMPLEMENTED`.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="returnPartialSuccess"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.ListOperationsResponse> BatchesListAsync(
            string? filter = default,
            int? pageSize = default,
            string? pageToken = default,
            bool? returnPartialSuccess = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}