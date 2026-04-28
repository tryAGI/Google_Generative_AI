
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Content that has been preprocessed and can be used in subsequent request to GenerativeService. Cached content can be only used with model it was created for.
    /// </summary>
    public sealed partial class CachedContent
    {
        /// <summary>
        /// Required. Immutable. The name of the `Model` to use for cached content Format: `models/{model}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Output only. When the cache entry was last updated in UTC time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// Metadata on the usage of the cached content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageMetadata")]
        public global::Google.Gemini.CachedContentUsageMetadata? UsageMetadata { get; set; }

        /// <summary>
        /// Optional. Immutable. The user-generated meaningful display name of the cached content. Maximum 128 Unicode characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. The content to cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Content>? Contents { get; set; }

        /// <summary>
        /// Output only. Identifier. The resource name referring to the cached content. Format: `cachedContents/{id}`<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Input only. New TTL for this resource, input only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public string? Ttl { get; set; }

        /// <summary>
        /// Optional. Input only. Immutable. A list of `Tools` the model may use to generate the next response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Tool>? Tools { get; set; }

        /// <summary>
        /// The Tool configuration containing parameters for specifying `Tool` use in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolConfig")]
        public global::Google.Gemini.ToolConfig? ToolConfig { get; set; }

        /// <summary>
        /// Output only. Creation time of the cache entry.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemInstruction")]
        public global::Google.Gemini.Content? SystemInstruction { get; set; }

        /// <summary>
        /// Timestamp in UTC of when this resource is considered expired. This is *always* provided on output, regardless of what was sent on input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expireTime")]
        public string? ExpireTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CachedContent" /> class.
        /// </summary>
        /// <param name="model">
        /// Required. Immutable. The name of the `Model` to use for cached content Format: `models/{model}`
        /// </param>
        /// <param name="updateTime">
        /// Output only. When the cache entry was last updated in UTC time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="usageMetadata">
        /// Metadata on the usage of the cached content.
        /// </param>
        /// <param name="displayName">
        /// Optional. Immutable. The user-generated meaningful display name of the cached content. Maximum 128 Unicode characters.
        /// </param>
        /// <param name="contents">
        /// Optional. Input only. Immutable. The content to cache.
        /// </param>
        /// <param name="name">
        /// Output only. Identifier. The resource name referring to the cached content. Format: `cachedContents/{id}`<br/>
        /// Included only in responses
        /// </param>
        /// <param name="ttl">
        /// Input only. New TTL for this resource, input only.
        /// </param>
        /// <param name="tools">
        /// Optional. Input only. Immutable. A list of `Tools` the model may use to generate the next response
        /// </param>
        /// <param name="toolConfig">
        /// The Tool configuration containing parameters for specifying `Tool` use in the request.
        /// </param>
        /// <param name="createTime">
        /// Output only. Creation time of the cache entry.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="systemInstruction">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
        /// <param name="expireTime">
        /// Timestamp in UTC of when this resource is considered expired. This is *always* provided on output, regardless of what was sent on input.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CachedContent(
            string? model,
            string? updateTime,
            global::Google.Gemini.CachedContentUsageMetadata? usageMetadata,
            string? displayName,
            global::System.Collections.Generic.IList<global::Google.Gemini.Content>? contents,
            string? name,
            string? ttl,
            global::System.Collections.Generic.IList<global::Google.Gemini.Tool>? tools,
            global::Google.Gemini.ToolConfig? toolConfig,
            string? createTime,
            global::Google.Gemini.Content? systemInstruction,
            string? expireTime)
        {
            this.Model = model;
            this.UpdateTime = updateTime;
            this.UsageMetadata = usageMetadata;
            this.DisplayName = displayName;
            this.Contents = contents;
            this.Name = name;
            this.Ttl = ttl;
            this.Tools = tools;
            this.ToolConfig = toolConfig;
            this.CreateTime = createTime;
            this.SystemInstruction = systemInstruction;
            this.ExpireTime = expireTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CachedContent" /> class.
        /// </summary>
        public CachedContent()
        {
        }
    }
}