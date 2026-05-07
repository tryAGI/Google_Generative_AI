
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Different types of search that can be enabled on the GoogleSearch tool.
    /// </summary>
    public sealed partial class SearchTypes
    {
        /// <summary>
        /// Image search for grounding and related configurations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageSearch")]
        public global::Google.Gemini.ImageSearch? ImageSearch { get; set; }

        /// <summary>
        /// Standard web search for grounding and related configurations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webSearch")]
        public global::Google.Gemini.WebSearch? WebSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTypes" /> class.
        /// </summary>
        /// <param name="imageSearch">
        /// Image search for grounding and related configurations.
        /// </param>
        /// <param name="webSearch">
        /// Standard web search for grounding and related configurations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchTypes(
            global::Google.Gemini.ImageSearch? imageSearch,
            global::Google.Gemini.WebSearch? webSearch)
        {
            this.ImageSearch = imageSearch;
            this.WebSearch = webSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTypes" /> class.
        /// </summary>
        public SearchTypes()
        {
        }
    }
}