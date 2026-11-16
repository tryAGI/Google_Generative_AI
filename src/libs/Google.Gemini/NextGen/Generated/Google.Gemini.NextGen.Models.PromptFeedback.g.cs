
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Feedback from input content filters.
    /// </summary>
    public sealed partial class PromptFeedback
    {
        /// <summary>
        /// Optional. If set, the input was blocked and no answers are returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.PromptFeedbackBlockReasonJsonConverter))]
        public global::Google.Gemini.NextGen.PromptFeedbackBlockReason? BlockReason { get; set; }

        /// <summary>
        /// Optional. Optional message detailing the reason for blocking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_reason_message")]
        public string? BlockReasonMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptFeedback" /> class.
        /// </summary>
        /// <param name="blockReason">
        /// Optional. If set, the input was blocked and no answers are returned.
        /// </param>
        /// <param name="blockReasonMessage">
        /// Optional. Optional message detailing the reason for blocking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptFeedback(
            global::Google.Gemini.NextGen.PromptFeedbackBlockReason? blockReason,
            string? blockReasonMessage)
        {
            this.BlockReason = blockReason;
            this.BlockReasonMessage = blockReasonMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptFeedback" /> class.
        /// </summary>
        public PromptFeedback()
        {
        }

    }
}