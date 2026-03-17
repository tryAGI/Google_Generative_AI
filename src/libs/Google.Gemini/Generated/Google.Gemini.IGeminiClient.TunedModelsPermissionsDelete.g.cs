#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="permissionsId"></param>
        /// <param name="tunedModelsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TunedModelsPermissionsDeleteAsync(
            string permissionsId,
            string tunedModelsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}