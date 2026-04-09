#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Permission> TunedModelsPermissionsCreateAsync(
            string tunedModelsId,

            global::Google.Gemini.Permission request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="role">
        /// Required. The role granted by this permission.
        /// </param>
        /// <param name="emailAddress">
        /// Optional. Immutable. The email address of the user of group which this permission refers. Field is not set when permission's grantee type is EVERYONE.
        /// </param>
        /// <param name="granteeType">
        /// Optional. Immutable. The type of the grantee.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Permission> TunedModelsPermissionsCreateAsync(
            string tunedModelsId,
            global::Google.Gemini.PermissionRole? role = default,
            string? emailAddress = default,
            global::Google.Gemini.PermissionGranteeType? granteeType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}