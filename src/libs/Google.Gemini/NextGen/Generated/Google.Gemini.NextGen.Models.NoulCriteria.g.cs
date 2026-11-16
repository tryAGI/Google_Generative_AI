
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Criteria descriptions for the `true` and `false` outcomes.
    /// </summary>
    public sealed partial class NoulCriteria
    {
        /// <summary>
        /// Optional. Optional criteria or description for the `true` outcome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("true_description")]
        public string? TrueDescription { get; set; }

        /// <summary>
        /// Optional. Optional criteria or description for the `false` outcome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("false_description")]
        public string? FalseDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NoulCriteria" /> class.
        /// </summary>
        /// <param name="trueDescription">
        /// Optional. Optional criteria or description for the `true` outcome.
        /// </param>
        /// <param name="falseDescription">
        /// Optional. Optional criteria or description for the `false` outcome.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NoulCriteria(
            string? trueDescription,
            string? falseDescription)
        {
            this.TrueDescription = trueDescription;
            this.FalseDescription = falseDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoulCriteria" /> class.
        /// </summary>
        public NoulCriteria()
        {
        }

    }
}