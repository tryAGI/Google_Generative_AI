
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolSearchResultDelta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Function>? Result { get; set; }

        /// <summary>
        /// A signature hash for backend validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public byte[]? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchResultDelta" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="result"></param>
        /// <param name="signature">
        /// A signature hash for backend validation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSearchResultDelta(
            object type,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Function>? result,
            byte[]? signature)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Result = result;
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSearchResultDelta" /> class.
        /// </summary>
        public ToolSearchResultDelta()
        {
        }

    }
}