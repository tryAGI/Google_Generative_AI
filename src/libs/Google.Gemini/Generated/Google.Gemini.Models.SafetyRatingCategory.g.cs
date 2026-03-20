
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Required. The category for this rating.
    /// </summary>
    public enum SafetyRatingCategory
    {
        /// <summary>
        /// Category is unspecified.
        /// </summary>
        HarmCategoryUnspecified,
        /// <summary>
        /// **PaLM** - Negative or harmful comments targeting identity and/or protected attribute.
        /// </summary>
        HarmCategoryDerogatory,
        /// <summary>
        /// **PaLM** - Content that is rude, disrespectful, or profane.
        /// </summary>
        HarmCategoryToxicity,
        /// <summary>
        /// **PaLM** - Describes scenarios depicting violence against an individual or group, or general descriptions of gore.
        /// </summary>
        HarmCategoryViolence,
        /// <summary>
        /// **PaLM** - Contains references to sexual acts or other lewd content.
        /// </summary>
        HarmCategorySexual,
        /// <summary>
        /// **PaLM** - Promotes unchecked medical advice.
        /// </summary>
        HarmCategoryMedical,
        /// <summary>
        /// **PaLM** - Dangerous content that promotes, facilitates, or encourages harmful acts.
        /// </summary>
        HarmCategoryDangerous,
        /// <summary>
        /// **Gemini** - Harassment content.
        /// </summary>
        HarmCategoryHarassment,
        /// <summary>
        /// **Gemini** - Hate speech and content.
        /// </summary>
        HarmCategoryHateSpeech,
        /// <summary>
        /// **Gemini** - Sexually explicit content.
        /// </summary>
        HarmCategorySexuallyExplicit,
        /// <summary>
        /// **Gemini** - Dangerous content.
        /// </summary>
        HarmCategoryDangerousContent,
        /// <summary>
        /// **Gemini** - Content that may be used to harm civic integrity. DEPRECATED: use enable_enhanced_civic_answers instead.
        /// </summary>
        HarmCategoryCivicIntegrity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SafetyRatingCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SafetyRatingCategory value)
        {
            return value switch
            {
                SafetyRatingCategory.HarmCategoryUnspecified => "HARM_CATEGORY_UNSPECIFIED",
                SafetyRatingCategory.HarmCategoryDerogatory => "HARM_CATEGORY_DEROGATORY",
                SafetyRatingCategory.HarmCategoryToxicity => "HARM_CATEGORY_TOXICITY",
                SafetyRatingCategory.HarmCategoryViolence => "HARM_CATEGORY_VIOLENCE",
                SafetyRatingCategory.HarmCategorySexual => "HARM_CATEGORY_SEXUAL",
                SafetyRatingCategory.HarmCategoryMedical => "HARM_CATEGORY_MEDICAL",
                SafetyRatingCategory.HarmCategoryDangerous => "HARM_CATEGORY_DANGEROUS",
                SafetyRatingCategory.HarmCategoryHarassment => "HARM_CATEGORY_HARASSMENT",
                SafetyRatingCategory.HarmCategoryHateSpeech => "HARM_CATEGORY_HATE_SPEECH",
                SafetyRatingCategory.HarmCategorySexuallyExplicit => "HARM_CATEGORY_SEXUALLY_EXPLICIT",
                SafetyRatingCategory.HarmCategoryDangerousContent => "HARM_CATEGORY_DANGEROUS_CONTENT",
                SafetyRatingCategory.HarmCategoryCivicIntegrity => "HARM_CATEGORY_CIVIC_INTEGRITY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SafetyRatingCategory? ToEnum(string value)
        {
            return value switch
            {
                "HARM_CATEGORY_UNSPECIFIED" => SafetyRatingCategory.HarmCategoryUnspecified,
                "HARM_CATEGORY_DEROGATORY" => SafetyRatingCategory.HarmCategoryDerogatory,
                "HARM_CATEGORY_TOXICITY" => SafetyRatingCategory.HarmCategoryToxicity,
                "HARM_CATEGORY_VIOLENCE" => SafetyRatingCategory.HarmCategoryViolence,
                "HARM_CATEGORY_SEXUAL" => SafetyRatingCategory.HarmCategorySexual,
                "HARM_CATEGORY_MEDICAL" => SafetyRatingCategory.HarmCategoryMedical,
                "HARM_CATEGORY_DANGEROUS" => SafetyRatingCategory.HarmCategoryDangerous,
                "HARM_CATEGORY_HARASSMENT" => SafetyRatingCategory.HarmCategoryHarassment,
                "HARM_CATEGORY_HATE_SPEECH" => SafetyRatingCategory.HarmCategoryHateSpeech,
                "HARM_CATEGORY_SEXUALLY_EXPLICIT" => SafetyRatingCategory.HarmCategorySexuallyExplicit,
                "HARM_CATEGORY_DANGEROUS_CONTENT" => SafetyRatingCategory.HarmCategoryDangerousContent,
                "HARM_CATEGORY_CIVIC_INTEGRITY" => SafetyRatingCategory.HarmCategoryCivicIntegrity,
                _ => null,
            };
        }
    }
}