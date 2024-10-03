
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Metadata about the state and progress of creating a tuned model returned from the long-running operation.
    /// </summary>
    public sealed partial class CreateTunedModelMetadata
    {
        /// <summary>
        /// The completed percentage for the tuning operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedPercent")]
        public float? CompletedPercent { get; set; }

        /// <summary>
        /// The number of steps completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedSteps")]
        public int? CompletedSteps { get; set; }

        /// <summary>
        /// Metrics collected during tuning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshots")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.TuningSnapshot>? Snapshots { get; set; }

        /// <summary>
        /// The total number of tuning steps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSteps")]
        public int? TotalSteps { get; set; }

        /// <summary>
        /// Name of the tuned model associated with the tuning operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tunedModel")]
        public string? TunedModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}