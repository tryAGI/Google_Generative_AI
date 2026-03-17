
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The response from the model, including candidate completions.
    /// </summary>
    public sealed partial class GenerateTextResponse
    {
        /// <summary>
        /// Candidate responses from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidates")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.TextCompletion>? Candidates { get; set; }

        /// <summary>
        /// A set of content filtering metadata for the prompt and response text. This indicates which `SafetyCategory`(s) blocked a candidate from this response, the lowest `HarmProbability` that triggered a block, and the HarmThreshold setting for that category. This indicates the smallest change to the `SafetySettings` that would be necessary to unblock at least 1 response. The blocking is configured by the `SafetySettings` in the request (or the default `SafetySettings` of the API).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.ContentFilter>? Filters { get; set; }

        /// <summary>
        /// Returns any safety feedback related to content filtering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safetyFeedback")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetyFeedback>? SafetyFeedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextResponse" /> class.
        /// </summary>
        /// <param name="candidates">
        /// Candidate responses from the model.
        /// </param>
        /// <param name="filters">
        /// A set of content filtering metadata for the prompt and response text. This indicates which `SafetyCategory`(s) blocked a candidate from this response, the lowest `HarmProbability` that triggered a block, and the HarmThreshold setting for that category. This indicates the smallest change to the `SafetySettings` that would be necessary to unblock at least 1 response. The blocking is configured by the `SafetySettings` in the request (or the default `SafetySettings` of the API).
        /// </param>
        /// <param name="safetyFeedback">
        /// Returns any safety feedback related to content filtering.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateTextResponse(
            global::System.Collections.Generic.IList<global::Google.Gemini.TextCompletion>? candidates,
            global::System.Collections.Generic.IList<global::Google.Gemini.ContentFilter>? filters,
            global::System.Collections.Generic.IList<global::Google.Gemini.SafetyFeedback>? safetyFeedback)
        {
            this.Candidates = candidates;
            this.Filters = filters;
            this.SafetyFeedback = safetyFeedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextResponse" /> class.
        /// </summary>
        public GenerateTextResponse()
        {
        }
    }
}