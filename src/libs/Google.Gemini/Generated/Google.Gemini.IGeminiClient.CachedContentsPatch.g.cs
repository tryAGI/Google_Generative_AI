#nullable enable

namespace Google.Gemini
{
    public partial interface IGeminiClient
    {
        /// <summary>
        /// Updates CachedContent resource (only expiration is updatable).
        /// </summary>
        /// <param name="cachedContentsId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Google.Gemini.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.CachedContent> CachedContentsPatchAsync(
            string cachedContentsId,

            global::Google.Gemini.CachedContent request,
            string? updateMask = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates CachedContent resource (only expiration is updatable).
        /// </summary>
        /// <param name="cachedContentsId"></param>
        /// <param name="updateMask"></param>
        /// <param name="expireTime">
        /// Timestamp in UTC of when this resource is considered expired. This is *always* provided on output, regardless of what was sent on input.
        /// </param>
        /// <param name="model">
        /// Required. Immutable. The name of the `Model` to use for cached content Format: `models/{model}`
        /// </param>
        /// <param name="contents">
        /// Optional. Input only. Immutable. The content to cache.
        /// </param>
        /// <param name="tools">
        /// Optional. Input only. Immutable. A list of `Tools` the model may use to generate the next response
        /// </param>
        /// <param name="displayName">
        /// Optional. Immutable. The user-generated meaningful display name of the cached content. Maximum 128 Unicode characters.
        /// </param>
        /// <param name="ttl">
        /// Input only. New TTL for this resource, input only.
        /// </param>
        /// <param name="systemInstruction">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
        /// <param name="usageMetadata">
        /// Metadata on the usage of the cached content.
        /// </param>
        /// <param name="toolConfig">
        /// The Tool configuration containing parameters for specifying `Tool` use in the request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Google.Gemini.CachedContent> CachedContentsPatchAsync(
            string cachedContentsId,
            string? updateMask = default,
            string? expireTime = default,
            string? model = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.Content>? contents = default,
            global::System.Collections.Generic.IList<global::Google.Gemini.Tool>? tools = default,
            string? displayName = default,
            string? ttl = default,
            global::Google.Gemini.Content? systemInstruction = default,
            global::Google.Gemini.CachedContentUsageMetadata? usageMetadata = default,
            global::Google.Gemini.ToolConfig? toolConfig = default,
            global::Google.Gemini.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}