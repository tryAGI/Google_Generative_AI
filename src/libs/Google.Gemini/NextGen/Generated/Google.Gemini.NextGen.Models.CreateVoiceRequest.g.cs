
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Request for creating a voice.
    /// </summary>
    public sealed partial class CreateVoiceRequest
    {
        /// <summary>
        /// A voice resource representing either a custom voice that you create or a<br/>
        /// prebuilt system voice (returned when listing voices).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.Voice Voice { get; set; }

        /// <summary>
        /// Optional. Whether the created voice is persisted and managed by Google.<br/>
        /// * When `true`, Google stores the voice and returns `Voice.id` (for example,<br/>
        ///   `voice_abc123def456`), which you can get, list, and delete, and<br/>
        ///   reference by ID in synthesis requests. Stored voices expire after 1<br/>
        ///   year of inactivity; using a stored voice in speech synthesis or as a<br/>
        ///   `base_voice` when creating another voice extends its<br/>
        ///   `expire_time`. Projects are subject to a maximum active stored voice<br/>
        ///   quota; exceeding the quota returns `RESOURCE_EXHAUSTED`.<br/>
        /// * When `false` (default), the voice is not stored by Google and `Voice.key`<br/>
        ///   (for example, `voicekey_...`) is returned for client-side storage and<br/>
        ///   synthesis. Optional discovery metadata fields on `voice` are not<br/>
        ///   persisted or returned when `store` is `false`.<br/>
        /// * Required to be `true` when `voice.type` is `"prompted"`<br/>
        ///   (otherwise fails with `INVALID_ARGUMENT`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceRequest" /> class.
        /// </summary>
        /// <param name="voice">
        /// A voice resource representing either a custom voice that you create or a<br/>
        /// prebuilt system voice (returned when listing voices).
        /// </param>
        /// <param name="store">
        /// Optional. Whether the created voice is persisted and managed by Google.<br/>
        /// * When `true`, Google stores the voice and returns `Voice.id` (for example,<br/>
        ///   `voice_abc123def456`), which you can get, list, and delete, and<br/>
        ///   reference by ID in synthesis requests. Stored voices expire after 1<br/>
        ///   year of inactivity; using a stored voice in speech synthesis or as a<br/>
        ///   `base_voice` when creating another voice extends its<br/>
        ///   `expire_time`. Projects are subject to a maximum active stored voice<br/>
        ///   quota; exceeding the quota returns `RESOURCE_EXHAUSTED`.<br/>
        /// * When `false` (default), the voice is not stored by Google and `Voice.key`<br/>
        ///   (for example, `voicekey_...`) is returned for client-side storage and<br/>
        ///   synthesis. Optional discovery metadata fields on `voice` are not<br/>
        ///   persisted or returned when `store` is `false`.<br/>
        /// * Required to be `true` when `voice.type` is `"prompted"`<br/>
        ///   (otherwise fails with `INVALID_ARGUMENT`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoiceRequest(
            global::Google.Gemini.NextGen.Voice voice,
            bool? store)
        {
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Store = store;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceRequest" /> class.
        /// </summary>
        public CreateVoiceRequest()
        {
        }

    }
}