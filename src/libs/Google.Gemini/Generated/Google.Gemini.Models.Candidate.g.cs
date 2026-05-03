
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A response candidate generated from the model.
    /// </summary>
    public sealed partial class Candidate
    {
        /// <summary>
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Google.Gemini.Content? Content { get; set; }

        /// <summary>
        /// Optional. Output only. The reason why the model stopped generating tokens. If empty, the model has not stopped generating tokens.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.CandidateFinishReasonJsonConverter))]
        public global::Google.Gemini.CandidateFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Output only. Average log probability score of the candidate.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgLogprobs")]
        public double? AvgLogprobs { get; set; }

        /// <summary>
        /// Metadata related to url context retrieval tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urlContextMetadata")]
        public global::Google.Gemini.UrlContextMetadata? UrlContextMetadata { get; set; }

        /// <summary>
        /// Metadata returned to client when grounding is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groundingMetadata")]
        public global::Google.Gemini.GroundingMetadata? GroundingMetadata { get; set; }

        /// <summary>
        /// Logprobs Result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobsResult")]
        public global::Google.Gemini.LogprobsResult? LogprobsResult { get; set; }

        /// <summary>
        /// List of ratings for the safety of a response candidate. There is at most one rating per category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safetyRatings")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetyRating>? SafetyRatings { get; set; }

        /// <summary>
        /// Optional. Output only. Details the reason why the model stopped generating tokens. This is populated only when `finish_reason` is set.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishMessage")]
        public string? FinishMessage { get; set; }

        /// <summary>
        /// Output only. Attribution information for sources that contributed to a grounded answer. This field is populated for `GenerateAnswer` calls.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groundingAttributions")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingAttribution>? GroundingAttributions { get; set; }

        /// <summary>
        /// Output only. Token count for this candidate.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenCount")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// Output only. Index of the candidate in the list of response candidates.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// A collection of source attributions for a piece of content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citationMetadata")]
        public global::Google.Gemini.CitationMetadata? CitationMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Candidate" /> class.
        /// </summary>
        /// <param name="content">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
        /// <param name="finishReason">
        /// Optional. Output only. The reason why the model stopped generating tokens. If empty, the model has not stopped generating tokens.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="avgLogprobs">
        /// Output only. Average log probability score of the candidate.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="urlContextMetadata">
        /// Metadata related to url context retrieval tool.
        /// </param>
        /// <param name="groundingMetadata">
        /// Metadata returned to client when grounding is enabled.
        /// </param>
        /// <param name="logprobsResult">
        /// Logprobs Result
        /// </param>
        /// <param name="safetyRatings">
        /// List of ratings for the safety of a response candidate. There is at most one rating per category.
        /// </param>
        /// <param name="finishMessage">
        /// Optional. Output only. Details the reason why the model stopped generating tokens. This is populated only when `finish_reason` is set.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="groundingAttributions">
        /// Output only. Attribution information for sources that contributed to a grounded answer. This field is populated for `GenerateAnswer` calls.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tokenCount">
        /// Output only. Token count for this candidate.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="index">
        /// Output only. Index of the candidate in the list of response candidates.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="citationMetadata">
        /// A collection of source attributions for a piece of content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Candidate(
            global::Google.Gemini.Content? content,
            global::Google.Gemini.CandidateFinishReason? finishReason,
            double? avgLogprobs,
            global::Google.Gemini.UrlContextMetadata? urlContextMetadata,
            global::Google.Gemini.GroundingMetadata? groundingMetadata,
            global::Google.Gemini.LogprobsResult? logprobsResult,
            global::System.Collections.Generic.IList<global::Google.Gemini.SafetyRating>? safetyRatings,
            string? finishMessage,
            global::System.Collections.Generic.IList<global::Google.Gemini.GroundingAttribution>? groundingAttributions,
            int? tokenCount,
            int? index,
            global::Google.Gemini.CitationMetadata? citationMetadata)
        {
            this.Content = content;
            this.FinishReason = finishReason;
            this.AvgLogprobs = avgLogprobs;
            this.UrlContextMetadata = urlContextMetadata;
            this.GroundingMetadata = groundingMetadata;
            this.LogprobsResult = logprobsResult;
            this.SafetyRatings = safetyRatings;
            this.FinishMessage = finishMessage;
            this.GroundingAttributions = groundingAttributions;
            this.TokenCount = tokenCount;
            this.Index = index;
            this.CitationMetadata = citationMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Candidate" /> class.
        /// </summary>
        public Candidate()
        {
        }
    }
}