
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Content of a single file in the codebase.
    /// </summary>
    public sealed partial class FileContent
    {
        /// <summary>
        /// The relative path of the file from the project root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The UTF-8 encoded text content of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileContent" /> class.
        /// </summary>
        /// <param name="path">
        /// The relative path of the file from the project root.
        /// </param>
        /// <param name="content">
        /// The UTF-8 encoded text content of the file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileContent(
            string? path,
            string? content)
        {
            this.Path = path;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileContent" /> class.
        /// </summary>
        public FileContent()
        {
        }

    }
}