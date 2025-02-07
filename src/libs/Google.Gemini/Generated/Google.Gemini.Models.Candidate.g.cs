
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A response candidate generated from the model.
    /// </summary>
    public sealed partial class Candidate
    {
        /// <summary>
        /// A collection of source attributions for a piece of content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citationMetadata")]
        public global::Google.Gemini.CitationMetadata? CitationMetadata { get; set; }

        /// <summary>
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Google.Gemini.Content? Content { get; set; }

        /// <summary>
        /// Optional. Output only. The reason why the model stopped generating tokens. If empty, the model has not stopped generating the tokens.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.CandidateFinishReasonJsonConverter))]
        public global::Google.Gemini.CandidateFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Output only. Index of the candidate in the list of candidates.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// List of ratings for the safety of a response candidate. There is at most one rating per category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safetyRatings")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetyRating>? SafetyRatings { get; set; }

        /// <summary>
        /// Output only. Token count for this candidate.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenCount")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Candidate" /> class.
        /// </summary>
        /// <param name="citationMetadata">
        /// A collection of source attributions for a piece of content.
        /// </param>
        /// <param name="content">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
        /// <param name="finishReason">
        /// Optional. Output only. The reason why the model stopped generating tokens. If empty, the model has not stopped generating the tokens.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="index">
        /// Output only. Index of the candidate in the list of candidates.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="safetyRatings">
        /// List of ratings for the safety of a response candidate. There is at most one rating per category.
        /// </param>
        /// <param name="tokenCount">
        /// Output only. Token count for this candidate.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Candidate(
            global::Google.Gemini.CitationMetadata? citationMetadata,
            global::Google.Gemini.Content? content,
            global::Google.Gemini.CandidateFinishReason? finishReason,
            int? index,
            global::System.Collections.Generic.IList<global::Google.Gemini.SafetyRating>? safetyRatings,
            int? tokenCount)
        {
            this.CitationMetadata = citationMetadata;
            this.Content = content;
            this.FinishReason = finishReason;
            this.Index = index;
            this.SafetyRatings = safetyRatings;
            this.TokenCount = tokenCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Candidate" /> class.
        /// </summary>
        public Candidate()
        {
        }
    }
}