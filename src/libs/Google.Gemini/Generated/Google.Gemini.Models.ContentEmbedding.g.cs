
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A list of floats representing an embedding.
    /// </summary>
    public sealed partial class ContentEmbedding
    {
        /// <summary>
        /// This field stores the soft tokens tensor frame shape (e.g. [1, 1, 256, 2048]).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shape")]
        public global::System.Collections.Generic.IList<int>? Shape { get; set; }

        /// <summary>
        /// The embedding values. This is for 3P users only and will not be populated for 1P calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<float>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentEmbedding" /> class.
        /// </summary>
        /// <param name="shape">
        /// This field stores the soft tokens tensor frame shape (e.g. [1, 1, 256, 2048]).
        /// </param>
        /// <param name="values">
        /// The embedding values. This is for 3P users only and will not be populated for 1P calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentEmbedding(
            global::System.Collections.Generic.IList<int>? shape,
            global::System.Collections.Generic.IList<float>? values)
        {
            this.Shape = shape;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentEmbedding" /> class.
        /// </summary>
        public ContentEmbedding()
        {
        }
    }
}