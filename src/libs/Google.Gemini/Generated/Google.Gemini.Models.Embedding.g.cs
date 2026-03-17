
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A list of floats representing the embedding.
    /// </summary>
    public sealed partial class Embedding
    {
        /// <summary>
        /// The embedding values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::System.Collections.Generic.IList<float>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Embedding" /> class.
        /// </summary>
        /// <param name="value">
        /// The embedding values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Embedding(
            global::System.Collections.Generic.IList<float>? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Embedding" /> class.
        /// </summary>
        public Embedding()
        {
        }
    }
}