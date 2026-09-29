
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
        CivicIntegrity,
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
        ImageDangerousContent,
        /// <summary>
        ///
        /// </summary>
        ImageHarassment,
        /// <summary>
        ///
        /// </summary>
        ImageHate,
        /// <summary>
        ///
        /// </summary>
        ImageSexuallyExplicit,
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
                HarmCategory.CivicIntegrity => "civic_integrity",
                HarmCategory.DangerousContent => "dangerous_content",
                HarmCategory.Harassment => "harassment",
                HarmCategory.HateSpeech => "hate_speech",
                HarmCategory.ImageDangerousContent => "image_dangerous_content",
                HarmCategory.ImageHarassment => "image_harassment",
                HarmCategory.ImageHate => "image_hate",
                HarmCategory.ImageSexuallyExplicit => "image_sexually_explicit",
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
                "civic_integrity" => HarmCategory.CivicIntegrity,
                "dangerous_content" => HarmCategory.DangerousContent,
                "harassment" => HarmCategory.Harassment,
                "hate_speech" => HarmCategory.HateSpeech,
                "image_dangerous_content" => HarmCategory.ImageDangerousContent,
                "image_harassment" => HarmCategory.ImageHarassment,
                "image_hate" => HarmCategory.ImageHate,
                "image_sexually_explicit" => HarmCategory.ImageSexuallyExplicit,
                "jailbreak" => HarmCategory.Jailbreak,
                "sexually_explicit" => HarmCategory.SexuallyExplicit,
                _ => null,
            };
        }
    }
}