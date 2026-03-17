
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Request to get a text embedding from the model.
    /// </summary>
    public sealed partial class EmbedTextRequest
    {
        /// <summary>
        /// Required. The model name to use with the format model=models/{model}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Optional. The free-form input text that the model will turn into an embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedTextRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Required. The model name to use with the format model=models/{model}.
        /// </param>
        /// <param name="text">
        /// Optional. The free-form input text that the model will turn into an embedding.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedTextRequest(
            string? model,
            string? text)
        {
            this.Model = model;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedTextRequest" /> class.
        /// </summary>
        public EmbedTextRequest()
        {
        }
    }
}