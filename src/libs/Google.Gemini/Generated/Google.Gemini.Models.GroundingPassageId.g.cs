
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Identifier for a part within a `GroundingPassage`.
    /// </summary>
    public sealed partial class GroundingPassageId
    {
        /// <summary>
        /// Output only. Index of the part within the `GenerateAnswerRequest`'s `GroundingPassage.content`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partIndex")]
        public int? PartIndex { get; set; }

        /// <summary>
        /// Output only. ID of the passage matching the `GenerateAnswerRequest`'s `GroundingPassage.id`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passageId")]
        public string? PassageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingPassageId" /> class.
        /// </summary>
        /// <param name="partIndex">
        /// Output only. Index of the part within the `GenerateAnswerRequest`'s `GroundingPassage.content`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="passageId">
        /// Output only. ID of the passage matching the `GenerateAnswerRequest`'s `GroundingPassage.id`.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundingPassageId(
            int? partIndex,
            string? passageId)
        {
            this.PartIndex = partIndex;
            this.PassageId = passageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingPassageId" /> class.
        /// </summary>
        public GroundingPassageId()
        {
        }
    }
}