
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Google.Gemini
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Google.Gemini.JsonConverters.EmbedContentRequestTaskTypeJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.EmbedContentRequestTaskTypeNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.CandidateFinishReasonJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.CandidateFinishReasonNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetyRatingCategoryJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetyRatingCategoryNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetyRatingProbabilityJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetyRatingProbabilityNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetySettingCategoryJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetySettingCategoryNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetySettingThresholdJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetySettingThresholdNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.PromptFeedbackBlockReasonJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.PromptFeedbackBlockReasonNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}