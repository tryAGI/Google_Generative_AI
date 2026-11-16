
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Evaluates one or more structured decision questions (`noul`, `choice`, or `score`) against a shared `input`.
    /// </summary>
    public sealed partial class CreateDecisionRequest
    {
        /// <summary>
        /// Required. The name of the `Model` used for evaluating the decisions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Required. Shared input prefix evaluated once across all decision questions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.DecisionInputContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInputContent>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInputContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInputContent>, string> Input { get; set; }

        /// <summary>
        /// Required. The decision questions to evaluate, keyed by caller-defined unique question<br/>
        /// identifiers (at least 1 question).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.Question> Questions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDecisionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Required. The name of the `Model` used for evaluating the decisions.
        /// </param>
        /// <param name="input">
        /// Required. Shared input prefix evaluated once across all decision questions.
        /// </param>
        /// <param name="questions">
        /// Required. The decision questions to evaluate, keyed by caller-defined unique question<br/>
        /// identifiers (at least 1 question).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDecisionRequest(
            string model,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInputContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInputContent>, string> input,
            global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.Question> questions)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.Questions = questions ?? throw new global::System.ArgumentNullException(nameof(questions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDecisionRequest" /> class.
        /// </summary>
        public CreateDecisionRequest()
        {
        }

    }
}