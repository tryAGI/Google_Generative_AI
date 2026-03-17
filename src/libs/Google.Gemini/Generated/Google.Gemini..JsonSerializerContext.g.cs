
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
            typeof(global::Google.Gemini.JsonConverters.FunctionResponseSchedulingJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.FunctionResponseSchedulingNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ExecutableCodeLanguageJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ExecutableCodeLanguageNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.CodeExecutionResultOutcomeJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.CodeExecutionResultOutcomeNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ToolCallToolTypeJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ToolCallToolTypeNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ToolResponseToolTypeJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ToolResponseToolTypeNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SchemaTypeJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SchemaTypeNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.FunctionDeclarationBehaviorJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.FunctionDeclarationBehaviorNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.DynamicRetrievalConfigModeJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.DynamicRetrievalConfigModeNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ComputerUseEnvironmentJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ComputerUseEnvironmentNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.FunctionCallingConfigModeJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.FunctionCallingConfigModeNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetySettingCategoryJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetySettingCategoryNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetySettingThresholdJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetySettingThresholdNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.GenerationConfigResponseModalitieJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.GenerationConfigResponseModalitieNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ThinkingConfigThinkingLevelJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ThinkingConfigThinkingLevelNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.GenerationConfigMediaResolutionJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.GenerationConfigMediaResolutionNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.CandidateFinishReasonJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.CandidateFinishReasonNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetyRatingCategoryJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetyRatingCategoryNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetyRatingProbabilityJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.SafetyRatingProbabilityNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.UrlMetadataUrlRetrievalStatusJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.UrlMetadataUrlRetrievalStatusNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.PromptFeedbackBlockReasonJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.PromptFeedbackBlockReasonNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ModalityTokenCountModalityJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ModalityTokenCountModalityNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ModelStatusModelStageJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ModelStatusModelStageNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ConditionOperationJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ConditionOperationNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.GenerateAnswerRequestAnswerStyleJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.GenerateAnswerRequestAnswerStyleNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.InputFeedbackBlockReasonJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.InputFeedbackBlockReasonNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.EmbedContentRequestTaskTypeJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.EmbedContentRequestTaskTypeNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.GenerateContentBatchStateJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.GenerateContentBatchStateNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.EmbedContentBatchStateJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.EmbedContentBatchStateNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ContentFilterReasonJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.ContentFilterReasonNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.FileStateJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.FileStateNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.FileSourceJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.FileSourceNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.GeneratedFileStateJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.GeneratedFileStateNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.TunedModelStateJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.TunedModelStateNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.PermissionGranteeTypeJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.PermissionGranteeTypeNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.PermissionRoleJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.PermissionRoleNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.DocumentStateJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.DocumentStateNullableJsonConverter),
            typeof(global::Google.Gemini.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}