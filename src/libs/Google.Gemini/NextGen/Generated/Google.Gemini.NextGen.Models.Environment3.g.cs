
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// An execution environment for an agent.
    /// </summary>
    public sealed partial class Environment3
    {
        /// <summary>
        /// Required. Output only. The ID of the environment.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Sources to be mounted into the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>? Sources { get; set; }

        /// <summary>
        /// Output only. The time at which the environment was created in ISO 8601 format<br/>
        /// (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string? Created { get; set; }

        /// <summary>
        /// Output only. The time at which the environment was last updated in ISO 8601 format<br/>
        /// (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public string? Updated { get; set; }

        /// <summary>
        /// Output only. The time at which the environment was last accessed in ISO 8601 format<br/>
        /// (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_accessed")]
        public string? LastAccessed { get; set; }

        /// <summary>
        /// Output only. The status of the environment container.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.EnvironmentStatusJsonConverter))]
        public global::Google.Gemini.NextGen.EnvironmentStatus? Status { get; set; }

        /// <summary>
        /// Network configuration for the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentNetwork?>))]
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentNetwork?>? Network { get; set; }

        /// <summary>
        /// Output only. The number of files in the environment, output only.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_count")]
        public string? FileCount { get; set; }

        /// <summary>
        /// Output only. The total size of the environment files in bytes, output only.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        public string? SizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment3" /> class.
        /// </summary>
        /// <param name="sources">
        /// Sources to be mounted into the environment.
        /// </param>
        /// <param name="created">
        /// Output only. The time at which the environment was created in ISO 8601 format<br/>
        /// (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updated">
        /// Output only. The time at which the environment was last updated in ISO 8601 format<br/>
        /// (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastAccessed">
        /// Output only. The time at which the environment was last accessed in ISO 8601 format<br/>
        /// (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Output only. The status of the environment container.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="network">
        /// Network configuration for the environment.
        /// </param>
        /// <param name="fileCount">
        /// Output only. The number of files in the environment, output only.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="sizeBytes">
        /// Output only. The total size of the environment files in bytes, output only.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Required. Output only. The ID of the environment.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Environment3(
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>? sources,
            string? created,
            string? updated,
            string? lastAccessed,
            global::Google.Gemini.NextGen.EnvironmentStatus? status,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentNetwork?>? network,
            string? fileCount,
            string? sizeBytes,
            string id = default!)
        {
            this.Id = id;
            this.Sources = sources;
            this.Created = created;
            this.Updated = updated;
            this.LastAccessed = lastAccessed;
            this.Status = status;
            this.Network = network;
            this.FileCount = fileCount;
            this.SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment3" /> class.
        /// </summary>
        public Environment3()
        {
        }

    }
}