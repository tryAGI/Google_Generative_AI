
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Google.Gemini.NextGen.JsonConverters.CreateAgentInteractionStatusJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CreateAgentInteractionStatusNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AgentOptionJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AgentOptionNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AllowedToolsModeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AllowedToolsModeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AudioContentMimeTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AudioContentMimeTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AudioDeltaMimeTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AudioDeltaMimeTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AudioResponseFormatDeliveryJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AudioResponseFormatDeliveryNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AudioResponseFormatMimeTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AudioResponseFormatMimeTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CodeExecutionCallArgumentsLanguageJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CodeExecutionCallArgumentsLanguageNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CodeExecutionCallArgumentsLanguage2JsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CodeExecutionCallArgumentsLanguage2NullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ComputerUseDisabledSafetyPolicieJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ComputerUseDisabledSafetyPolicieNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ComputerUseEnvironmentJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ComputerUseEnvironmentNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CreateEnvironmentRequestNetworkJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CreateEnvironmentRequestNetworkNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CredentialStatusJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CredentialStatusNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CredentialTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CredentialTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.DeepResearchAgentConfigVisualizationJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.DeepResearchAgentConfigVisualizationNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.DocumentContentMimeTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.DocumentContentMimeTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.DocumentDeltaMimeTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.DocumentDeltaMimeTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetworkJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetworkNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.EnvironmentStatusJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.EnvironmentStatusNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetwork2JsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetwork2NullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.EnvironmentFileTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.EnvironmentFileTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetworkEgressAllowlistEnum2JsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetworkEgressAllowlistEnum2NullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.FindRequestModeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.FindRequestModeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.GenerationConfigToolChoiceJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.GenerationConfigToolChoiceNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.GoogleSearchSearchTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.GoogleSearchSearchTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.GoogleSearchCallStepSearchTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.GoogleSearchCallStepSearchTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.GroundingToolCountTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.GroundingToolCountTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.HarmCategoryJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.HarmCategoryNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageConfigAspectRatioJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageConfigAspectRatioNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageConfigImageSizeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageConfigImageSizeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageContentMimeTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageContentMimeTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageDeltaMimeTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageDeltaMimeTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageResponseFormatAspectRatioJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageResponseFormatAspectRatioNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageResponseFormatDeliveryJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageResponseFormatDeliveryNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageResponseFormatImageSizeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageResponseFormatImageSizeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageResponseFormatMimeTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ImageResponseFormatMimeTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.InjectionLocation3JsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.InjectionLocation3NullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.InteractionStatusJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.InteractionStatusNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.InteractionSseEventInteractionStatusJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.InteractionSseEventInteractionStatusNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.InteractionStatusUpdateStatusJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.InteractionStatusUpdateStatusNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.MediaResolutionJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.MediaResolutionNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CreateModelInteractionStatusJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CreateModelInteractionStatusNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ModelJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ModelNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.PitchJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.PitchNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ResponseModalityJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ResponseModalityNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.RetrievalRetrievalTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.RetrievalRetrievalTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.RetrievalCallDeltaRetrievalTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.RetrievalCallDeltaRetrievalTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.RetrievalCallStepRetrievalTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.RetrievalCallStepRetrievalTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.RotateSigningSecretRequestRevocationBehaviorJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.RotateSigningSecretRequestRevocationBehaviorNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.SafetySettingMethodJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.SafetySettingMethodNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.SafetySettingThresholdJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.SafetySettingThresholdNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ServiceTierJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ServiceTierNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.SourceTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.SourceTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.TextResponseFormatMimeTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.TextResponseFormatMimeTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ThinkingLevelJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ThinkingLevelNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ThinkingSummariesJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ThinkingSummariesNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.TranscriptionConfigModeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.TranscriptionConfigModeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.TriggerStatusJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.TriggerStatusNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.TriggerExecutionStatusJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.TriggerExecutionStatusNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.TriggerUpdateStatusJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.TriggerUpdateStatusNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.URLContextResultStatusJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.URLContextResultStatusNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.UrlContextResultItemStatusJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.UrlContextResultItemStatusNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VideoConfigTaskJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VideoConfigTaskNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VideoContentMimeTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VideoContentMimeTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VideoContentProcessingJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VideoContentProcessingNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VideoDeltaMimeTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VideoDeltaMimeTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VideoResponseFormatAspectRatioJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VideoResponseFormatAspectRatioNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VideoResponseFormatDeliveryJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VideoResponseFormatDeliveryNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VideoResponseFormatResolutionJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VideoResponseFormatResolutionNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VoiceTypeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.VoiceTypeNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.WebhookStateJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.WebhookStateNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.WebhookSubscribedEventJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.WebhookSubscribedEventNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.WebhookUpdateStateJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.WebhookUpdateStateNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.WebhookUpdateSubscribedEventJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.WebhookUpdateSubscribedEventNullableJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AgentToolJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AnnotationJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ContentJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CredentialCreateParamsJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.CredentialUpdateJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.EnvironmentNetworkEgressAllowlistJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.FunctionResultSubcontentJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.AgentConfig2JsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.InteractionSSEEventJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.InteractionsInputJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.MediaProcessingJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ResponseFormat4JsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.StepJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.StepDeltaDataJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ThoughtSummaryContentJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.ToolJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.TranscriptionModeJsonConverter),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.Environment3, string>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.AntigravityAgentConfig, global::Google.Gemini.NextGen.CodeMenderAgentConfig, global::Google.Gemini.NextGen.DeepResearchAgentConfig, global::Google.Gemini.NextGen.DynamicAgentConfig>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.Environment3, string>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.ResponseFormat4?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist?, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist?, global::Google.Gemini.NextGen.EnvironmentNetwork?>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist?, global::Google.Gemini.NextGen.EnvironmentNetwork2?>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.InjectionLocation3?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation3>>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.InjectionLocation3?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation3>>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FunctionResultSubcontent>, object, string>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FunctionResultSubcontent>, object, string>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.SpeakerConfig, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig2>>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.ToolChoiceConfig, global::Google.Gemini.NextGen.GenerationConfigToolChoice?>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.Environment3, string>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.ResponseFormat4?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FunctionResultSubcontent>, object, string>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FunctionResultSubcontent>, object, string>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.Environment3, string>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.ResponseFormat4?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.TranscriptionMode?, global::Google.Gemini.NextGen.TranscriptionConfigMode?>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.CreateAgentInteraction, global::Google.Gemini.NextGen.CreateModelInteraction>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.MediaProcessing?, global::Google.Gemini.NextGen.VideoContentProcessing?>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.CreateAgentInteraction, global::Google.Gemini.NextGen.CreateModelInteraction>),

            typeof(global::Google.Gemini.NextGen.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AntigravityAgentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.Environment3, string>), TypeInfoPropertyName = "OneOfEnvironment3String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Environment3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AgentTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AgentTool), TypeInfoPropertyName = "AgentTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateAgentInteraction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AgentOption), TypeInfoPropertyName = "AgentOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AntigravityAgentConfig, global::Google.Gemini.NextGen.CodeMenderAgentConfig, global::Google.Gemini.NextGen.DeepResearchAgentConfig, global::Google.Gemini.NextGen.DynamicAgentConfig>), TypeInfoPropertyName = "OneOfAntigravityAgentConfigCodeMenderAgentConfigDeepResearchAgentConfigDynamicAgentConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CodeMenderAgentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DeepResearchAgentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DynamicAgentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.InteractionsInput), TypeInfoPropertyName = "InteractionsInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ResponseFormat4?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>>), TypeInfoPropertyName = "OneOfResponseFormat4IListResponseFormat42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ResponseFormat4), TypeInfoPropertyName = "ResponseFormat42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ResponseModality), TypeInfoPropertyName = "ResponseModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SafetySetting>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SafetySetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ServiceTier), TypeInfoPropertyName = "ServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateAgentInteractionStatus), TypeInfoPropertyName = "CreateAgentInteractionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Tool), TypeInfoPropertyName = "Tool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CodeExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.MCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.URLContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AllowedTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AllowedToolsMode), TypeInfoPropertyName = "AllowedToolsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Annotation), TypeInfoPropertyName = "Annotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FileCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.PlaceCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SpeechAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.URLCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WordInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ArgumentsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioContentMimeType), TypeInfoPropertyName = "AudioContentMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioDeltaMimeType), TypeInfoPropertyName = "AudioDeltaMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioResponseFormatDelivery), TypeInfoPropertyName = "AudioResponseFormatDelivery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AudioResponseFormatMimeType), TypeInfoPropertyName = "AudioResponseFormatMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CodeExecutionCallArguments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CodeExecutionCallArgumentsLanguage), TypeInfoPropertyName = "CodeExecutionCallArgumentsLanguage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CodeExecutionCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CodeExecutionCallStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CodeExecutionCallArguments2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CodeExecutionCallArgumentsLanguage2), TypeInfoPropertyName = "CodeExecutionCallArgumentsLanguage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CodeExecutionResultDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CodeExecutionResultStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FindRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FixRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SessionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ComputerUse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie), TypeInfoPropertyName = "ComputerUseDisabledSafetyPolicie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ComputerUseEnvironment), TypeInfoPropertyName = "ComputerUseEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Content), TypeInfoPropertyName = "Content2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DocumentContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateEnvironmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist?, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>), TypeInfoPropertyName = "OneOfEnvironmentNetworkEgressAllowlistCreateEnvironmentRequestNetwork2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist), TypeInfoPropertyName = "EnvironmentNetworkEgressAllowlist2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork), TypeInfoPropertyName = "CreateEnvironmentRequestNetwork2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Webhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Credential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CredentialStatus), TypeInfoPropertyName = "CredentialStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CredentialType), TypeInfoPropertyName = "CredentialType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CredentialCreateParams), TypeInfoPropertyName = "CredentialCreateParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentVariableConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.HttpBearerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OAuth2Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CredentialUpdate), TypeInfoPropertyName = "CredentialUpdate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.HttpBearerUpdateConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OAuth2UpdateConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ThinkingSummaries), TypeInfoPropertyName = "ThinkingSummaries2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DeepResearchAgentConfigVisualization), TypeInfoPropertyName = "DeepResearchAgentConfigVisualization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DeleteVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DocumentContentMimeType), TypeInfoPropertyName = "DocumentContentMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DocumentDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DocumentDeltaMimeType), TypeInfoPropertyName = "DocumentDeltaMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AllowlistEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>), TypeInfoPropertyName = "OneOfIListDictionaryStringStringDictionaryStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Empty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvVar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Environment2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist?, global::Google.Gemini.NextGen.EnvironmentNetwork?>), TypeInfoPropertyName = "OneOfEnvironmentNetworkEgressAllowlistEnvironmentNetwork2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetwork), TypeInfoPropertyName = "EnvironmentNetwork2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentStatus), TypeInfoPropertyName = "EnvironmentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>), TypeInfoPropertyName = "OneOfDictionaryStringEnvVarString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist?, global::Google.Gemini.NextGen.EnvironmentNetwork2?>), TypeInfoPropertyName = "OneOfEnvironmentNetworkEgressAllowlistEnvironmentNetwork22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetwork2), TypeInfoPropertyName = "EnvironmentNetwork22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentFileType), TypeInfoPropertyName = "EnvironmentFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2), TypeInfoPropertyName = "EnvironmentNetworkEgressAllowlistEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.InjectionLocation3?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation3>>), TypeInfoPropertyName = "OneOfInjectionLocation3IListInjectionLocation32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.InjectionLocation3), TypeInfoPropertyName = "InjectionLocation32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ExaAISearchConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FileContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FileSearchCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FileSearchCallStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FileSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FileSearchResultDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FileSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FileSearchResultStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Filter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FindRequestMode), TypeInfoPropertyName = "FindRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FileContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FunctionCallStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FunctionResultDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FunctionResultSubcontent>, object, string>), TypeInfoPropertyName = "OneOfIListFunctionResultSubcontentObjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FunctionResultSubcontent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FunctionResultSubcontent), TypeInfoPropertyName = "FunctionResultSubcontent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.FunctionResultStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GenerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.SpeakerConfig, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig2>>), TypeInfoPropertyName = "OneOfSpeakerConfigIListSpeechConfig22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SpeakerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SpeechConfig2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ThinkingLevel), TypeInfoPropertyName = "ThinkingLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ToolChoiceConfig, global::Google.Gemini.NextGen.GenerationConfigToolChoice?>), TypeInfoPropertyName = "OneOfToolChoiceConfigGenerationConfigToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ToolChoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GenerationConfigToolChoice), TypeInfoPropertyName = "GenerationConfigToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TranscriptionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GetEnvironmentFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.EnvironmentFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GetInteractionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleMaps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleMapsCallArguments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleMapsCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleMapsCallStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleMapsCallArguments2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleMapsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Places>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Places))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleMapsResultDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleMapsResult2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResultPlaces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleMapsResultPlaces))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ReviewSnippet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ReviewSnippet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleMapsResultStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResult2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchSearchType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleSearchSearchType), TypeInfoPropertyName = "GoogleSearchSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleSearchCallArguments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleSearchCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleSearchCallStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleSearchCallArguments2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleSearchCallStepSearchType), TypeInfoPropertyName = "GoogleSearchCallStepSearchType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleSearchResultDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleSearchResult2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GoogleSearchResultStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchResult2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GroundingToolCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GroundingToolCountType), TypeInfoPropertyName = "GroundingToolCountType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.HarmCategory), TypeInfoPropertyName = "HarmCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.HttpBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.HybridSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageConfigAspectRatio), TypeInfoPropertyName = "ImageConfigAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageConfigImageSize), TypeInfoPropertyName = "ImageConfigImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageContentMimeType), TypeInfoPropertyName = "ImageContentMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.MediaResolution), TypeInfoPropertyName = "MediaResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageDeltaMimeType), TypeInfoPropertyName = "ImageDeltaMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageResponseFormatAspectRatio), TypeInfoPropertyName = "ImageResponseFormatAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageResponseFormatDelivery), TypeInfoPropertyName = "ImageResponseFormatDelivery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageResponseFormatImageSize), TypeInfoPropertyName = "ImageResponseFormatImageSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ImageResponseFormatMimeType), TypeInfoPropertyName = "ImageResponseFormatMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Interaction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AgentConfig2), TypeInfoPropertyName = "AgentConfig22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.InteractionAgentConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Error>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Model), TypeInfoPropertyName = "Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.InteractionStatus), TypeInfoPropertyName = "InteractionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Step), TypeInfoPropertyName = "Step2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.InteractionCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.InteractionSseEventInteraction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.InteractionCreatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.InteractionSseEventInteractionStatus), TypeInfoPropertyName = "InteractionSseEventInteractionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.InteractionSSEStreamEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.InteractionSSEEvent), TypeInfoPropertyName = "InteractionSSEEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.InteractionStatusUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.StepDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.StepStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.StepStop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.InteractionStatusUpdateStatus), TypeInfoPropertyName = "InteractionStatusUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.AgentListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CredentialListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Credential>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ListEnvironmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Environment2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ListTriggerExecutionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.TriggerExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TriggerExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ListTriggersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Trigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Trigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ListVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowedTools>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.MCPServerToolCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.MCPServerToolCallStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.MCPServerToolResultDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.MCPServerToolResultStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.MediaProcessing), TypeInfoPropertyName = "MediaProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.StaticMediaProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ModalityTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateModelInteraction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateModelInteractionStatus), TypeInfoPropertyName = "CreateModelInteractionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ModelOutputStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Status))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ParallelAISearchConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.PingWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookPingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Pitch), TypeInfoPropertyName = "Pitch2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ProcessingCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ProcessingCallStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ProcessingResultDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ProcessingResultStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.PromptedVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RagResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RagRetrievalConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Ranking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RagStoreConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.RagResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RankService))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ReplicatedVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TextResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.Retrieval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.RetrievalRetrievalType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RetrievalRetrievalType), TypeInfoPropertyName = "RetrievalRetrievalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VertexAISearchConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RetrievalCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RetrievalCallArguments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RetrievalCallDeltaRetrievalType), TypeInfoPropertyName = "RetrievalCallDeltaRetrievalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RetrievalCallStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RetrievalCallStepRetrievalType), TypeInfoPropertyName = "RetrievalCallStepRetrievalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RetrievalResultDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RetrievalResultStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RotateSigningSecretRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior), TypeInfoPropertyName = "RotateSigningSecretRequestRevocationBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookRotateSigningSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.RunTriggerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SafetySettingMethod), TypeInfoPropertyName = "SafetySettingMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SafetySettingThreshold), TypeInfoPropertyName = "SafetySettingThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SigningSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SmartTranscriptionMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.SourceType), TypeInfoPropertyName = "SourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ThoughtStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.URLContextCallStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.URLContextResultStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.UserInputStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.StepDeltaData), TypeInfoPropertyName = "StepDeltaData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.StepDeltaMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TextAnnotationDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TextDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ThoughtSignatureDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ThoughtSummaryDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.URLContextCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.URLContextResultDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TextResponseFormatMimeType), TypeInfoPropertyName = "TextResponseFormatMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.ThoughtSummaryContent), TypeInfoPropertyName = "ThoughtSummaryContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ThoughtSummaryContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.TranscriptionMode?, global::Google.Gemini.NextGen.TranscriptionConfigMode?>), TypeInfoPropertyName = "OneOfTranscriptionModeTranscriptionConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TranscriptionMode), TypeInfoPropertyName = "TranscriptionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TranscriptionConfigMode), TypeInfoPropertyName = "TranscriptionConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VerbatimTranscriptionMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TriggerStatus), TypeInfoPropertyName = "TriggerStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TriggerCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.CreateAgentInteraction, global::Google.Gemini.NextGen.CreateModelInteraction>), TypeInfoPropertyName = "OneOfCreateAgentInteractionCreateModelInteraction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TriggerExecutionStatus), TypeInfoPropertyName = "TriggerExecutionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TriggerUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.TriggerUpdateStatus), TypeInfoPropertyName = "TriggerUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.UpdateTriggerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.UpdateWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.UploadEnvironmentFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.UploadEnvironmentFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.URLContextCallArguments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.UrlContextCallStepArguments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.URLContextResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.URLContextResultStatus), TypeInfoPropertyName = "URLContextResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.URLContextResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.UrlContextResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.UrlContextResultItemStatus), TypeInfoPropertyName = "UrlContextResultItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GroundingToolCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoConfigTask), TypeInfoPropertyName = "VideoConfigTask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoContentMimeType), TypeInfoPropertyName = "VideoContentMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.MediaProcessing?, global::Google.Gemini.NextGen.VideoContentProcessing?>), TypeInfoPropertyName = "OneOfMediaProcessingVideoContentProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoContentProcessing), TypeInfoPropertyName = "VideoContentProcessing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoDeltaMimeType), TypeInfoPropertyName = "VideoDeltaMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoResponseFormatAspectRatio), TypeInfoPropertyName = "VideoResponseFormatAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoResponseFormatDelivery), TypeInfoPropertyName = "VideoResponseFormatDelivery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VideoResponseFormatResolution), TypeInfoPropertyName = "VideoResponseFormatResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.VoiceType), TypeInfoPropertyName = "VoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SigningSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookState), TypeInfoPropertyName = "WebhookState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.WebhookSubscribedEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookSubscribedEvent), TypeInfoPropertyName = "WebhookSubscribedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookUpdateState), TypeInfoPropertyName = "WebhookUpdateState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent), TypeInfoPropertyName = "WebhookUpdateSubscribedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateInteractionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CreateInteractionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DeleteInteractionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.DeleteInteractionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GetInteractionByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.GetInteractionByIdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CancelInteractionByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.CancelInteractionByIdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AgentTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ResponseFormat4?, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ResponseFormat4>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ResponseFormat4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ResponseModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SafetySetting>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AllowlistEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.InjectionLocation3?, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.InjectionLocation3>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.InjectionLocation3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.FileSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.FileContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::Google.Gemini.NextGen.FunctionResultSubcontent>, object, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.FunctionResultSubcontent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.SpeakerConfig, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SpeechConfig2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SpeechConfig2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.EnvironmentFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Places>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleMapsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleMapsResultPlaces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ReviewSnippet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleMapsResult2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleSearchSearchType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleSearchResult2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Error>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Step>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Content>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Credential>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Environment2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.TriggerExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Trigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AllowedTools>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.RagResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.RetrievalRetrievalType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ThoughtSummaryContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.URLContextResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ModalityTokens>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GroundingToolCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SigningSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.WebhookSubscribedEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent>))]
    public sealed partial class NextGenSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}