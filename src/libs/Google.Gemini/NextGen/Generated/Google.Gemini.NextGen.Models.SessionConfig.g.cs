
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The configuration of CodeMender sessions.
    /// </summary>
    public sealed partial class SessionConfig
    {
        /// <summary>
        /// The maximum number of interaction rounds the agent is allowed to perform<br/>
        /// before reaching a timeout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_rounds")]
        public int? MaxRounds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionConfig" /> class.
        /// </summary>
        /// <param name="maxRounds">
        /// The maximum number of interaction rounds the agent is allowed to perform<br/>
        /// before reaching a timeout.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionConfig(
            int? maxRounds)
        {
            this.MaxRounds = maxRounds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionConfig" /> class.
        /// </summary>
        public SessionConfig()
        {
        }

    }
}