
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
        public global::Google.Gemini.NextGen.AudioContentMimeType? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioData? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioDelta? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioDeltaMimeType? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormat? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormatMimeType? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormatDelivery? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ChoiceQuestion? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInstructionContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInstructionContent>, string>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DecisionInstructionContent? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInstructionContent>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallArguments? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallArgumentsLanguage? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallDelta? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallStep? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionResultDelta? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionResultStep? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>, string>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Content? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUse? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUseEnvironment? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentContent? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageContent? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextContent? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContent? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateAgentInteraction? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionsInput? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AntigravityAgentConfig, global::Google.Gemini.NextGen.DeepResearchAgentConfig, global::Google.Gemini.NextGen.DynamicAgentConfig>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeepResearchAgentConfig? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DynamicAgentConfig? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateAgentInteractionStatus? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Tool>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Tool? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseModality>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ResponseModality? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ResponseFormat?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat>>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ResponseFormat? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ServiceTier? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookConfig? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SafetySetting>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySetting? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateDecisionRequest? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.DecisionInputContent?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInputContent>, string>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DecisionInputContent? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.DecisionInputContent>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.Question>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Question? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateDecisionResponse? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.Answer>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Usage? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PromptFeedback? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateEnvironmentRequest? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Source? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateEnvironmentRequestMode? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateModelInteraction? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Model? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GenerationConfig? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateModelInteractionStatus? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateVoiceRequest? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Voice? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateWebhookRequest? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Webhook? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Credential? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialType? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialStatus? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialCreateParams? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentVariableConfig? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBearerConfig? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OAuth2Config? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialUpdateParams? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBearerUpdateConfig? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OAuth2UpdateConfig? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.NoulCriteria? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminator? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminatorType? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThinkingSummaries? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeepResearchAgentConfigVisualization? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeleteVoiceResponse? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentContentMimeType? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentDelta? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentDeltaMimeType? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EgressRule? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Empty? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvVar? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Environment? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentStatus? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentNetwork?>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetwork? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentMode? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentConfigNetwork?>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentConfigNetwork? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentConfigMode? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentFile? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentFileType? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.EgressRule>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.EgressRule>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.InjectionLocation?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation>>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InjectionLocation? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Error? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ErrorEvent? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearch? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchCallDelta? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchCallStep? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchResult? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchResultDelta? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FileSearchResult>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchResultStep? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionCallStep? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionResultDelta? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionResultStep? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ToolChoiceConfig, global::Google.Gemini.NextGen.GenerationConfigToolChoice?>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ToolChoiceConfig? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GenerationConfigToolChoice? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThinkingLevel? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageConfig? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoConfig? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionConfig? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.SpeakerConfig, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig>>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeakerConfig? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeechConfig? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetEnvironmentFilesResponse? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.EnvironmentFile>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMaps? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallArguments? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallDelta? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallStep? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResult? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Places>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Places? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultDelta? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResult>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResult2? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResultPlaces>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultPlaces? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ReviewSnippet>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ReviewSnippet? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultStep? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResult2>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchSearchType>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchSearchType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallArguments? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallDelta? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallStep? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallStepSearchType? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResult? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResultDelta? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchResult>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResultStep? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GroundingToolCount? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GroundingToolCountType? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HarmCategory? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBody? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MediaResolution? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageContentMimeType? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageDelta? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageDeltaMimeType? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormat? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatMimeType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatDelivery? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatAspectRatio? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatImageSize? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Interaction? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatus? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Step? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Error>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionCompletedEvent? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSseEventInteraction? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionCreatedEvent? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSSEEvent? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatusUpdate? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDelta? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepStart? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepStop? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSseEventInteractionStatus? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSSEStreamEvent? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatusUpdateStatus? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListAgentsResponse? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Agent>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListCredentialsResponse? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Credential>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListEnvironmentsResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Environment>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListTriggerExecutionsResponse? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.TriggerExecution>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerExecution? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListTriggersResponse? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Trigger>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Trigger? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListVoicesResponse? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Voice>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListWebhooksResponse? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Webhook>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowedTools>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.McpServerToolCallDelta? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.McpServerToolCallStep? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.McpServerToolResultDelta? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.McpServerToolResultStep? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MediaProcessing? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StaticMediaProcessing? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ModalityTokens? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ModelOutputStep? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.NoulQuestion? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PingWebhookRequest? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PingWebhookResponse? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Pitch? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingCallDelta? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingCallStep? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingResultDelta? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingResultStep? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PromptFeedbackBlockReason? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PromptedVoice? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ScoreQuestion? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ReplicatedVoice? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextResponseFormat? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormat? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RotateSigningSecretRequest? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RotateSigningSecretResponse? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RunTriggerRequest? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySettingThreshold? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySettingMethod? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SigningSecret? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SmartTranscriptionMode? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SourceType? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtStep? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallStep? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultStep? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UserInputStep? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDeltaData? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDeltaMetadata? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextAnnotationDelta? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextDelta? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSignatureDelta? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSummaryDelta? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallDelta? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultDelta? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoDelta? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Annotation>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextResponseFormatMimeType? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSummaryContent? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.TranscriptionMode?, global::Google.Gemini.NextGen.TranscriptionConfigMode?>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionMode? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionConfigMode? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VerbatimTranscriptionMode? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerStatus? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerExecutionStatus? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerUpdate? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerUpdateStatus? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UpdateTriggerRequest? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UpdateWebhookRequest? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookUpdate? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UploadEnvironmentFileRequest? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UploadEnvironmentFileResponse? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallArguments? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResult? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultStatus? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.URLContextResult>? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GroundingToolCount>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoConfigTask? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.MediaProcessing?, global::Google.Gemini.NextGen.VideoContentProcessing?>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContentProcessing? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContentMimeType? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoDeltaMimeType? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatDelivery? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatAspectRatio? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatResolution? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VoiceType? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SigningSecret>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookState? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookUpdateState? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.CreateAgentInteraction, global::Google.Gemini.NextGen.CreateModelInteraction>? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListEnvironmentsMode? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateInteractionResponse? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeleteInteractionResponse? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetInteractionByIdResponse? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CancelInteractionByIdResponse? Type333 { get; set; }

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
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>? ListType21 { get; set; }
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
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Annotation>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.URLContextResult>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ModalityTokens>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GroundingToolCount>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SigningSecret>? ListType47 { get; set; }
    }
}