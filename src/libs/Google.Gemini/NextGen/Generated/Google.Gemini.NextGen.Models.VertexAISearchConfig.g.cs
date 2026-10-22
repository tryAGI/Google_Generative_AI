
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Used to specify configuration for VertexAISearch.
    /// </summary>
    public sealed partial class VertexAISearchConfig
    {
        /// <summary>
        /// Optional. Used to specify Vertex AI Search engine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        public string? Engine { get; set; }

        /// <summary>
        /// Optional. Used to specify Vertex AI Search datastores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datastores")]
        public global::System.Collections.Generic.IList<string>? Datastores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexAISearchConfig" /> class.
        /// </summary>
        /// <param name="engine">
        /// Optional. Used to specify Vertex AI Search engine.
        /// </param>
        /// <param name="datastores">
        /// Optional. Used to specify Vertex AI Search datastores.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VertexAISearchConfig(
            string? engine,
            global::System.Collections.Generic.IList<string>? datastores)
        {
            this.Engine = engine;
            this.Datastores = datastores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexAISearchConfig" /> class.
        /// </summary>
        public VertexAISearchConfig()
        {
        }

    }
}