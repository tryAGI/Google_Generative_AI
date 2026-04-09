
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// User provided metadata about the GroundingFact.
    /// </summary>
    public sealed partial class GroundingChunkCustomMetadata
    {
        /// <summary>
        /// Optional. The string value of the metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stringValue")]
        public string? StringValue { get; set; }

        /// <summary>
        /// A list of string values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stringListValue")]
        public global::Google.Gemini.GroundingChunkStringList? StringListValue { get; set; }

        /// <summary>
        /// The key of the metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Optional. The numeric value of the metadata. The expected range for this value depends on the specific `key` used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numericValue")]
        public float? NumericValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingChunkCustomMetadata" /> class.
        /// </summary>
        /// <param name="stringValue">
        /// Optional. The string value of the metadata.
        /// </param>
        /// <param name="stringListValue">
        /// A list of string values.
        /// </param>
        /// <param name="key">
        /// The key of the metadata.
        /// </param>
        /// <param name="numericValue">
        /// Optional. The numeric value of the metadata. The expected range for this value depends on the specific `key` used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundingChunkCustomMetadata(
            string? stringValue,
            global::Google.Gemini.GroundingChunkStringList? stringListValue,
            string? key,
            float? numericValue)
        {
            this.StringValue = stringValue;
            this.StringListValue = stringListValue;
            this.Key = key;
            this.NumericValue = numericValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingChunkCustomMetadata" /> class.
        /// </summary>
        public GroundingChunkCustomMetadata()
        {
        }
    }
}