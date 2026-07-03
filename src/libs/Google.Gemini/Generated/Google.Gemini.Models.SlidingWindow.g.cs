
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The SlidingWindow method operates by discarding content at the beginning of the context window. The resulting context will always begin at the start of a USER role turn. System instructions and any `BidiGenerateContentSetup.prefix_turns` will always remain at the beginning of the result.
    /// </summary>
    public sealed partial class SlidingWindow
    {
        /// <summary>
        /// The target number of tokens to keep. The default value is trigger_tokens/2. Discarding parts of the context window causes a temporary latency increase so this value should be calibrated to avoid frequent compression operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetTokens")]
        public string? TargetTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlidingWindow" /> class.
        /// </summary>
        /// <param name="targetTokens">
        /// The target number of tokens to keep. The default value is trigger_tokens/2. Discarding parts of the context window causes a temporary latency increase so this value should be calibrated to avoid frequent compression operations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlidingWindow(
            string? targetTokens)
        {
            this.TargetTokens = targetTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlidingWindow" /> class.
        /// </summary>
        public SlidingWindow()
        {
        }

    }
}