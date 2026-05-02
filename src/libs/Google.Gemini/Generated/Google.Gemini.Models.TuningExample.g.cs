
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A single example for tuning.
    /// </summary>
    public sealed partial class TuningExample
    {
        /// <summary>
        /// Required. The expected model output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Optional. Text model input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textInput")]
        public string? TextInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TuningExample" /> class.
        /// </summary>
        /// <param name="output">
        /// Required. The expected model output.
        /// </param>
        /// <param name="textInput">
        /// Optional. Text model input.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TuningExample(
            string? output,
            string? textInput)
        {
            this.Output = output;
            this.TextInput = textInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TuningExample" /> class.
        /// </summary>
        public TuningExample()
        {
        }
    }
}