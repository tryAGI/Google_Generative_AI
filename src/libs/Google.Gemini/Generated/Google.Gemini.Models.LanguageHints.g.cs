
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Provides hints to the model about possible languages present in the audio.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class LanguageHints
    {
        /// <summary>
        /// Required. BCP-47 language codes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageCodes")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? LanguageCodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}