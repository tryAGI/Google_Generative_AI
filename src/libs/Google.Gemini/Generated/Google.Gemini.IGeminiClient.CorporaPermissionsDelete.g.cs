#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="corporaId"></param>
        /// <param name="permissionsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CorporaPermissionsDeleteAsync(
            string corporaId,
            string permissionsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}