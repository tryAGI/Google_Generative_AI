
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Required. The category for this setting.
    /// </summary>
    public enum SafetySettingCategory
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
    public static class SafetySettingCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SafetySettingCategory value)
        {
            return value switch
            {
                SafetySettingCategory.HarmCategoryUnspecified => "HARM_CATEGORY_UNSPECIFIED",
                SafetySettingCategory.HarmCategoryDerogatory => "HARM_CATEGORY_DEROGATORY",
                SafetySettingCategory.HarmCategoryToxicity => "HARM_CATEGORY_TOXICITY",
                SafetySettingCategory.HarmCategoryViolence => "HARM_CATEGORY_VIOLENCE",
                SafetySettingCategory.HarmCategorySexual => "HARM_CATEGORY_SEXUAL",
                SafetySettingCategory.HarmCategoryMedical => "HARM_CATEGORY_MEDICAL",
                SafetySettingCategory.HarmCategoryDangerous => "HARM_CATEGORY_DANGEROUS",
                SafetySettingCategory.HarmCategoryHarassment => "HARM_CATEGORY_HARASSMENT",
                SafetySettingCategory.HarmCategoryHateSpeech => "HARM_CATEGORY_HATE_SPEECH",
                SafetySettingCategory.HarmCategorySexuallyExplicit => "HARM_CATEGORY_SEXUALLY_EXPLICIT",
                SafetySettingCategory.HarmCategoryDangerousContent => "HARM_CATEGORY_DANGEROUS_CONTENT",
                SafetySettingCategory.HarmCategoryCivicIntegrity => "HARM_CATEGORY_CIVIC_INTEGRITY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SafetySettingCategory? ToEnum(string value)
        {
            return value switch
            {
                "HARM_CATEGORY_UNSPECIFIED" => SafetySettingCategory.HarmCategoryUnspecified,
                "HARM_CATEGORY_DEROGATORY" => SafetySettingCategory.HarmCategoryDerogatory,
                "HARM_CATEGORY_TOXICITY" => SafetySettingCategory.HarmCategoryToxicity,
                "HARM_CATEGORY_VIOLENCE" => SafetySettingCategory.HarmCategoryViolence,
                "HARM_CATEGORY_SEXUAL" => SafetySettingCategory.HarmCategorySexual,
                "HARM_CATEGORY_MEDICAL" => SafetySettingCategory.HarmCategoryMedical,
                "HARM_CATEGORY_DANGEROUS" => SafetySettingCategory.HarmCategoryDangerous,
                "HARM_CATEGORY_HARASSMENT" => SafetySettingCategory.HarmCategoryHarassment,
                "HARM_CATEGORY_HATE_SPEECH" => SafetySettingCategory.HarmCategoryHateSpeech,
                "HARM_CATEGORY_SEXUALLY_EXPLICIT" => SafetySettingCategory.HarmCategorySexuallyExplicit,
                "HARM_CATEGORY_DANGEROUS_CONTENT" => SafetySettingCategory.HarmCategoryDangerousContent,
                "HARM_CATEGORY_CIVIC_INTEGRITY" => SafetySettingCategory.HarmCategoryCivicIntegrity,
                _ => null,
            };
        }
    }
}