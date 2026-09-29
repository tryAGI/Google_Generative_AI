
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The token count for a single response modality.
    /// </summary>
    public sealed partial class ModalityTokens
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ResponseModalityJsonConverter))]
        public global::Google.Gemini.NextGen.ResponseModality? Modality { get; set; }

        /// <summary>
        /// Number of tokens for the modality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public int? Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModalityTokens" /> class.
        /// </summary>
        /// <param name="modality"></param>
        /// <param name="tokens">
        /// Number of tokens for the modality.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModalityTokens(
            global::Google.Gemini.NextGen.ResponseModality? modality,
            int? tokens)
        {
            this.Modality = modality;
            this.Tokens = tokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModalityTokens" /> class.
        /// </summary>
        public ModalityTokens()
        {
        }

    }
}