
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// An execution environment for an agent.
    /// </summary>
    public sealed partial class Environment
    {
        /// <summary>
        /// Sources to be mounted into the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Source>? Sources { get; set; }

        /// <summary>
        /// Output only. The compute lifecycle mode for this environment.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.EnvironmentModeJsonConverter))]
        public global::Google.Gemini.EnvironmentMode? Mode { get; set; }

        /// <summary>
        /// Output only. The time at which the environment was last accessed in ISO 8601 format (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastAccessed")]
        public string? LastAccessed { get; set; }

        /// <summary>
        /// Network egress configuration for the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkAllowlist")]
        public global::Google.Gemini.EnvironmentNetworkEgressAllowlist? NetworkAllowlist { get; set; }

        /// <summary>
        /// Output only. The status of the environment container.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.EnvironmentStatusJsonConverter))]
        public global::Google.Gemini.EnvironmentStatus? Status { get; set; }

        /// <summary>
        /// Network egress mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.EnvironmentNetworkModeJsonConverter))]
        public global::Google.Gemini.EnvironmentNetworkMode? NetworkMode { get; set; }

        /// <summary>
        /// Required. Output only. The ID of the environment.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Output only. Secret token generated upon environment creation for self_hosted environments. Used by the self-hosted sandbox daemon to authenticate polling and streaming requests. Only returned in the CreateEnvironment response; omitted from subsequent GetEnvironment and ListEnvironments calls.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentKey")]
        public string? EnvironmentKey { get; set; }

        /// <summary>
        /// Output only. Arbitrary customer-defined JSON configuration passed through to the self-hosted environment poller. Only populated for `self_hosted` environments when configured.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customConfig")]
        public object? CustomConfig { get; set; }

        /// <summary>
        /// Output only. The number of files in the environment, output only.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileCount")]
        public string? FileCount { get; set; }

        /// <summary>
        /// Output only. The time at which the environment was created in ISO 8601 format (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string? Created { get; set; }

        /// <summary>
        /// Output only. The time at which the environment was last updated in ISO 8601 format (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public string? Updated { get; set; }

        /// <summary>
        /// Output only. The total size of the environment files in bytes, output only.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        public string? SizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment" /> class.
        /// </summary>
        /// <param name="sources">
        /// Sources to be mounted into the environment.
        /// </param>
        /// <param name="mode">
        /// Output only. The compute lifecycle mode for this environment.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastAccessed">
        /// Output only. The time at which the environment was last accessed in ISO 8601 format (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="networkAllowlist">
        /// Network egress configuration for the environment.
        /// </param>
        /// <param name="status">
        /// Output only. The status of the environment container.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="networkMode">
        /// Network egress mode.
        /// </param>
        /// <param name="id">
        /// Required. Output only. The ID of the environment.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="environmentKey">
        /// Output only. Secret token generated upon environment creation for self_hosted environments. Used by the self-hosted sandbox daemon to authenticate polling and streaming requests. Only returned in the CreateEnvironment response; omitted from subsequent GetEnvironment and ListEnvironments calls.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="customConfig">
        /// Output only. Arbitrary customer-defined JSON configuration passed through to the self-hosted environment poller. Only populated for `self_hosted` environments when configured.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="fileCount">
        /// Output only. The number of files in the environment, output only.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="created">
        /// Output only. The time at which the environment was created in ISO 8601 format (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updated">
        /// Output only. The time at which the environment was last updated in ISO 8601 format (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="sizeBytes">
        /// Output only. The total size of the environment files in bytes, output only.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Environment(
            global::System.Collections.Generic.IList<global::Google.Gemini.Source>? sources,
            global::Google.Gemini.EnvironmentMode? mode,
            string? lastAccessed,
            global::Google.Gemini.EnvironmentNetworkEgressAllowlist? networkAllowlist,
            global::Google.Gemini.EnvironmentStatus? status,
            global::Google.Gemini.EnvironmentNetworkMode? networkMode,
            string? id,
            string? environmentKey,
            object? customConfig,
            string? fileCount,
            string? created,
            string? updated,
            string? sizeBytes)
        {
            this.Sources = sources;
            this.Mode = mode;
            this.LastAccessed = lastAccessed;
            this.NetworkAllowlist = networkAllowlist;
            this.Status = status;
            this.NetworkMode = networkMode;
            this.Id = id;
            this.EnvironmentKey = environmentKey;
            this.CustomConfig = customConfig;
            this.FileCount = fileCount;
            this.Created = created;
            this.Updated = updated;
            this.SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment" /> class.
        /// </summary>
        public Environment()
        {
        }

    }
}