
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Google Maps result step.<br/>
    /// Example: {"type":"google_maps_result","call_id":"maps_call_39201","result":[{"places":[{"url":"https://maps.google.com/?cid=12345","name":"Golden Gate Park","place_id":"ChIJIQBpAG2ahYAR9R7bNdTLg8M"}]}]}
    /// </summary>
    public sealed partial class GoogleMapsResultStep
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResult2> Result { get; set; }

        /// <summary>
        /// Required. ID to match the ID from the function call block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// A signature hash for backend validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public byte[]? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMapsResultStep" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="callId">
        /// Required. ID to match the ID from the function call block.
        /// </param>
        /// <param name="type"></param>
        /// <param name="signature">
        /// A signature hash for backend validation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleMapsResultStep(
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResult2> result,
            string callId,
            object type,
            byte[]? signature)
        {
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMapsResultStep" /> class.
        /// </summary>
        public GoogleMapsResultStep()
        {
        }

    }
}