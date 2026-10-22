
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The number of grounding tool counts.
    /// </summary>
    public sealed partial class GroundingToolCount
    {
        /// <summary>
        /// The grounding tool type associated with the count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.GroundingToolCountTypeJsonConverter))]
        public global::Google.Gemini.NextGen.GroundingToolCountType? Type { get; set; }

        /// <summary>
        /// The number of grounding tool counts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingToolCount" /> class.
        /// </summary>
        /// <param name="type">
        /// The grounding tool type associated with the count.
        /// </param>
        /// <param name="count">
        /// The number of grounding tool counts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundingToolCount(
            global::Google.Gemini.NextGen.GroundingToolCountType? type,
            int? count)
        {
            this.Type = type;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingToolCount" /> class.
        /// </summary>
        public GroundingToolCount()
        {
        }

    }
}