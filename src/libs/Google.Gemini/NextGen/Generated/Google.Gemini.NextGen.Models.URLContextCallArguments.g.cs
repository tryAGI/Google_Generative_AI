
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The arguments to pass to the URL context.
    /// </summary>
    public sealed partial class URLContextCallArguments
    {
        /// <summary>
        /// The URLs to fetch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<string>? Urls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="URLContextCallArguments" /> class.
        /// </summary>
        /// <param name="urls">
        /// The URLs to fetch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public URLContextCallArguments(
            global::System.Collections.Generic.IList<string>? urls)
        {
            this.Urls = urls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="URLContextCallArguments" /> class.
        /// </summary>
        public URLContextCallArguments()
        {
        }

    }
}