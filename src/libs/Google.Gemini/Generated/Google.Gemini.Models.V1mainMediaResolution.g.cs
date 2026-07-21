
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Media resolution for tokenization.
    /// </summary>
    public sealed partial class V1mainMediaResolution
    {
        /// <summary>
        /// The tokenization quality used for given media. for Gemini API support .
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.V1mainMediaResolutionLevelJsonConverter))]
        public global::Google.Gemini.V1mainMediaResolutionLevel? Level { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V1mainMediaResolution" /> class.
        /// </summary>
        /// <param name="level">
        /// The tokenization quality used for given media. for Gemini API support .
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V1mainMediaResolution(
            global::Google.Gemini.V1mainMediaResolutionLevel? level)
        {
            this.Level = level;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1mainMediaResolution" /> class.
        /// </summary>
        public V1mainMediaResolution()
        {
        }

    }
}