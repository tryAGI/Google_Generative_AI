
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A tool that can be used by the model to search Google.
    /// </summary>
    public sealed partial class GoogleSearch
    {
        /// <summary>
        /// The types of search grounding to enable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_types")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchSearchType>? SearchTypes { get; set; }

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
        /// Initializes a new instance of the <see cref="GoogleSearch" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="searchTypes">
        /// The types of search grounding to enable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleSearch(
            object type,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchSearchType>? searchTypes)
        {
            this.SearchTypes = searchTypes;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleSearch" /> class.
        /// </summary>
        public GoogleSearch()
        {
        }

    }
}