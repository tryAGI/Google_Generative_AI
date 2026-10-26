
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum HarmCategory
    {
        /// <summary>
        ///
        /// </summary>
        DangerousContent,
        /// <summary>
        ///
        /// </summary>
        Harassment,
        /// <summary>
        ///
        /// </summary>
        HateSpeech,
        /// <summary>
        ///
        /// </summary>
        Jailbreak,
        /// <summary>
        ///
        /// </summary>
        SexuallyExplicit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HarmCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HarmCategory value)
        {
            return value switch
            {
                HarmCategory.DangerousContent => "dangerous_content",
                HarmCategory.Harassment => "harassment",
                HarmCategory.HateSpeech => "hate_speech",
                HarmCategory.Jailbreak => "jailbreak",
                HarmCategory.SexuallyExplicit => "sexually_explicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HarmCategory? ToEnum(string value)
        {
            return value switch
            {
                "dangerous_content" => HarmCategory.DangerousContent,
                "harassment" => HarmCategory.Harassment,
                "hate_speech" => HarmCategory.HateSpeech,
                "jailbreak" => HarmCategory.Jailbreak,
                "sexually_explicit" => HarmCategory.SexuallyExplicit,
                _ => null,
            };
        }
    }
}