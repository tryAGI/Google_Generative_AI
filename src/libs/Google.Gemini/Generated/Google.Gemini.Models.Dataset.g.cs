
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Dataset for training or validation.
    /// </summary>
    public sealed partial class Dataset
    {
        /// <summary>
        /// A set of tuning examples. Can be training or validation data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::Google.Gemini.TuningExamples? Examples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="examples">
        /// A set of tuning examples. Can be training or validation data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Dataset(
            global::Google.Gemini.TuningExamples? examples)
        {
            this.Examples = examples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
        {
        }
    }
}