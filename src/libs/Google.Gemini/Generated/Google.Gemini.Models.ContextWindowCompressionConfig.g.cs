
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Enables context window compression — a mechanism for managing the model's context window so that it does not exceed a given length.
    /// </summary>
    public sealed partial class ContextWindowCompressionConfig
    {
        /// <summary>
        /// The number of tokens (before running a turn) required to trigger a context window compression. This can be used to balance quality against latency as shorter context windows may result in faster model responses. However, any compression operation will cause a temporary latency increase, so they should not be triggered frequently. If not set, the default is 80% of the model's context window limit. This leaves 20% for the next user request/model response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerTokens")]
        public string? TriggerTokens { get; set; }

        /// <summary>
        /// The SlidingWindow method operates by discarding content at the beginning of the context window. The resulting context will always begin at the start of a USER role turn. System instructions and any `BidiGenerateContentSetup.prefix_turns` will always remain at the beginning of the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slidingWindow")]
        public global::Google.Gemini.SlidingWindow? SlidingWindow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextWindowCompressionConfig" /> class.
        /// </summary>
        /// <param name="triggerTokens">
        /// The number of tokens (before running a turn) required to trigger a context window compression. This can be used to balance quality against latency as shorter context windows may result in faster model responses. However, any compression operation will cause a temporary latency increase, so they should not be triggered frequently. If not set, the default is 80% of the model's context window limit. This leaves 20% for the next user request/model response.
        /// </param>
        /// <param name="slidingWindow">
        /// The SlidingWindow method operates by discarding content at the beginning of the context window. The resulting context will always begin at the start of a USER role turn. System instructions and any `BidiGenerateContentSetup.prefix_turns` will always remain at the beginning of the result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextWindowCompressionConfig(
            string? triggerTokens,
            global::Google.Gemini.SlidingWindow? slidingWindow)
        {
            this.TriggerTokens = triggerTokens;
            this.SlidingWindow = slidingWindow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextWindowCompressionConfig" /> class.
        /// </summary>
        public ContextWindowCompressionConfig()
        {
        }

    }
}