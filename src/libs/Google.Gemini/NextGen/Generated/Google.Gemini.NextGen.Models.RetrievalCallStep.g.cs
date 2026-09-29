
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Retrieval call step.<br/>
    /// Used by Vertex Retrieval tools such as Parallel AI, Exa AI, Vertex AI Search,<br/>
    /// etc. RetrievalType decides which tool is used.
    /// </summary>
    public sealed partial class RetrievalCallStep
    {
        /// <summary>
        /// The arguments to pass to Retrieval tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.RetrievalCallArguments RetrievalCallArguments { get; set; }

        /// <summary>
        /// Required. A unique ID for this specific tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of retrieval tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.RetrievalCallStepRetrievalTypeJsonConverter))]
        public global::Google.Gemini.NextGen.RetrievalCallStepRetrievalType? RetrievalType { get; set; }

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
        /// Initializes a new instance of the <see cref="RetrievalCallStep" /> class.
        /// </summary>
        /// <param name="retrievalCallArguments">
        /// The arguments to pass to Retrieval tools.
        /// </param>
        /// <param name="id">
        /// Required. A unique ID for this specific tool call.
        /// </param>
        /// <param name="type"></param>
        /// <param name="retrievalType">
        /// The type of retrieval tools.
        /// </param>
        /// <param name="signature">
        /// A signature hash for backend validation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrievalCallStep(
            global::Google.Gemini.NextGen.RetrievalCallArguments retrievalCallArguments,
            string id,
            object type,
            global::Google.Gemini.NextGen.RetrievalCallStepRetrievalType? retrievalType,
            byte[]? signature)
        {
            this.RetrievalCallArguments = retrievalCallArguments ?? throw new global::System.ArgumentNullException(nameof(retrievalCallArguments));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RetrievalType = retrievalType;
            this.Signature = signature;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalCallStep" /> class.
        /// </summary>
        public RetrievalCallStep()
        {
        }

    }
}