namespace Google.Gemini;

/// <summary>
/// Inline audio control tags supported by Gemini Flash TTS models
/// (e.g., <c>gemini-3.1-flash-tts-preview</c>).
///
/// Tags are written inline in the prompt as bracketed directives,
/// for example: <c>"[cheerful] Hello! [whispers] This is a secret."</c>.
///
/// The constants below mirror the "commonly used tags" enumerated in the
/// Gemini speech-generation docs. The model also accepts creative
/// variants beyond this set — there is no exhaustive list.
/// See https://ai.google.dev/gemini-api/docs/speech-generation
/// </summary>
public static class GeminiAudioTags
{
    // --- Emotion ---

    /// <summary>Emotion: surprise / wonder.</summary>
    public const string Amazed = "[amazed]";

    /// <summary>Emotion: sadness / crying.</summary>
    public const string Crying = "[crying]";

    /// <summary>Emotion: excitement / enthusiasm.</summary>
    public const string Excited = "[excited]";

    /// <summary>Emotion: panic / urgency.</summary>
    public const string Panicked = "[panicked]";

    /// <summary>Emotion: mischievous / playful delivery.</summary>
    public const string Mischievously = "[mischievously]";

    // --- Tone / Style ---

    /// <summary>Style: curious / inquisitive tone.</summary>
    public const string Curious = "[curious]";

    /// <summary>Style: sarcastic tone.</summary>
    public const string Sarcastic = "[sarcastic]";

    /// <summary>Style: serious / measured tone.</summary>
    public const string Serious = "[serious]";

    /// <summary>Style: tired / weary tone.</summary>
    public const string Tired = "[tired]";

    /// <summary>Style: cheerful / upbeat tone.</summary>
    public const string Cheerful = "[cheerful]";

    /// <summary>Style: calm / relaxed tone.</summary>
    public const string Calm = "[calm]";

    // --- Delivery / Non-verbal vocalizations ---

    /// <summary>Delivery: short giggling.</summary>
    public const string Giggles = "[giggles]";

    /// <summary>Delivery: audible laughter.</summary>
    public const string Laughs = "[laughs]";

    /// <summary>Delivery: an audible sigh.</summary>
    public const string Sighs = "[sighs]";

    /// <summary>Delivery: trembling / shaky voice.</summary>
    public const string Trembling = "[trembling]";

    /// <summary>Delivery: whispered.</summary>
    public const string Whispers = "[whispers]";

    /// <summary>Delivery: shouted.</summary>
    public const string Shouting = "[shouting]";

    /// <summary>Delivery: sharp inhalation / gasp.</summary>
    public const string Gasp = "[gasp]";

    // --- Sound effects ---

    /// <summary>Sound effect: coughing.</summary>
    public const string Cough = "[cough]";

    // --- Pacing (experimental) ---

    /// <summary>Pacing: very fast (experimental).</summary>
    public const string VeryFast = "[very fast]";

    /// <summary>Pacing: very slow (experimental).</summary>
    public const string VerySlow = "[very slow]";
}

/// <summary>
/// Prebuilt voice names supported by Gemini TTS models. Pass the constant value
/// as <c>voiceName</c> to <see cref="GeminiClientAudioExtensions.SpeakAsync"/>.
/// </summary>
public static class GeminiVoices
{
    /// <summary>Zephyr voice.</summary>
    public const string Zephyr = "Zephyr";

    /// <summary>Puck voice (upbeat).</summary>
    public const string Puck = "Puck";

    /// <summary>Charon voice.</summary>
    public const string Charon = "Charon";

    /// <summary>Kore voice (firm).</summary>
    public const string Kore = "Kore";

    /// <summary>Fenrir voice.</summary>
    public const string Fenrir = "Fenrir";

    /// <summary>Leda voice.</summary>
    public const string Leda = "Leda";

    /// <summary>Orus voice.</summary>
    public const string Orus = "Orus";

    /// <summary>Aoede voice.</summary>
    public const string Aoede = "Aoede";

    /// <summary>Callirrhoe voice.</summary>
    public const string Callirrhoe = "Callirrhoe";

    /// <summary>Autonoe voice.</summary>
    public const string Autonoe = "Autonoe";

    /// <summary>Enceladus voice (breathy).</summary>
    public const string Enceladus = "Enceladus";

    /// <summary>Iapetus voice.</summary>
    public const string Iapetus = "Iapetus";

    /// <summary>Umbriel voice.</summary>
    public const string Umbriel = "Umbriel";

    /// <summary>Algieba voice.</summary>
    public const string Algieba = "Algieba";

    /// <summary>Despina voice.</summary>
    public const string Despina = "Despina";

    /// <summary>Erinome voice.</summary>
    public const string Erinome = "Erinome";

    /// <summary>Algenib voice.</summary>
    public const string Algenib = "Algenib";

    /// <summary>Rasalgethi voice.</summary>
    public const string Rasalgethi = "Rasalgethi";

    /// <summary>Laomedeia voice.</summary>
    public const string Laomedeia = "Laomedeia";

    /// <summary>Achernar voice.</summary>
    public const string Achernar = "Achernar";

    /// <summary>Alnilam voice.</summary>
    public const string Alnilam = "Alnilam";

    /// <summary>Schedar voice.</summary>
    public const string Schedar = "Schedar";

    /// <summary>Gacrux voice.</summary>
    public const string Gacrux = "Gacrux";

    /// <summary>Pulcherrima voice.</summary>
    public const string Pulcherrima = "Pulcherrima";

    /// <summary>Achird voice.</summary>
    public const string Achird = "Achird";

    /// <summary>Zubenelgenubi voice.</summary>
    public const string Zubenelgenubi = "Zubenelgenubi";

    /// <summary>Vindemiatrix voice.</summary>
    public const string Vindemiatrix = "Vindemiatrix";

    /// <summary>Sadachbia voice.</summary>
    public const string Sadachbia = "Sadachbia";

    /// <summary>Sadaltager voice.</summary>
    public const string Sadaltager = "Sadaltager";

    /// <summary>Sulafat voice.</summary>
    public const string Sulafat = "Sulafat";
}
