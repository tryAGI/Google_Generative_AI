
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A binary (true / false) decision question.
    /// </summary>
    public sealed partial class NoulQuestion
    {
        /// <summary>
        /// Required. Human-readable decision guidelines, rubrics, or criteria evaluated<br/>
        /// against the shared `input`. At least one content block is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.DecisionInstructionContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInstructionContent>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInstructionContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInstructionContent>, string> Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Criteria descriptions for the `true` and `false` outcomes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        public global::Google.Gemini.NextGen.NoulCriteria? NoulCriteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NoulQuestion" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Required. Human-readable decision guidelines, rubrics, or criteria evaluated<br/>
        /// against the shared `input`. At least one content block is required.
        /// </param>
        /// <param name="type"></param>
        /// <param name="noulCriteria">
        /// Criteria descriptions for the `true` and `false` outcomes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NoulQuestion(
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInstructionContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInstructionContent>, string> instructions,
            object type,
            global::Google.Gemini.NextGen.NoulCriteria? noulCriteria)
        {
            this.Instructions = instructions;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.NoulCriteria = noulCriteria;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoulQuestion" /> class.
        /// </summary>
        public NoulQuestion()
        {
        }

    }
}