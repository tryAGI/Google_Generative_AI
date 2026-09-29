
#nullable enable

namespace Google.Gemini.NextGen
{

    /// <summary>
    /// The model that will complete your prompt.\n\nSee [models](https://ai.google.dev/gemini-api/docs/models) for additional details.
    /// </summary>
    public readonly partial struct Model : global::System.IEquatable<Model>
    {
        /// <summary>
        ///
        /// </summary>
        public Model(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// Our first hybrid reasoning model which supports a 1M token context window and has thinking budgets.
        /// </summary>
        public static Model Gemini25Flash { get; } = new("gemini-2.5-flash");

        /// <summary>
        /// Our native image generation model, optimized for speed, flexibility, and contextual understanding. Text input and output is priced the same as 2.5 Flash.
        /// </summary>
        public static Model Gemini25FlashImage { get; } = new("gemini-2.5-flash-image");

        /// <summary>
        /// Our smallest and most cost effective model, built for at scale usage.
        /// </summary>
        public static Model Gemini25FlashLite { get; } = new("gemini-2.5-flash-lite");

        /// <summary>
        /// Our state-of-the-art multipurpose model, which excels at coding and complex reasoning tasks.
        /// </summary>
        public static Model Gemini25Pro { get; } = new("gemini-2.5-pro");

        /// <summary>
        /// Our most intelligent model built for speed, combining frontier intelligence with superior search and grounding.
        /// </summary>
        public static Model Gemini3FlashPreview { get; } = new("gemini-3-flash-preview");

        /// <summary>
        /// Gemini 3 Pro Image
        /// </summary>
        public static Model Gemini3ProImage { get; } = new("gemini-3-pro-image");

        /// <summary>
        /// Gemini 3.1 Flash Image.
        /// </summary>
        public static Model Gemini31FlashImage { get; } = new("gemini-3.1-flash-image");

        /// <summary>
        /// Our most cost-efficient model, optimized for high-volume agentic tasks, translation, and simple data processing.
        /// </summary>
        public static Model Gemini31FlashLite { get; } = new("gemini-3.1-flash-lite");

        /// <summary>
        /// Gemini 3.1 Flash TTS: Powerful, low-latency speech generation. Enjoy natural outputs, steerable prompts, and new expressive audio tags for precise narration control.
        /// </summary>
        public static Model Gemini31FlashTtsPreview { get; } = new("gemini-3.1-flash-tts-preview");

        /// <summary>
        /// Our latest SOTA reasoning model with unprecedented depth and nuance, and powerful multimodal understanding and coding capabilities.
        /// </summary>
        public static Model Gemini31ProPreview { get; } = new("gemini-3.1-pro-preview");

        /// <summary>
        /// Gemini 3.1 Pro Preview optimized for custom tool usage
        /// </summary>
        public static Model Gemini31ProPreviewCustomtools { get; } = new("gemini-3.1-pro-preview-customtools");

        /// <summary>
        /// Our most intelligent model for sustained frontier performance in agentic and coding tasks.
        /// </summary>
        public static Model Gemini35Flash { get; } = new("gemini-3.5-flash");

        /// <summary>
        /// Our most intelligent model for sustained frontier performance in agentic and coding tasks.
        /// </summary>
        public static Model Gemini36Flash { get; } = new("gemini-3.6-flash");

        /// <summary>
        /// Our most intelligent model for sustained frontier performance in agentic and coding tasks.
        /// </summary>
        public static Model Gemini37Flash { get; } = new("gemini-3.7-flash");

        /// <summary>
        /// Our most intelligent model for sustained frontier performance in agentic and coding tasks.
        /// </summary>
        public static Model Gemini38Flash { get; } = new("gemini-3.8-flash");

        /// <summary>
        /// Gemini 3.8 Flash Lite TTS - High-speed and cost-efficient, ideal for rapid dubbing, media localization, and high-throughput voice agents. Direct replacement for gemini-3.1-flash-tts-preview.
        /// </summary>
        public static Model Gemini38FlashLiteTts { get; } = new("gemini-3.8-flash-lite-tts");

        /// <summary>
        /// Gemini 3.8 Flash TTS - Flagship TTS model for Voice Design and dual-speaker screenplay control. Prompt custom vocal personas, direct line-by-line delivery, and add vocal bursts.
        /// </summary>
        public static Model Gemini38FlashTts { get; } = new("gemini-3.8-flash-tts");

        /// <summary>
        /// Latest release of Gemini Flash
        /// </summary>
        public static Model GeminiFlashLatest { get; } = new("gemini-flash-latest");

        /// <summary>
        /// Latest release of Gemini Flash-Lite
        /// </summary>
        public static Model GeminiFlashLiteLatest { get; } = new("gemini-flash-lite-latest");

        /// <summary>
        /// Latest release of Gemini Pro
        /// </summary>
        public static Model GeminiProLatest { get; } = new("gemini-pro-latest");

        /// <summary>
        /// Gemini Robotics-ER 1.6 Preview
        /// </summary>
        public static Model GeminiRoboticsEr16Preview { get; } = new("gemini-robotics-er-1.6-preview");

        /// <summary>
        /// Gemini Robotics Embodied Reasoning 2 Preview
        /// </summary>
        public static Model GeminiRoboticsEr2Preview { get; } = new("gemini-robotics-er-2-preview");

        /// <summary>
        /// Gemma 4 26B A4B IT
        /// </summary>
        public static Model Gemma426bA4bIt { get; } = new("gemma-4-26b-a4b-it");

        /// <summary>
        /// Gemma 4 31B IT
        /// </summary>
        public static Model Gemma431bIt { get; } = new("gemma-4-31b-it");

        /// <summary>
        /// Our low-latency, music generation model optimized for high-fidelity audio clips and precise rhythmic control.
        /// </summary>
        public static Model Lyria3ClipPreview { get; } = new("lyria-3-clip-preview");

        /// <summary>
        /// Our advanced, full-song generative model with deep compositional understanding, optimized for precise structural control and complex transitions across diverse musical styles.
        /// </summary>
        public static Model Lyria3ProPreview { get; } = new("lyria-3-pro-preview");

        /// <summary>
        /// Gemini 3 Pro Image Preview
        /// </summary>
        public static Model NanoBananaProPreview { get; } = new("nano-banana-pro-preview");
        /// <summary>
        ///
        /// </summary>
        public static Model FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "gemini-2.5-flash" => Gemini25Flash,
                "gemini-2.5-flash-image" => Gemini25FlashImage,
                "gemini-2.5-flash-lite" => Gemini25FlashLite,
                "gemini-2.5-pro" => Gemini25Pro,
                "gemini-3-flash-preview" => Gemini3FlashPreview,
                "gemini-3-pro-image" => Gemini3ProImage,
                "gemini-3.1-flash-image" => Gemini31FlashImage,
                "gemini-3.1-flash-lite" => Gemini31FlashLite,
                "gemini-3.1-flash-tts-preview" => Gemini31FlashTtsPreview,
                "gemini-3.1-pro-preview" => Gemini31ProPreview,
                "gemini-3.1-pro-preview-customtools" => Gemini31ProPreviewCustomtools,
                "gemini-3.5-flash" => Gemini35Flash,
                "gemini-3.6-flash" => Gemini36Flash,
                "gemini-3.7-flash" => Gemini37Flash,
                "gemini-3.8-flash" => Gemini38Flash,
                "gemini-3.8-flash-lite-tts" => Gemini38FlashLiteTts,
                "gemini-3.8-flash-tts" => Gemini38FlashTts,
                "gemini-flash-latest" => GeminiFlashLatest,
                "gemini-flash-lite-latest" => GeminiFlashLiteLatest,
                "gemini-pro-latest" => GeminiProLatest,
                "gemini-robotics-er-1.6-preview" => GeminiRoboticsEr16Preview,
                "gemini-robotics-er-2-preview" => GeminiRoboticsEr2Preview,
                "gemma-4-26b-a4b-it" => Gemma426bA4bIt,
                "gemma-4-31b-it" => Gemma431bIt,
                "lyria-3-clip-preview" => Lyria3ClipPreview,
                "lyria-3-pro-preview" => Lyria3ProPreview,
                "nano-banana-pro-preview" => NanoBananaProPreview,
                _ => new Model(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "gemini-2.5-flash" => true,
            "gemini-2.5-flash-image" => true,
            "gemini-2.5-flash-lite" => true,
            "gemini-2.5-pro" => true,
            "gemini-3-flash-preview" => true,
            "gemini-3-pro-image" => true,
            "gemini-3.1-flash-image" => true,
            "gemini-3.1-flash-lite" => true,
            "gemini-3.1-flash-tts-preview" => true,
            "gemini-3.1-pro-preview" => true,
            "gemini-3.1-pro-preview-customtools" => true,
            "gemini-3.5-flash" => true,
            "gemini-3.6-flash" => true,
            "gemini-3.7-flash" => true,
            "gemini-3.8-flash" => true,
            "gemini-3.8-flash-lite-tts" => true,
            "gemini-3.8-flash-tts" => true,
            "gemini-flash-latest" => true,
            "gemini-flash-lite-latest" => true,
            "gemini-pro-latest" => true,
            "gemini-robotics-er-1.6-preview" => true,
            "gemini-robotics-er-2-preview" => true,
            "gemma-4-26b-a4b-it" => true,
            "gemma-4-31b-it" => true,
            "lyria-3-clip-preview" => true,
            "lyria-3-pro-preview" => true,
            "nano-banana-pro-preview" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(Model other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Model other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Model left, Model right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Model left, Model right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Model value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Model? ToEnum(string value)
        {
            return Model.FromValue(value);
        }
    }
}