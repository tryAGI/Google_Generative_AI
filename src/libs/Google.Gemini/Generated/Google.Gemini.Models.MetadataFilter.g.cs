
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// User provided filter to limit retrieval based on `Chunk` or `Document` level metadata values. Example (genre = drama OR genre = action): key = "document.custom_metadata.genre" conditions = [{string_value = "drama", operation = EQUAL}, {string_value = "action", operation = EQUAL}]
    /// </summary>
    public sealed partial class MetadataFilter
    {
        /// <summary>
        /// Required. The key of the metadata to filter on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Required. The `Condition`s for the given key that will trigger this filter. Multiple `Condition`s are joined by logical ORs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Condition>? Conditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFilter" /> class.
        /// </summary>
        /// <param name="key">
        /// Required. The key of the metadata to filter on.
        /// </param>
        /// <param name="conditions">
        /// Required. The `Condition`s for the given key that will trigger this filter. Multiple `Condition`s are joined by logical ORs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataFilter(
            string? key,
            global::System.Collections.Generic.IList<global::Google.Gemini.Condition>? conditions)
        {
            this.Key = key;
            this.Conditions = conditions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFilter" /> class.
        /// </summary>
        public MetadataFilter()
        {
        }
    }
}