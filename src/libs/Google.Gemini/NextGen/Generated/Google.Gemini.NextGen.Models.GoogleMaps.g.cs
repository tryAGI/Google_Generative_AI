
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A tool that can be used by the model to call Google Maps.
    /// </summary>
    public sealed partial class GoogleMaps
    {
        /// <summary>
        /// Whether to return a widget context token in the tool call result of the<br/>
        /// response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_widget")]
        public bool? EnableWidget { get; set; }

        /// <summary>
        /// The latitude of the user's location.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// The longitude of the user's location.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

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
        /// Initializes a new instance of the <see cref="GoogleMaps" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="enableWidget">
        /// Whether to return a widget context token in the tool call result of the<br/>
        /// response.
        /// </param>
        /// <param name="latitude">
        /// The latitude of the user's location.
        /// </param>
        /// <param name="longitude">
        /// The longitude of the user's location.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleMaps(
            object type,
            bool? enableWidget,
            double? latitude,
            double? longitude)
        {
            this.EnableWidget = enableWidget;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMaps" /> class.
        /// </summary>
        public GoogleMaps()
        {
        }

    }
}