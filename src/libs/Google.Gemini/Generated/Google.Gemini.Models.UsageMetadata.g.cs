
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Metadata on the generation request's token usage.
    /// </summary>
    public sealed partial class UsageMetadata
    {
        /// <summary>
        /// Output only. Number of tokens of thoughts for thinking models.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thoughtsTokenCount")]
        public int? ThoughtsTokenCount { get; set; }

        /// <summary>
        /// Output only. Number of tokens present in tool-use prompt(s).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolUsePromptTokenCount")]
        public int? ToolUsePromptTokenCount { get; set; }

        /// <summary>
        /// Output only. List of modalities of the cached content in the request input.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheTokensDetails")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? CacheTokensDetails { get; set; }

        /// <summary>
        /// Total number of tokens across all the generated response candidates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidatesTokenCount")]
        public int? CandidatesTokenCount { get; set; }

        /// <summary>
        /// Output only. List of modalities that were processed for tool-use request inputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolUsePromptTokensDetails")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? ToolUsePromptTokensDetails { get; set; }

        /// <summary>
        /// Number of tokens in the cached part of the prompt (the cached content)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedContentTokenCount")]
        public int? CachedContentTokenCount { get; set; }

        /// <summary>
        /// Total token count for the generation request (prompt + response candidates).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokenCount")]
        public int? TotalTokenCount { get; set; }

        /// <summary>
        /// Number of tokens in the prompt. When `cached_content` is set, this is still the total effective prompt size meaning this includes the number of tokens in the cached content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTokenCount")]
        public int? PromptTokenCount { get; set; }

        /// <summary>
        /// Output only. List of modalities that were processed in the request input.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTokensDetails")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? PromptTokensDetails { get; set; }

        /// <summary>
        /// Output only. List of modalities that were returned in the response.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidatesTokensDetails")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? CandidatesTokensDetails { get; set; }

        /// <summary>
        /// Output only. Number of tokens in the response. Used by Gemini 3.1+ Live API models instead of candidatesTokenCount.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseTokenCount")]
        public int? ResponseTokenCount { get; set; }

        /// <summary>
        /// Output only. List of modalities returned in the response with per-modality token counts. Used by Gemini 3.1+ Live API models instead of candidatesTokensDetails.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseTokensDetails")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? ResponseTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetadata" /> class.
        /// </summary>
        /// <param name="thoughtsTokenCount">
        /// Output only. Number of tokens of thoughts for thinking models.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="toolUsePromptTokenCount">
        /// Output only. Number of tokens present in tool-use prompt(s).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="cacheTokensDetails">
        /// Output only. List of modalities of the cached content in the request input.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="candidatesTokenCount">
        /// Total number of tokens across all the generated response candidates.
        /// </param>
        /// <param name="toolUsePromptTokensDetails">
        /// Output only. List of modalities that were processed for tool-use request inputs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="cachedContentTokenCount">
        /// Number of tokens in the cached part of the prompt (the cached content)
        /// </param>
        /// <param name="totalTokenCount">
        /// Total token count for the generation request (prompt + response candidates).
        /// </param>
        /// <param name="promptTokenCount">
        /// Number of tokens in the prompt. When `cached_content` is set, this is still the total effective prompt size meaning this includes the number of tokens in the cached content.
        /// </param>
        /// <param name="promptTokensDetails">
        /// Output only. List of modalities that were processed in the request input.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="candidatesTokensDetails">
        /// Output only. List of modalities that were returned in the response.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="responseTokenCount">
        /// Output only. Number of tokens in the response. Used by Gemini 3.1+ Live API models instead of candidatesTokenCount.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="responseTokensDetails">
        /// Output only. List of modalities returned in the response with per-modality token counts. Used by Gemini 3.1+ Live API models instead of candidatesTokensDetails.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageMetadata(
            int? thoughtsTokenCount,
            int? toolUsePromptTokenCount,
            global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? cacheTokensDetails,
            int? candidatesTokenCount,
            global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? toolUsePromptTokensDetails,
            int? cachedContentTokenCount,
            int? totalTokenCount,
            int? promptTokenCount,
            global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? promptTokensDetails,
            global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? candidatesTokensDetails,
            int? responseTokenCount,
            global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>? responseTokensDetails)
        {
            this.ThoughtsTokenCount = thoughtsTokenCount;
            this.ToolUsePromptTokenCount = toolUsePromptTokenCount;
            this.CacheTokensDetails = cacheTokensDetails;
            this.CandidatesTokenCount = candidatesTokenCount;
            this.ToolUsePromptTokensDetails = toolUsePromptTokensDetails;
            this.CachedContentTokenCount = cachedContentTokenCount;
            this.TotalTokenCount = totalTokenCount;
            this.PromptTokenCount = promptTokenCount;
            this.PromptTokensDetails = promptTokensDetails;
            this.CandidatesTokensDetails = candidatesTokensDetails;
            this.ResponseTokenCount = responseTokenCount;
            this.ResponseTokensDetails = responseTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetadata" /> class.
        /// </summary>
        public UsageMetadata()
        {
        }
    }
}