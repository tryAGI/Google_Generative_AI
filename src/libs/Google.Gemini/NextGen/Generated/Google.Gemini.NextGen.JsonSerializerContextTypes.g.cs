
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Agent? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AntigravityAgentConfig? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentConfig, string>? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentConfig? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AgentTool>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AgentTool? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AgentOption? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecution? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Function? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearch? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.McpServer? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContext? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AllowedTools? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AllowedToolsMode? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Annotation? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileCitation? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PlaceCitation? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeechAnnotation? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLCitation? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WordInfo? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Answer? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ChoiceAnswer? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.NoulAnswer? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ScoreAnswer? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ArgumentsDelta? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioContent? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AudioMediaProcessing?, global::Google.Gemini.NextGen.AudioContentProcessing?>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioMediaProcessing? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioContentProcessing? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioContentMimeType? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioData? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioDelta? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioDeltaMimeType? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioStaticMediaProcessing? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormat? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormatMimeType? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormatDelivery? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ChoiceQuestion? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInstructionContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInstructionContent>, string>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DecisionInstructionContent? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInstructionContent>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallArguments? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallArgumentsLanguage? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallDelta? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallStep? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionResultDelta? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionResultStep? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>, string>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Content? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUse? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUseEnvironment? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentContent? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageContent? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextContent? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContent? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateAgentInteraction? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionsInput? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AntigravityAgentConfig, global::Google.Gemini.NextGen.DeepResearchAgentConfig, global::Google.Gemini.NextGen.DynamicAgentConfig>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeepResearchAgentConfig? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DynamicAgentConfig? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateAgentInteractionStatus? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Tool>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Tool? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseModality>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ResponseModality? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ResponseFormat?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat>>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ResponseFormat? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ServiceTier? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookConfig? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SafetySetting>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySetting? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateDecisionRequest? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInputContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInputContent>, string>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DecisionInputContent? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInputContent>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.Question>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Question? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateDecisionResponse? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.Answer>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Usage? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PromptFeedback? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateEnvironmentRequest? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Source? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvVar? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateEnvironmentRequestMode? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateModelInteraction? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Model? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GenerationConfig? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateModelInteractionStatus? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateVoiceRequest? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Voice? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateWebhookRequest? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Webhook? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Credential? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialType? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialStatus? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialCreateParams? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentVariableConfig? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBearerConfig? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OAuth2Config? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialUpdateParams? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBearerUpdateConfig? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OAuth2UpdateConfig? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.NoulCriteria? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminator? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminatorType? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThinkingSummaries? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeepResearchAgentConfigVisualization? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeleteVoiceResponse? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MediaResolution? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DocumentMediaProcessing?, global::Google.Gemini.NextGen.DocumentContentProcessing?>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentMediaProcessing? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentContentProcessing? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentContentMimeType? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentDelta? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentDeltaMimeType? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentStaticMediaProcessing? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PageProcessingOptions? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpreadsheetProcessingOptions? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EgressRule? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Empty? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Environment? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentStatus? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentNetwork?>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetwork? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentMode? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentConfigNetwork?>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentConfigNetwork? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentConfigMode? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentFile? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentFileType? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.EgressRule>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.EgressRule>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.InjectionLocation?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation>>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InjectionLocation? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Error? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ErrorEvent? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearch? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchCallDelta? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchCallStep? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchResult? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchResultDelta? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FileSearchResult>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchResultStep? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionCallStep? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionResultDelta? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AudioContent, global::Google.Gemini.NextGen.DocumentContent, global::Google.Gemini.NextGen.Function, global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent, global::Google.Gemini.NextGen.VideoContent>>, object, string>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AudioContent, global::Google.Gemini.NextGen.DocumentContent, global::Google.Gemini.NextGen.Function, global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent, global::Google.Gemini.NextGen.VideoContent>>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AudioContent, global::Google.Gemini.NextGen.DocumentContent, global::Google.Gemini.NextGen.Function, global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent, global::Google.Gemini.NextGen.VideoContent>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionResultStep? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ToolChoiceConfig, global::Google.Gemini.NextGen.GenerationConfigToolChoice?>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ToolChoiceConfig? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GenerationConfigToolChoice? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThinkingLevel? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageConfig? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoConfig? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionConfig? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.SpeakerConfig, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig>>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeakerConfig? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeechConfig? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetEnvironmentFilesResponse? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.EnvironmentFile>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMaps? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallArguments? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallDelta? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallStep? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResult? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Places>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Places? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultDelta? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResult>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResult2? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResultPlaces>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultPlaces? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ReviewSnippet>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ReviewSnippet? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultStep? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResult2>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchSearchType>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchSearchType? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallArguments? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallDelta? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallStep? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallStepSearchType? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResult? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResultDelta? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchResult>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResultStep? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GroundingToolCount? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GroundingToolCountType? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HarmCategory? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBody? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageContentMimeType? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageDelta? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageDeltaMimeType? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormat? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatMimeType? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatDelivery? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatAspectRatio? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatImageSize? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Interaction? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatus? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Step? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Error>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionCompletedEvent? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSseEventInteraction? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionCreatedEvent? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSSEEvent? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatusUpdate? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDelta? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepStart? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepStop? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSseEventInteractionStatus? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSSEStreamEvent? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatusUpdateStatus? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListAgentsResponse? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Agent>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListCredentialsResponse? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Credential>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListEnvironmentsResponse? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Environment>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListTriggerExecutionsResponse? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.TriggerExecution>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerExecution? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListTriggersResponse? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Trigger>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Trigger? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListVoicesResponse? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Voice>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListWebhooksResponse? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Webhook>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowedTools>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.McpServerToolCallDelta? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.McpServerToolCallStep? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.McpServerToolResultDelta? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.McpServerToolResultStep? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MediaProcessing? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StaticMediaProcessing? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ModalityTokens? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ModelOutputStep? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.NoulQuestion? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.PageProcessingOptionsContentLayer>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PageProcessingOptionsContentLayer? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PingWebhookRequest? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PingWebhookResponse? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Pitch? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingCallDelta? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingCallStep? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingResultDelta? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingResultStep? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PromptFeedbackBlockReason? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PromptedVoice? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ScoreQuestion? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ReplicatedVoice? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextResponseFormat? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormat? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RotateSigningSecretRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RotateSigningSecretResponse? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RunTriggerRequest? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySettingThreshold? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySettingMethod? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SigningSecret? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SmartTranscriptionMode? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SourceType? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeakerConfigTextNormalization? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpreadsheetProcessingOptionsContentLayer>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpreadsheetProcessingOptionsContentLayer? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.StaticMediaProcessingContentLayer>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StaticMediaProcessingContentLayer? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtStep? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ToolSearchCallStep? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ToolSearchResultStep? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallStep? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultStep? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UserInputStep? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDeltaData? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDeltaMetadata? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextAnnotationDelta? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextDelta? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSignatureDelta? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSummaryDelta? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ToolSearchCallDelta? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ToolSearchResultDelta? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallDelta? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultDelta? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoDelta? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Annotation>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextResponseFormatMimeType? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSummaryContent? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ToolSearch? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ToolSearchExecution? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ToolSearchCallStepArguments? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Function>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.TranscriptionMode?, global::Google.Gemini.NextGen.TranscriptionConfigMode?>? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionMode? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionConfigMode? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VerbatimTranscriptionMode? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerStatus? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerExecutionStatus? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerUpdate? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerUpdateStatus? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UpdateTriggerRequest? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UpdateWebhookRequest? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookUpdate? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UploadEnvironmentFileRequest? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UploadEnvironmentFileResponse? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallArguments? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResult? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultStatus? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.URLContextResult>? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GroundingToolCount>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoConfigTask? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.MediaProcessing?, global::Google.Gemini.NextGen.VideoContentProcessing?>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContentProcessing? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContentMimeType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoDeltaMimeType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatDelivery? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatAspectRatio? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatResolution? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VoiceType? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SigningSecret>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookState? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookUpdateState? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.CreateAgentInteraction, global::Google.Gemini.NextGen.CreateModelInteraction>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListEnvironmentsMode? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateInteractionResponse? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeleteInteractionResponse? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetInteractionByIdResponse? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CancelInteractionByIdResponse? Type358 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AgentTool>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInstructionContent?, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.DecisionInstructionContent>, string>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.DecisionInstructionContent>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Content>, string>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Content>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Tool>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ResponseModality>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ResponseFormat?, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ResponseFormat>>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ResponseFormat>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SafetySetting>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInputContent?, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.DecisionInputContent>, string>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.DecisionInputContent>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Source>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::Google.Gemini.NextGen.EgressRule>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.EgressRule>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.InjectionLocation?, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.InjectionLocation>>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.InjectionLocation>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.FileSearchResult>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AudioContent, global::Google.Gemini.NextGen.DocumentContent, global::Google.Gemini.NextGen.Function, global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent, global::Google.Gemini.NextGen.VideoContent>>, object, string>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AudioContent, global::Google.Gemini.NextGen.DocumentContent, global::Google.Gemini.NextGen.Function, global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent, global::Google.Gemini.NextGen.VideoContent>>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.SpeakerConfig, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SpeechConfig>>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SpeechConfig>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.EnvironmentFile>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Places>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleMapsResult>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleMapsResultPlaces>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ReviewSnippet>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleMapsResult2>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleSearchSearchType>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleSearchResult>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Step>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Error>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Agent>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Credential>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Environment>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.TriggerExecution>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Trigger>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Voice>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Webhook>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AllowedTools>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.PageProcessingOptionsContentLayer>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SpreadsheetProcessingOptionsContentLayer>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.StaticMediaProcessingContentLayer>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Annotation>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Function>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.URLContextResult>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ModalityTokens>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GroundingToolCount>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SigningSecret>? ListType51 { get; set; }
    }
}