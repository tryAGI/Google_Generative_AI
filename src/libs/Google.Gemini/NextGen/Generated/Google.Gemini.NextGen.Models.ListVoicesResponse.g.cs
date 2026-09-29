
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Response message for `VoicesService.ListVoices`.
    /// </summary>
    public sealed partial class ListVoicesResponse
    {
        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page.<br/>
        /// If empty, there are no subsequent pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The voices from the specified collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Voice>? Voices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoicesResponse" /> class.
        /// </summary>
        /// <param name="nextPageToken">
        /// A token that can be sent as `page_token` to retrieve the next page.<br/>
        /// If empty, there are no subsequent pages.
        /// </param>
        /// <param name="voices">
        /// The voices from the specified collection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVoicesResponse(
            string? nextPageToken,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Voice>? voices)
        {
            this.NextPageToken = nextPageToken;
            this.Voices = voices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoicesResponse" /> class.
        /// </summary>
        public ListVoicesResponse()
        {
        }

    }
}