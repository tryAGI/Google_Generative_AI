
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The result of the URL context.
    /// </summary>
    public sealed partial class UrlContextResultItem
    {
        /// <summary>
        /// The status of the URL retrieval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.UrlContextResultItemStatusJsonConverter))]
        public global::Google.Gemini.NextGen.UrlContextResultItemStatus? Status { get; set; }

        /// <summary>
        /// The URL that was fetched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlContextResultItem" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the URL retrieval.
        /// </param>
        /// <param name="url">
        /// The URL that was fetched.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UrlContextResultItem(
            global::Google.Gemini.NextGen.UrlContextResultItemStatus? status,
            string? url)
        {
            this.Status = status;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlContextResultItem" /> class.
        /// </summary>
        public UrlContextResultItem()
        {
        }

    }
}