
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Represents token counting info for a single modality.
    /// </summary>
    public sealed partial class ModalityTokenCount
    {
        /// <summary>
        /// Number of tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenCount")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// The modality associated with this token count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.ModalityTokenCountModalityJsonConverter))]
        public global::Google.Gemini.ModalityTokenCountModality? Modality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModalityTokenCount" /> class.
        /// </summary>
        /// <param name="tokenCount">
        /// Number of tokens.
        /// </param>
        /// <param name="modality">
        /// The modality associated with this token count.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModalityTokenCount(
            int? tokenCount,
            global::Google.Gemini.ModalityTokenCountModality? modality)
        {
            this.TokenCount = tokenCount;
            this.Modality = modality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModalityTokenCount" /> class.
        /// </summary>
        public ModalityTokenCount()
        {
        }
    }
}