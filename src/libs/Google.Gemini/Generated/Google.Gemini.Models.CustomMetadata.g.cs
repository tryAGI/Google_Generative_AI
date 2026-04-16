
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// User provided metadata stored as key-value pairs.
    /// </summary>
    public sealed partial class CustomMetadata
    {
        /// <summary>
        /// The string value of the metadata to store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stringValue")]
        public string? StringValue { get; set; }

        /// <summary>
        /// The numeric value of the metadata to store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numericValue")]
        public float? NumericValue { get; set; }

        /// <summary>
        /// User provided string values assigned to a single metadata key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stringListValue")]
        public global::Google.Gemini.StringList? StringListValue { get; set; }

        /// <summary>
        /// Required. The key of the metadata to store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMetadata" /> class.
        /// </summary>
        /// <param name="stringValue">
        /// The string value of the metadata to store.
        /// </param>
        /// <param name="numericValue">
        /// The numeric value of the metadata to store.
        /// </param>
        /// <param name="stringListValue">
        /// User provided string values assigned to a single metadata key.
        /// </param>
        /// <param name="key">
        /// Required. The key of the metadata to store.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomMetadata(
            string? stringValue,
            float? numericValue,
            global::Google.Gemini.StringList? stringListValue,
            string? key)
        {
            this.StringValue = stringValue;
            this.NumericValue = numericValue;
            this.StringListValue = stringListValue;
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMetadata" /> class.
        /// </summary>
        public CustomMetadata()
        {
        }
    }
}