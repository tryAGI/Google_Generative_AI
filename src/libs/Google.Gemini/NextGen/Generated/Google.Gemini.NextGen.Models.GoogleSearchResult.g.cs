
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The result of the Google Search.
    /// </summary>
    public sealed partial class GoogleSearchResult
    {
        /// <summary>
        /// Web content snippet that can be embedded in a web page or an app webview.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_suggestions")]
        public string? SearchSuggestions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleSearchResult" /> class.
        /// </summary>
        /// <param name="searchSuggestions">
        /// Web content snippet that can be embedded in a web page or an app webview.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleSearchResult(
            string? searchSuggestions)
        {
            this.SearchSuggestions = searchSuggestions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleSearchResult" /> class.
        /// </summary>
        public GoogleSearchResult()
        {
        }

    }
}