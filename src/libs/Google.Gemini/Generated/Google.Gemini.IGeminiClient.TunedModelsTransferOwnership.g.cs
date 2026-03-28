#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Transfers ownership of the tuned model. This is the only way to change ownership of the tuned model. The current owner will be downgraded to writer role.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.TransferOwnershipResponse> TunedModelsTransferOwnershipAsync(
            string tunedModelsId,

            global::Google.Gemini.TransferOwnershipRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfers ownership of the tuned model. This is the only way to change ownership of the tuned model. The current owner will be downgraded to writer role.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="emailAddress">
        /// Required. The email address of the user to whom the tuned model is being transferred to.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.TransferOwnershipResponse> TunedModelsTransferOwnershipAsync(
            string tunedModelsId,
            string? emailAddress = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}