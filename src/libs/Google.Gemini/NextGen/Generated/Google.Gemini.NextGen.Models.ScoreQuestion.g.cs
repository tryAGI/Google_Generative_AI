
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A quantitative rubric scoring question over discrete numeric levels.
    /// </summary>
    public sealed partial class ScoreQuestion
    {
        /// <summary>
        /// Required. Discrete score levels in the rubric (between 2 and 255 non-empty levels),<br/>
        /// where 0-based index `i` corresponds to numeric level value `i` and rubric<br/>
        /// description `criteria[i]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Criteria { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreQuestion" /> class.
        /// </summary>
        /// <param name="criteria">
        /// Required. Discrete score levels in the rubric (between 2 and 255 non-empty levels),<br/>
        /// where 0-based index `i` corresponds to numeric level value `i` and rubric<br/>
        /// description `criteria[i]`.
        /// </param>
        /// <param name="instructions">
        /// Required. Human-readable decision guidelines, rubrics, or criteria evaluated<br/>
        /// against the shared `input`. At least one content block is required.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreQuestion(
            global::System.Collections.Generic.IList<string> criteria,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInstructionContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInstructionContent>, string> instructions,
            object type)
        {
            this.Criteria = criteria ?? throw new global::System.ArgumentNullException(nameof(criteria));
            this.Instructions = instructions;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreQuestion" /> class.
        /// </summary>
        public ScoreQuestion()
        {
        }

    }
}