
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class URLContextCallDelta
    {
        /// <summary>
        /// The arguments to pass to the URL context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.URLContextCallArguments URLContextCallArguments { get; set; }

        /// <summary>
        /// A signature hash for backend validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public byte[]? Signature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="URLContextCallDelta" /> class.
        /// </summary>
        /// <param name="uRLContextCallArguments">
        /// The arguments to pass to the URL context.
        /// </param>
        /// <param name="type"></param>
        /// <param name="signature">
        /// A signature hash for backend validation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public URLContextCallDelta(
            global::Google.Gemini.NextGen.URLContextCallArguments uRLContextCallArguments,
            object type,
            byte[]? signature)
        {
            this.URLContextCallArguments = uRLContextCallArguments ?? throw new global::System.ArgumentNullException(nameof(uRLContextCallArguments));
            this.Signature = signature;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="URLContextCallDelta" /> class.
        /// </summary>
        public URLContextCallDelta()
        {
        }

    }
}