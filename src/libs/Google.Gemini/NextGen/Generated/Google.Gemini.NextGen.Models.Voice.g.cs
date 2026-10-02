
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// A voice resource representing either a custom voice (created via<br/>
    /// `CreateVoice`) or a prebuilt system voice (returned by `ListVoices`).
    /// </summary>
    public sealed partial class Voice
    {
        /// <summary>
        /// Optional. Regional accent descriptor (e.g. "American", "British").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// Optional. Optimal usage context or domain (e.g. "Conversational",<br/>
        /// "Audiobook", "News").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Optional. Descriptive summary of vocal timbre, personality, and tone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Optional. User-provided display name for a stored voice (`store = true`),<br/>
        /// or the catalog name for a prebuilt voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Output only. The timestamp at which a custom stored voice (`store = true`)<br/>
        /// or replicated voice key (`store = false`) expires. For custom stored voices<br/>
        /// (`store = true`), this expiration time is extended when the voice is used<br/>
        /// for speech synthesis or as a `base_voice` in `CreateVoice`. Unset for<br/>
        /// prebuilt catalog voices (`"prebuilt"`), which do not expire.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        public global::System.DateTime? ExpireTime { get; set; }

        /// <summary>
        /// Optional. Perceived voice gender presentation (e.g. "female", "male",<br/>
        /// "neutral").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// Output only. The unique identifier of the voice.<br/>
        /// * For Google-managed custom voices (`store = true`), this is a generated ID<br/>
        ///   with prefix `voice_` (for example, `voice_abc123def456`). Pass<br/>
        ///   `voices/{id}` as the `name` in `GetVoice` and `DeleteVoice`, and pass<br/>
        ///   `{id}` directly to `SpeechConfig.voice_config.voice` (or<br/>
        ///   `SpeechConfig.voice`) during speech synthesis.<br/>
        /// * For prebuilt catalog voices (`"prebuilt"` returned by `ListVoices`), this<br/>
        ///   is the speaker name (for example, `Puck` or `Charon`).<br/>
        /// * Unset when `CreateVoice` is called with `store = false`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Output only. The client-managed voice replication key (with prefix<br/>
        /// `voicekey_`). Returned only by `CreateVoice` when `type` is `"replicated"`<br/>
        /// and `store` is `false`. Pass this key to `SpeechConfig.voice_config.voice`<br/>
        /// (or `SpeechConfig.voice`) during speech synthesis.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Optional. Primary BCP-47 language tag (e.g. "en-US", "fr-FR").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Optional. The model used to design or replicate the voice.<br/>
        /// If omitted in `CreateVoice`, defaults to the latest supported voice design<br/>
        /// model. Returned in `CreateVoice`, `GetVoice`, and `ListVoices` responses<br/>
        /// for custom voices (`"prompted"` and `"replicated"`); unset for `"prebuilt"`<br/>
        /// voices. Created voices can be synthesized across any supported TTS<br/>
        /// synthesis model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Optional. Intended persona or character archetype (e.g. "Warm, Friendly",<br/>
        /// "Narrator").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persona")]
        public string? Persona { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.PitchJsonConverter))]
        public global::Google.Gemini.NextGen.Pitch? Pitch { get; set; }

        /// <summary>
        /// Parameters for prompted voice generation.<br/>
        /// Required in `CreateVoice` when `type` is `"prompted"`. Returned in<br/>
        /// `CreateVoice`, `GetVoice`, and `ListVoices` responses for prompted voices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompted")]
        public global::Google.Gemini.NextGen.PromptedVoice? Prompted { get; set; }

        /// <summary>
        /// Optional. ISO 3166-1 alpha-2 or UN M.49 geographic region code (e.g. "US",<br/>
        /// "GB", "001").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_code")]
        public string? RegionCode { get; set; }

        /// <summary>
        /// Input only. Parameters for replicated voice generation.<br/>
        /// Required on input when `type` is `"replicated"`. Not returned in<br/>
        /// responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicated")]
        public global::Google.Gemini.NextGen.ReplicatedVoice? Replicated { get; set; }

        /// <summary>
        /// Audio payload used for voice creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_audio")]
        public global::Google.Gemini.NextGen.AudioData? SampleAudio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.VoiceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.VoiceType Type { get; set; }

        /// <summary>
        /// Statistics on the interaction request's token usage.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Google.Gemini.NextGen.Usage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="accent">
        /// Optional. Regional accent descriptor (e.g. "American", "British").
        /// </param>
        /// <param name="context">
        /// Optional. Optimal usage context or domain (e.g. "Conversational",<br/>
        /// "Audiobook", "News").
        /// </param>
        /// <param name="description">
        /// Optional. Descriptive summary of vocal timbre, personality, and tone.
        /// </param>
        /// <param name="displayName">
        /// Optional. User-provided display name for a stored voice (`store = true`),<br/>
        /// or the catalog name for a prebuilt voice.
        /// </param>
        /// <param name="expireTime">
        /// Output only. The timestamp at which a custom stored voice (`store = true`)<br/>
        /// or replicated voice key (`store = false`) expires. For custom stored voices<br/>
        /// (`store = true`), this expiration time is extended when the voice is used<br/>
        /// for speech synthesis or as a `base_voice` in `CreateVoice`. Unset for<br/>
        /// prebuilt catalog voices (`"prebuilt"`), which do not expire.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="gender">
        /// Optional. Perceived voice gender presentation (e.g. "female", "male",<br/>
        /// "neutral").
        /// </param>
        /// <param name="id">
        /// Output only. The unique identifier of the voice.<br/>
        /// * For Google-managed custom voices (`store = true`), this is a generated ID<br/>
        ///   with prefix `voice_` (for example, `voice_abc123def456`). Pass<br/>
        ///   `voices/{id}` as the `name` in `GetVoice` and `DeleteVoice`, and pass<br/>
        ///   `{id}` directly to `SpeechConfig.voice_config.voice` (or<br/>
        ///   `SpeechConfig.voice`) during speech synthesis.<br/>
        /// * For prebuilt catalog voices (`"prebuilt"` returned by `ListVoices`), this<br/>
        ///   is the speaker name (for example, `Puck` or `Charon`).<br/>
        /// * Unset when `CreateVoice` is called with `store = false`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="key">
        /// Output only. The client-managed voice replication key (with prefix<br/>
        /// `voicekey_`). Returned only by `CreateVoice` when `type` is `"replicated"`<br/>
        /// and `store` is `false`. Pass this key to `SpeechConfig.voice_config.voice`<br/>
        /// (or `SpeechConfig.voice`) during speech synthesis.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="languageCode">
        /// Optional. Primary BCP-47 language tag (e.g. "en-US", "fr-FR").
        /// </param>
        /// <param name="model">
        /// Optional. The model used to design or replicate the voice.<br/>
        /// If omitted in `CreateVoice`, defaults to the latest supported voice design<br/>
        /// model. Returned in `CreateVoice`, `GetVoice`, and `ListVoices` responses<br/>
        /// for custom voices (`"prompted"` and `"replicated"`); unset for `"prebuilt"`<br/>
        /// voices. Created voices can be synthesized across any supported TTS<br/>
        /// synthesis model.
        /// </param>
        /// <param name="persona">
        /// Optional. Intended persona or character archetype (e.g. "Warm, Friendly",<br/>
        /// "Narrator").
        /// </param>
        /// <param name="pitch"></param>
        /// <param name="prompted">
        /// Parameters for prompted voice generation.<br/>
        /// Required in `CreateVoice` when `type` is `"prompted"`. Returned in<br/>
        /// `CreateVoice`, `GetVoice`, and `ListVoices` responses for prompted voices.
        /// </param>
        /// <param name="regionCode">
        /// Optional. ISO 3166-1 alpha-2 or UN M.49 geographic region code (e.g. "US",<br/>
        /// "GB", "001").
        /// </param>
        /// <param name="replicated">
        /// Input only. Parameters for replicated voice generation.<br/>
        /// Required on input when `type` is `"replicated"`. Not returned in<br/>
        /// responses.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="sampleAudio">
        /// Audio payload used for voice creation.
        /// </param>
        /// <param name="usage">
        /// Statistics on the interaction request's token usage.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Voice(
            global::Google.Gemini.NextGen.VoiceType type,
            string? accent,
            string? context,
            string? description,
            string? displayName,
            global::System.DateTime? expireTime,
            string? gender,
            string? id,
            string? key,
            string? languageCode,
            string? model,
            string? persona,
            global::Google.Gemini.NextGen.Pitch? pitch,
            global::Google.Gemini.NextGen.PromptedVoice? prompted,
            string? regionCode,
            global::Google.Gemini.NextGen.ReplicatedVoice? replicated,
            global::Google.Gemini.NextGen.AudioData? sampleAudio,
            global::Google.Gemini.NextGen.Usage? usage)
        {
            this.Accent = accent;
            this.Context = context;
            this.Description = description;
            this.DisplayName = displayName;
            this.ExpireTime = expireTime;
            this.Gender = gender;
            this.Id = id;
            this.Key = key;
            this.LanguageCode = languageCode;
            this.Model = model;
            this.Persona = persona;
            this.Pitch = pitch;
            this.Prompted = prompted;
            this.RegionCode = regionCode;
            this.Replicated = replicated;
            this.SampleAudio = sampleAudio;
            this.Type = type;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        public Voice()
        {
        }

    }
}