
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The result of the Google Maps.
    /// </summary>
    public sealed partial class GoogleMapsResult
    {
        /// <summary>
        /// The places that were found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("places")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Places>? Places { get; set; }

        /// <summary>
        /// Resource name of the Google Maps widget context token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget_context_token")]
        public string? WidgetContextToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMapsResult" /> class.
        /// </summary>
        /// <param name="places">
        /// The places that were found.
        /// </param>
        /// <param name="widgetContextToken">
        /// Resource name of the Google Maps widget context token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleMapsResult(
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Places>? places,
            string? widgetContextToken)
        {
            this.Places = places;
            this.WidgetContextToken = widgetContextToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMapsResult" /> class.
        /// </summary>
        public GoogleMapsResult()
        {
        }

    }
}