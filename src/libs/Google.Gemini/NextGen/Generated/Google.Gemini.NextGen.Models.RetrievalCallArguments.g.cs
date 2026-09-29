
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The arguments to pass to Retrieval tools.
    /// </summary>
    public sealed partial class RetrievalCallArguments
    {
        /// <summary>
        /// Queries for Retrieval information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        public global::System.Collections.Generic.IList<string>? Queries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalCallArguments" /> class.
        /// </summary>
        /// <param name="queries">
        /// Queries for Retrieval information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrievalCallArguments(
            global::System.Collections.Generic.IList<string>? queries)
        {
            this.Queries = queries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalCallArguments" /> class.
        /// </summary>
        public RetrievalCallArguments()
        {
        }

    }
}