
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Request message for TriggerService.UpdateTrigger.
    /// </summary>
    public sealed partial class UpdateTriggerRequest
    {
        /// <summary>
        /// Required. The ID of the trigger to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Represents the fields of a Trigger that can be updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.TriggerUpdate Trigger { get; set; }

        /// <summary>
        /// Optional. The update mask applies to the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_mask")]
        public string? UpdateMask { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTriggerRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// Required. The ID of the trigger to update.
        /// </param>
        /// <param name="trigger">
        /// Represents the fields of a Trigger that can be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The update mask applies to the resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTriggerRequest(
            string id,
            global::Google.Gemini.NextGen.TriggerUpdate trigger,
            string? updateMask)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Trigger = trigger ?? throw new global::System.ArgumentNullException(nameof(trigger));
            this.UpdateMask = updateMask;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTriggerRequest" /> class.
        /// </summary>
        public UpdateTriggerRequest()
        {
        }

    }
}