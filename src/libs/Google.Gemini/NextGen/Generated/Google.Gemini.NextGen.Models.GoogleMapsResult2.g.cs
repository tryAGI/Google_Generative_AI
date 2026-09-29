
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The result of the Google Maps.
    /// </summary>
    public sealed partial class GoogleMapsResult2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("places")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResultPlaces>? Places { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("widget_context_token")]
        public string? WidgetContextToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMapsResult2" /> class.
        /// </summary>
        /// <param name="places"></param>
        /// <param name="widgetContextToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleMapsResult2(
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResultPlaces>? places,
            string? widgetContextToken)
        {
            this.Places = places;
            this.WidgetContextToken = widgetContextToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMapsResult2" /> class.
        /// </summary>
        public GoogleMapsResult2()
        {
        }

    }
}