
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// GoogleSearch tool type. Tool to support Google Search in Model. Powered by Google.
    /// </summary>
    public sealed partial class GoogleSearch
    {
        /// <summary>
        /// Different types of search that can be enabled on the GoogleSearch tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchTypes")]
        public global::Google.Gemini.SearchTypes? SearchTypes { get; set; }

        /// <summary>
        /// Represents a time interval, encoded as a Timestamp start (inclusive) and a Timestamp end (exclusive). The start must be less than or equal to the end. When the start equals the end, the interval is empty (matches no time). When both start and end are unspecified, the interval matches any time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeRangeFilter")]
        public global::Google.Gemini.Interval? TimeRangeFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleSearch" /> class.
        /// </summary>
        /// <param name="searchTypes">
        /// Different types of search that can be enabled on the GoogleSearch tool.
        /// </param>
        /// <param name="timeRangeFilter">
        /// Represents a time interval, encoded as a Timestamp start (inclusive) and a Timestamp end (exclusive). The start must be less than or equal to the end. When the start equals the end, the interval is empty (matches no time). When both start and end are unspecified, the interval matches any time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleSearch(
            global::Google.Gemini.SearchTypes? searchTypes,
            global::Google.Gemini.Interval? timeRangeFilter)
        {
            this.SearchTypes = searchTypes;
            this.TimeRangeFilter = timeRangeFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleSearch" /> class.
        /// </summary>
        public GoogleSearch()
        {
        }
    }
}