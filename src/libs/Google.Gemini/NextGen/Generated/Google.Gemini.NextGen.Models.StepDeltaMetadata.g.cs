
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Optional metadata accompanying ANY streamed event.
    /// </summary>
    public sealed partial class StepDeltaMetadata
    {
        /// <summary>
        /// Statistics on the interaction request's token usage.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_usage")]
        public global::Google.Gemini.NextGen.Usage? TotalUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepDeltaMetadata" /> class.
        /// </summary>
        /// <param name="totalUsage">
        /// Statistics on the interaction request's token usage.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepDeltaMetadata(
            global::Google.Gemini.NextGen.Usage? totalUsage)
        {
            this.TotalUsage = totalUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepDeltaMetadata" /> class.
        /// </summary>
        public StepDeltaMetadata()
        {
        }

    }
}