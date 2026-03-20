#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Registers a Google Cloud Storage files with FileService. The user is expected to provide Google Cloud Storage URIs and will receive a File resource for each URI in return. Note that the files are not copied, just registered with File API. If one file fails to register, the whole request fails.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.RegisterFilesResponse> FilesRegisterAsync(

            global::Google.Gemini.RegisterFilesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Registers a Google Cloud Storage files with FileService. The user is expected to provide Google Cloud Storage URIs and will receive a File resource for each URI in return. Note that the files are not copied, just registered with File API. If one file fails to register, the whole request fails.
        /// </summary>
        /// <param name="uris">
        /// Required. The Google Cloud Storage URIs to register. Example: `gs://bucket/object`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.RegisterFilesResponse> FilesRegisterAsync(
            global::System.Collections.Generic.IList<string>? uris = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}