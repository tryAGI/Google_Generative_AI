#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Updates the permission.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="permissionsId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Permission> TunedModelsPermissionsPatchAsync(
            string tunedModelsId,
            string permissionsId,

            global::Google.Gemini.Permission request,
            string? updateMask = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the permission.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="permissionsId"></param>
        /// <param name="updateMask"></param>
        /// <param name="role">
        /// Required. The role granted by this permission.
        /// </param>
        /// <param name="granteeType">
        /// Optional. Immutable. The type of the grantee.
        /// </param>
        /// <param name="emailAddress">
        /// Optional. Immutable. The email address of the user of group which this permission refers. Field is not set when permission's grantee type is EVERYONE.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.Permission> TunedModelsPermissionsPatchAsync(
            string tunedModelsId,
            string permissionsId,
            string? updateMask = default,
            global::Google.Gemini.PermissionRole? role = default,
            global::Google.Gemini.PermissionGranteeType? granteeType = default,
            string? emailAddress = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}