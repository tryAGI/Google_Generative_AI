
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Configures the realtime input behavior in `BidiGenerateContent`.
    /// </summary>
    public sealed partial class RealtimeInputConfig
    {
        /// <summary>
        /// Configures automatic detection of activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automaticActivityDetection")]
        public global::Google.Gemini.AutomaticActivityDetection? AutomaticActivityDetection { get; set; }

        /// <summary>
        /// Optional. Defines which input is included in the user's turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turnCoverage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.RealtimeInputConfigTurnCoverageJsonConverter))]
        public global::Google.Gemini.RealtimeInputConfigTurnCoverage? TurnCoverage { get; set; }

        /// <summary>
        /// Optional. Defines what effect activity has.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activityHandling")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.RealtimeInputConfigActivityHandlingJsonConverter))]
        public global::Google.Gemini.RealtimeInputConfigActivityHandling? ActivityHandling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputConfig" /> class.
        /// </summary>
        /// <param name="automaticActivityDetection">
        /// Configures automatic detection of activity.
        /// </param>
        /// <param name="turnCoverage">
        /// Optional. Defines which input is included in the user's turn.
        /// </param>
        /// <param name="activityHandling">
        /// Optional. Defines what effect activity has.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeInputConfig(
            global::Google.Gemini.AutomaticActivityDetection? automaticActivityDetection,
            global::Google.Gemini.RealtimeInputConfigTurnCoverage? turnCoverage,
            global::Google.Gemini.RealtimeInputConfigActivityHandling? activityHandling)
        {
            this.AutomaticActivityDetection = automaticActivityDetection;
            this.TurnCoverage = turnCoverage;
            this.ActivityHandling = activityHandling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeInputConfig" /> class.
        /// </summary>
        public RealtimeInputConfig()
        {
        }

    }
}