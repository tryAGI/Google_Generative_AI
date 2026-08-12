
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A source to be mounted into the environment.
    /// </summary>
    public sealed partial class Source
    {
        /// <summary>
        /// The source of the environment. For GCS, this is the GCS path. For GitHub, this is the GitHub path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source1 { get; set; }

        /// <summary>
        /// The inline content if `type` is `INLINE`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.SourceTypeJsonConverter))]
        public global::Google.Gemini.SourceType? Type { get; set; }

        /// <summary>
        /// Where the source should appear in the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public string? Target { get; set; }

        /// <summary>
        /// Optional encoding for inline content (e.g. `base64`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        public string? Encoding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        /// <param name="source1">
        /// The source of the environment. For GCS, this is the GCS path. For GitHub, this is the GitHub path.
        /// </param>
        /// <param name="content">
        /// The inline content if `type` is `INLINE`.
        /// </param>
        /// <param name="type"></param>
        /// <param name="target">
        /// Where the source should appear in the environment.
        /// </param>
        /// <param name="encoding">
        /// Optional encoding for inline content (e.g. `base64`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Source(
            string? source1,
            string? content,
            global::Google.Gemini.SourceType? type,
            string? target,
            string? encoding)
        {
            this.Source1 = source1;
            this.Content = content;
            this.Type = type;
            this.Target = target;
            this.Encoding = encoding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        public Source()
        {
        }

    }
}