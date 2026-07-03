
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Session resumption configuration. This message is included in the session configuration as `BidiGenerateContentSetup.session_resumption`. If configured, the server will send `SessionResumptionUpdate` messages.
    /// </summary>
    public sealed partial class SessionResumptionConfig
    {
        /// <summary>
        /// The handle of a previous session. If not present then a new session is created. Session handles come from `SessionResumptionUpdate.token` values in previous connections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionResumptionConfig" /> class.
        /// </summary>
        /// <param name="handle">
        /// The handle of a previous session. If not present then a new session is created. Session handles come from `SessionResumptionUpdate.token` values in previous connections.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionResumptionConfig(
            string? handle)
        {
            this.Handle = handle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionResumptionConfig" /> class.
        /// </summary>
        public SessionResumptionConfig()
        {
        }

    }
}