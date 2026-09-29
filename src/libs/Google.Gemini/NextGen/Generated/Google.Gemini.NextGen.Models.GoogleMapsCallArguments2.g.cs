
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The arguments to pass to the Google Maps tool.
    /// </summary>
    public sealed partial class GoogleMapsCallArguments2
    {
        /// <summary>
        /// The queries to be executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        public global::System.Collections.Generic.IList<string>? Queries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMapsCallArguments2" /> class.
        /// </summary>
        /// <param name="queries">
        /// The queries to be executed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleMapsCallArguments2(
            global::System.Collections.Generic.IList<string>? queries)
        {
            this.Queries = queries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMapsCallArguments2" /> class.
        /// </summary>
        public GoogleMapsCallArguments2()
        {
        }

    }
}