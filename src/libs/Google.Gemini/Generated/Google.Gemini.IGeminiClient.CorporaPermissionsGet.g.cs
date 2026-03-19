#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Gets information about a specific Permission.
        /// </summary>
        /// <param name="corporaId"></param>
        /// <param name="permissionsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Permission> CorporaPermissionsGetAsync(
            string corporaId,
            string permissionsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}