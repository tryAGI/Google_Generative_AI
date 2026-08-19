
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// An execution environment for an agent.
    /// </summary>
    public sealed partial class Environment
    {
        /// <summary>
        /// Output only. The time at which the environment was last updated in ISO 8601 format (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public string? Updated { get; set; }

        /// <summary>
        /// Output only. The time at which the environment was created in ISO 8601 format (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string? Created { get; set; }

        /// <summary>
        /// Output only. The status of the environment container.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.EnvironmentStatusJsonConverter))]
        public global::Google.Gemini.EnvironmentStatus? Status { get; set; }

        /// <summary>
        /// Output only. The time at which the environment was last accessed in ISO 8601 format (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastAccessed")]
        public string? LastAccessed { get; set; }

        /// <summary>
        /// Sources to be mounted into the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Source>? Sources { get; set; }

        /// <summary>
        /// Output only. The total size of the environment files in bytes, output only.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        public string? SizeBytes { get; set; }

        /// <summary>
        /// Network egress configuration for the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkAllowlist")]
        public global::Google.Gemini.EnvironmentNetworkEgressAllowlist? NetworkAllowlist { get; set; }

        /// <summary>
        /// Required. Output only. The ID of the environment.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Output only. The number of files in the environment, output only.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileCount")]
        public string? FileCount { get; set; }

        /// <summary>
        /// Network egress mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.EnvironmentNetworkModeJsonConverter))]
        public global::Google.Gemini.EnvironmentNetworkMode? NetworkMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment" /> class.
        /// </summary>
        /// <param name="updated">
        /// Output only. The time at which the environment was last updated in ISO 8601 format (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="created">
        /// Output only. The time at which the environment was created in ISO 8601 format (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Output only. The status of the environment container.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastAccessed">
        /// Output only. The time at which the environment was last accessed in ISO 8601 format (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="sources">
        /// Sources to be mounted into the environment.
        /// </param>
        /// <param name="sizeBytes">
        /// Output only. The total size of the environment files in bytes, output only.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="networkAllowlist">
        /// Network egress configuration for the environment.
        /// </param>
        /// <param name="id">
        /// Required. Output only. The ID of the environment.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="fileCount">
        /// Output only. The number of files in the environment, output only.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="networkMode">
        /// Network egress mode.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Environment(
            string? updated,
            string? created,
            global::Google.Gemini.EnvironmentStatus? status,
            string? lastAccessed,
            global::System.Collections.Generic.IList<global::Google.Gemini.Source>? sources,
            string? sizeBytes,
            global::Google.Gemini.EnvironmentNetworkEgressAllowlist? networkAllowlist,
            string? id,
            string? fileCount,
            global::Google.Gemini.EnvironmentNetworkMode? networkMode)
        {
            this.Updated = updated;
            this.Created = created;
            this.Status = status;
            this.LastAccessed = lastAccessed;
            this.Sources = sources;
            this.SizeBytes = sizeBytes;
            this.NetworkAllowlist = networkAllowlist;
            this.Id = id;
            this.FileCount = fileCount;
            this.NetworkMode = networkMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment" /> class.
        /// </summary>
        public Environment()
        {
        }

    }
}