
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A thought step.
    /// </summary>
    public sealed partial class ThoughtStep
    {
        /// <summary>
        /// A signature hash for backend validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public byte[]? Signature { get; set; }

        /// <summary>
        /// A summary of the thought.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ThoughtSummaryContent>? Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThoughtStep" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="signature">
        /// A signature hash for backend validation.
        /// </param>
        /// <param name="summary">
        /// A summary of the thought.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThoughtStep(
            object type,
            byte[]? signature,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ThoughtSummaryContent>? summary)
        {
            this.Signature = signature;
            this.Summary = summary;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThoughtStep" /> class.
        /// </summary>
        public ThoughtStep()
        {
        }

    }
}