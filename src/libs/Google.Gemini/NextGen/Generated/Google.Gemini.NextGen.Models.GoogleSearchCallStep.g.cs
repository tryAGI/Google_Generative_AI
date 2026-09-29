
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Google Search call step.
    /// </summary>
    public sealed partial class GoogleSearchCallStep
    {
        /// <summary>
        /// The arguments to pass to Google Search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.GoogleSearchCallArguments2 GoogleSearchCallArguments { get; set; }

        /// <summary>
        /// Required. A unique ID for this specific tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of search grounding enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.GoogleSearchCallStepSearchTypeJsonConverter))]
        public global::Google.Gemini.NextGen.GoogleSearchCallStepSearchType? SearchType { get; set; }

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
        /// Initializes a new instance of the <see cref="GoogleSearchCallStep" /> class.
        /// </summary>
        /// <param name="googleSearchCallArguments">
        /// The arguments to pass to Google Search.
        /// </param>
        /// <param name="id">
        /// Required. A unique ID for this specific tool call.
        /// </param>
        /// <param name="type"></param>
        /// <param name="searchType">
        /// The type of search grounding enabled.
        /// </param>
        /// <param name="signature">
        /// A signature hash for backend validation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleSearchCallStep(
            global::Google.Gemini.NextGen.GoogleSearchCallArguments2 googleSearchCallArguments,
            string id,
            object type,
            global::Google.Gemini.NextGen.GoogleSearchCallStepSearchType? searchType,
            byte[]? signature)
        {
            this.GoogleSearchCallArguments = googleSearchCallArguments ?? throw new global::System.ArgumentNullException(nameof(googleSearchCallArguments));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SearchType = searchType;
            this.Signature = signature;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleSearchCallStep" /> class.
        /// </summary>
        public GoogleSearchCallStep()
        {
        }

    }
}