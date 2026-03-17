
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Response message for [PredictionService.Predict].
    /// </summary>
    public sealed partial class PredictResponse
    {
        /// <summary>
        /// The outputs of the prediction call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        public global::System.Collections.Generic.IList<object>? Predictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictResponse" /> class.
        /// </summary>
        /// <param name="predictions">
        /// The outputs of the prediction call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredictResponse(
            global::System.Collections.Generic.IList<object>? predictions)
        {
            this.Predictions = predictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictResponse" /> class.
        /// </summary>
        public PredictResponse()
        {
        }
    }
}