
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// History configuration. This message is included in the session configuration as `BidiGenerateContentSetup.history_config`. Configures the exchange of history messages.
    /// </summary>
    public sealed partial class HistoryConfig
    {
        /// <summary>
        /// Optional. If true, after sending `setup_complete`, the server will wait and at first process `client_content` messages until `turn_complete` is `true`. This initial history will not trigger a model call and may end with role `MODEL`. After `turn_complete` is `true`, the client can start the realtime conversation via `realtime_input`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initialHistoryInClientContent")]
        public bool? InitialHistoryInClientContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryConfig" /> class.
        /// </summary>
        /// <param name="initialHistoryInClientContent">
        /// Optional. If true, after sending `setup_complete`, the server will wait and at first process `client_content` messages until `turn_complete` is `true`. This initial history will not trigger a model call and may end with role `MODEL`. After `turn_complete` is `true`, the client can start the realtime conversation via `realtime_input`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoryConfig(
            bool? initialHistoryInClientContent)
        {
            this.InitialHistoryInClientContent = initialHistoryInClientContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryConfig" /> class.
        /// </summary>
        public HistoryConfig()
        {
        }

    }
}