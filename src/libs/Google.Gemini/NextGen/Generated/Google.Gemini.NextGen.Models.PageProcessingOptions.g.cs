
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Processing options for paginated documents, such as PDFs, Office<br/>
    /// documents, and presentations.
    /// </summary>
    public sealed partial class PageProcessingOptions
    {
        /// <summary>
        /// Optional. 1-indexed start page, inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_page")]
        public int? StartPage { get; set; }

        /// <summary>
        /// Optional. 1-indexed end page, inclusive. Must be &gt;= `start_page` if<br/>
        /// `start_page` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_page")]
        public int? EndPage { get; set; }

        /// <summary>
        /// Optional. Content layers to extract from a paginated document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_layers")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.PageProcessingOptionsContentLayer>? ContentLayers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageProcessingOptions" /> class.
        /// </summary>
        /// <param name="startPage">
        /// Optional. 1-indexed start page, inclusive.
        /// </param>
        /// <param name="endPage">
        /// Optional. 1-indexed end page, inclusive. Must be &gt;= `start_page` if<br/>
        /// `start_page` is set.
        /// </param>
        /// <param name="contentLayers">
        /// Optional. Content layers to extract from a paginated document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PageProcessingOptions(
            int? startPage,
            int? endPage,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.PageProcessingOptionsContentLayer>? contentLayers)
        {
            this.StartPage = startPage;
            this.EndPage = endPage;
            this.ContentLayers = contentLayers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageProcessingOptions" /> class.
        /// </summary>
        public PageProcessingOptions()
        {
        }

    }
}