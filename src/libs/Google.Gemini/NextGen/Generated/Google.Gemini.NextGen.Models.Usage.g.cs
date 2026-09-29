
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Statistics on the interaction request's token usage.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class Usage
    {
        /// <summary>
        /// A breakdown of cached token usage by modality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens_by_modality")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>? CachedTokensByModality { get; set; }

        /// <summary>
        /// Grounding tool count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grounding_tool_count")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GroundingToolCount>? GroundingToolCount { get; set; }

        /// <summary>
        /// A breakdown of input token usage by modality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_by_modality")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>? InputTokensByModality { get; set; }

        /// <summary>
        /// A breakdown of output token usage by modality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_by_modality")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>? OutputTokensByModality { get; set; }

        /// <summary>
        /// A breakdown of tool-use token usage by modality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_tokens_by_modality")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>? ToolUseTokensByModality { get; set; }

        /// <summary>
        /// Number of tokens in the cached part of the prompt (the cached content).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cached_tokens")]
        public int? TotalCachedTokens { get; set; }

        /// <summary>
        /// Number of tokens in the prompt (context).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_tokens")]
        public int? TotalInputTokens { get; set; }

        /// <summary>
        /// Total number of tokens across all the generated responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_output_tokens")]
        public int? TotalOutputTokens { get; set; }

        /// <summary>
        /// Number of tokens of thoughts for thinking models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_thought_tokens")]
        public int? TotalThoughtTokens { get; set; }

        /// <summary>
        /// Total token count for the interaction request (prompt + responses + other<br/>
        /// internal tokens).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Number of tokens present in tool-use prompt(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tool_use_tokens")]
        public int? TotalToolUseTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="cachedTokensByModality">
        /// A breakdown of cached token usage by modality.
        /// </param>
        /// <param name="groundingToolCount">
        /// Grounding tool count.
        /// </param>
        /// <param name="inputTokensByModality">
        /// A breakdown of input token usage by modality.
        /// </param>
        /// <param name="outputTokensByModality">
        /// A breakdown of output token usage by modality.
        /// </param>
        /// <param name="toolUseTokensByModality">
        /// A breakdown of tool-use token usage by modality.
        /// </param>
        /// <param name="totalCachedTokens">
        /// Number of tokens in the cached part of the prompt (the cached content).
        /// </param>
        /// <param name="totalInputTokens">
        /// Number of tokens in the prompt (context).
        /// </param>
        /// <param name="totalOutputTokens">
        /// Total number of tokens across all the generated responses.
        /// </param>
        /// <param name="totalThoughtTokens">
        /// Number of tokens of thoughts for thinking models.
        /// </param>
        /// <param name="totalTokens">
        /// Total token count for the interaction request (prompt + responses + other<br/>
        /// internal tokens).
        /// </param>
        /// <param name="totalToolUseTokens">
        /// Number of tokens present in tool-use prompt(s).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Usage(
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>? cachedTokensByModality,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GroundingToolCount>? groundingToolCount,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>? inputTokensByModality,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>? outputTokensByModality,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>? toolUseTokensByModality,
            int? totalCachedTokens,
            int? totalInputTokens,
            int? totalOutputTokens,
            int? totalThoughtTokens,
            int? totalTokens,
            int? totalToolUseTokens)
        {
            this.CachedTokensByModality = cachedTokensByModality;
            this.GroundingToolCount = groundingToolCount;
            this.InputTokensByModality = inputTokensByModality;
            this.OutputTokensByModality = outputTokensByModality;
            this.ToolUseTokensByModality = toolUseTokensByModality;
            this.TotalCachedTokens = totalCachedTokens;
            this.TotalInputTokens = totalInputTokens;
            this.TotalOutputTokens = totalOutputTokens;
            this.TotalThoughtTokens = totalThoughtTokens;
            this.TotalTokens = totalTokens;
            this.TotalToolUseTokens = totalToolUseTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }

    }
}