
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Represents the fields of a Trigger that can be updated.
    /// </summary>
    public sealed partial class TriggerUpdate
    {
        /// <summary>
        /// Optional. The status of the trigger.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.TriggerUpdateStatusJsonConverter))]
        public global::Google.Gemini.NextGen.TriggerUpdateStatus? Status { get; set; }

        /// <summary>
        /// Optional. The display name of the trigger.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerUpdate" /> class.
        /// </summary>
        /// <param name="status">
        /// Optional. The status of the trigger.
        /// </param>
        /// <param name="displayName">
        /// Optional. The display name of the trigger.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerUpdate(
            global::Google.Gemini.NextGen.TriggerUpdateStatus? status,
            string? displayName)
        {
            this.Status = status;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerUpdate" /> class.
        /// </summary>
        public TriggerUpdate()
        {
        }

    }
}