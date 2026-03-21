#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="permissionsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Permission> TunedModelsPermissionsGetAsync(
            string tunedModelsId,
            string permissionsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}