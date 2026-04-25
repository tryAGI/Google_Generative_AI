
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
            typeof(global::Google.Gemini.JsonConverters.SafetySettingCategoryJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.SafetySettingCategoryNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.SafetySettingThresholdJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.SafetySettingThresholdNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.TunedModelStateJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.TunedModelStateNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.ModalityTokenCountModalityJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.ModalityTokenCountModalityNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.FileStateJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.FileStateNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.FileSourceJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.FileSourceNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.EmbedContentConfigTaskTypeJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.EmbedContentConfigTaskTypeNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.GenerationConfigResponseModalitieJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.GenerationConfigResponseModalitieNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.GenerationConfigMediaResolutionJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.GenerationConfigMediaResolutionNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.EmbedContentBatchStateJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.EmbedContentBatchStateNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.ToolResponseToolTypeJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.ToolResponseToolTypeNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.UrlMetadataUrlRetrievalStatusJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.UrlMetadataUrlRetrievalStatusNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.ExecutableCodeLanguageJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.ExecutableCodeLanguageNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.EmbedContentRequestTaskTypeJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.EmbedContentRequestTaskTypeNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.GenerateContentRequestServiceTierJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.GenerateContentRequestServiceTierNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.FunctionCallingConfigModeJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.FunctionCallingConfigModeNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.ModelStatusModelStageJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.ModelStatusModelStageNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.GenerateContentBatchStateJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.GenerateContentBatchStateNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.DynamicRetrievalConfigModeJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.DynamicRetrievalConfigModeNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.CandidateFinishReasonJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.CandidateFinishReasonNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.PromptFeedbackBlockReasonJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.PromptFeedbackBlockReasonNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.DocumentStateJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.DocumentStateNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.PermissionGranteeTypeJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.PermissionGranteeTypeNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.PermissionRoleJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.PermissionRoleNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.GeneratedFileStateJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.GeneratedFileStateNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.ToolCallToolTypeJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.ToolCallToolTypeNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.ComputerUseEnvironmentJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.ComputerUseEnvironmentNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.FunctionDeclarationBehaviorJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.FunctionDeclarationBehaviorNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.ThinkingConfigThinkingLevelJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.ThinkingConfigThinkingLevelNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.SafetyRatingCategoryJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.SafetyRatingCategoryNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.SafetyRatingProbabilityJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.SafetyRatingProbabilityNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.CodeExecutionResultOutcomeJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.CodeExecutionResultOutcomeNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.SchemaTypeJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.SchemaTypeNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.FunctionResponseSchedulingJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.FunctionResponseSchedulingNullableJsonConverter),

            typeof(global::Google.Gemini.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Maps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.PlaceAnswerSources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.SafetySetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.SafetySettingCategory), TypeInfoPropertyName = "SafetySettingCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.SafetySettingThreshold), TypeInfoPropertyName = "SafetySettingThreshold2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.InlinedResponses))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.InlinedResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.InlinedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.TopCandidates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.LogprobsResultCandidate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.LogprobsResultCandidate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.TransferOwnershipResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.PrebuiltVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.FileData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.TunedModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.TuningTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.TunedModelState), TypeInfoPropertyName = "TunedModelState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.TunedModelSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GoogleSearchRetrieval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GoogleMaps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.FileSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GoogleSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.UrlContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.McpServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.McpServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.FunctionDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.FunctionDeclaration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ComputerUse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.CodeExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Part))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.VideoMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.FunctionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ToolResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ExecutableCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Blob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.CodeExecutionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.CitationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.CitationSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.CitationSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GroundingMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.SearchEntryPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GroundingChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.RetrievalMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GoogleAiGenerativelanguageV1betaSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.StreamableHttpTransport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ModalityTokenCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ModalityTokenCountModality), TypeInfoPropertyName = "ModalityTokenCountModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.RegisterFilesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.FileState), TypeInfoPropertyName = "FileState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.FileSource), TypeInfoPropertyName = "FileSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.VideoFileMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Status))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.SpeakerVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.VoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.EmbedContentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.EmbedContentConfigTaskType), TypeInfoPropertyName = "EmbedContentConfigTaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.TuningSnapshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.CustomMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.StringList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GenerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ImageConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.GenerationConfigResponseModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GenerationConfigResponseModalitie), TypeInfoPropertyName = "GenerationConfigResponseModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Schema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ThinkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.SpeechConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GenerationConfigMediaResolution), TypeInfoPropertyName = "GenerationConfigMediaResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.SearchTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.WebSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ImageSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GroundingPassageId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.BatchGenerateContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GenerateContentBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.EmbedContentBatchOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.InlinedEmbedContentResponses))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.FileSearchStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.CountTokensRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.Content>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Content))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GenerateContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Empty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ListTunedModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.TunedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.EmbedContentBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.EmbedContentBatchState), TypeInfoPropertyName = "EmbedContentBatchState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.InputEmbedContentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.EmbedContentBatchStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Interval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.CustomLongRunningOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ToolResponseToolType), TypeInfoPropertyName = "ToolResponseToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.FunctionResponsePart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.FunctionResponseBlob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.UrlMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.UrlMetadataUrlRetrievalStatus), TypeInfoPropertyName = "UrlMetadataUrlRetrievalStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.InputConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.InlinedRequests))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.Part>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ExecutableCodeLanguage), TypeInfoPropertyName = "ExecutableCodeLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.InlinedEmbedContentRequests))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.InlinedEmbedContentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.InlinedEmbedContentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.InlinedEmbedContentRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.InlinedEmbedContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.SemanticRetrieverChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.RegisterFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.EmbedContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.EmbedContentRequestTaskType), TypeInfoPropertyName = "EmbedContentRequestTaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.DynamicRetrievalConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GenerateContentRequestServiceTier), TypeInfoPropertyName = "GenerateContentRequestServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.RetrievalConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.LatLng))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ReviewSnippet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.RetrievedContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.GroundingChunkCustomMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GroundingChunkCustomMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.FunctionCallingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.FunctionCallingConfigMode), TypeInfoPropertyName = "FunctionCallingConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GroundingChunkStringList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.CachedContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.CachedContentUsageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.BatchEmbedContentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.EmbedContentRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.TuningExamples))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.TransferOwnershipRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ModelStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ModelStatusModelStage), TypeInfoPropertyName = "ModelStatusModelStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GenerateContentBatchState), TypeInfoPropertyName = "GenerateContentBatchState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GenerateContentBatchOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.BatchStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.AttributionSourceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.DynamicRetrievalConfigMode), TypeInfoPropertyName = "DynamicRetrievalConfigMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GenerateContentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.UsageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.PromptFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.Candidate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Candidate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.UrlContextMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.LogprobsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.CandidateFinishReason), TypeInfoPropertyName = "CandidateFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.GroundingAttribution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GroundingAttribution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.SafetyRating>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.SafetyRating))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ImportFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ChunkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.CustomMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ListFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.PromptFeedbackBlockReason), TypeInfoPropertyName = "PromptFeedbackBlockReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.AsyncBatchEmbedContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Operation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Document))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.DocumentState), TypeInfoPropertyName = "DocumentState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.WhiteSpaceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.CountTokensResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.ModalityTokenCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Permission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.PermissionGranteeType), TypeInfoPropertyName = "PermissionGranteeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.PermissionRole), TypeInfoPropertyName = "PermissionRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Corpus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ListCorporaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.Corpus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.UrlMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GeneratedFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.GeneratedFileState), TypeInfoPropertyName = "GeneratedFileState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ToolCallToolType), TypeInfoPropertyName = "ToolCallToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ComputerUseEnvironment), TypeInfoPropertyName = "ComputerUseEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.CreateFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.FunctionDeclarationBehavior), TypeInfoPropertyName = "FunctionDeclarationBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ListGeneratedFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.GeneratedFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.TuningExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.TuningExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ListFileSearchStoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.FileSearchStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Web))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.MultiSpeakerVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.UploadToFileSearchStoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.InlinedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.InlinedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.Hyperparameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.ReviewSnippet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.EmbedContentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.CreateFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ThinkingConfigThinkingLevel), TypeInfoPropertyName = "ThinkingConfigThinkingLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.TopCandidates>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ContentEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ListOperationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.Operation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.SafetyRatingCategory), TypeInfoPropertyName = "SafetyRatingCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.SafetyRatingProbability), TypeInfoPropertyName = "SafetyRatingProbability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.EmbeddingUsageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.BatchEmbedContentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.ContentEmbedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ListCachedContentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.CachedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ListPermissionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.Permission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.SpeakerVoiceConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.CodeExecutionResultOutcome), TypeInfoPropertyName = "CodeExecutionResultOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.SchemaType), TypeInfoPropertyName = "SchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.Schema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.Schema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.ListDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.TuningSnapshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Google.Gemini.FunctionResponsePart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Google.Gemini.FunctionResponseScheduling), TypeInfoPropertyName = "FunctionResponseScheduling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.InlinedResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.LogprobsResultCandidate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.McpServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.FunctionDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.CitationSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.GoogleAiGenerativelanguageV1betaGroundingSupport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.GroundingChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.GenerationConfigResponseModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.Content>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.TunedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.Part>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.InlinedEmbedContentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.InlinedEmbedContentRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.SafetySetting>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.GroundingChunkCustomMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.EmbedContentRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.Candidate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.GroundingAttribution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.SafetyRating>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.CustomMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.ModalityTokenCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.Corpus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.UrlMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.GeneratedFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.TuningExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.FileSearchStore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.InlinedRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.ReviewSnippet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.TopCandidates>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.Operation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.ContentEmbedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.CachedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.Permission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.SpeakerVoiceConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.Schema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.TuningSnapshot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Google.Gemini.FunctionResponsePart>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}