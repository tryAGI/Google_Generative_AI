
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Provides hints to the model about possible languages present in the audio.
    /// </summary>
    public sealed partial class LanguageHints
    {
        /// <summary>
        /// Required. BCP-47 language codes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageCodes")]
        public global::System.Collections.Generic.IList<string>? LanguageCodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageHints" /> class.
        /// </summary>
        /// <param name="languageCodes">
        /// Required. BCP-47 language codes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguageHints(
            global::System.Collections.Generic.IList<string>? languageCodes)
        {
            this.LanguageCodes = languageCodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageHints" /> class.
        /// </summary>
        public LanguageHints()
        {
        }

    }
}