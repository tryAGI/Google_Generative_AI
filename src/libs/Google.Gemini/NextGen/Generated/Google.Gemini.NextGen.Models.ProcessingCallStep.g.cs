
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A server-initiated processing step for media analysis (e.g. video<br/>
    /// understanding).
    /// </summary>
    public sealed partial class ProcessingCallStep
    {
        /// <summary>
        /// Required. A unique ID for this specific tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A signature hash for backend validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public byte[]? Signature { get; set; }

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
        /// Initializes a new instance of the <see cref="ProcessingCallStep" /> class.
        /// </summary>
        /// <param name="id">
        /// Required. A unique ID for this specific tool call.
        /// </param>
        /// <param name="type"></param>
        /// <param name="signature">
        /// A signature hash for backend validation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessingCallStep(
            string id,
            object type,
            byte[]? signature)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Signature = signature;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingCallStep" /> class.
        /// </summary>
        public ProcessingCallStep()
        {
        }

    }
}