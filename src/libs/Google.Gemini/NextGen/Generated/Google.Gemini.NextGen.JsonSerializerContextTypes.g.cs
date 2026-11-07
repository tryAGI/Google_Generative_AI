
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
        public object? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ArgumentsDelta? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioContent? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioContentMimeType? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioData? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioDelta? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioDeltaMimeType? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormat? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormatMimeType? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormatDelivery? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallArguments? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallArgumentsLanguage? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallDelta? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallStep? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallArguments2? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallArgumentsLanguage2? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionResultDelta? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionResultStep? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>, string>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Content? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUse? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUseEnvironment? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentContent? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageContent? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextContent? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContent? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateAgentInteraction? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionsInput? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AntigravityAgentConfig, global::Google.Gemini.NextGen.DeepResearchAgentConfig, global::Google.Gemini.NextGen.DynamicAgentConfig>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeepResearchAgentConfig? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DynamicAgentConfig? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateAgentInteractionStatus? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Tool>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Tool? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseModality>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ResponseModality? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ResponseFormat4?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ResponseFormat4? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ServiceTier? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookConfig? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SafetySetting>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySetting? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateEnvironmentRequest? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Source? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateModelInteraction? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Model? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GenerationConfig? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateModelInteractionStatus? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateVoiceRequest? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Voice? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateWebhookRequest? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Webhook? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Credential? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialType? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialStatus? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialCreateParams? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentVariableConfig? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBearerConfig? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OAuth2Config? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialUpdateParams? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBearerUpdateConfig? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OAuth2UpdateConfig? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThinkingSummaries? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeepResearchAgentConfigVisualization? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeleteVoiceResponse? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentContentMimeType? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentDelta? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentDeltaMimeType? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EgressRule? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Empty? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvVar? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Environment3? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentStatus? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentNetwork?>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetwork? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentConfigNetwork?>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentConfigNetwork? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentFile? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentFileType? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.EgressRule>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.EgressRule>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.InjectionLocation3?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation3>>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InjectionLocation3? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation3>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Error? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ErrorEvent? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearch? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchCallDelta? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchCallStep? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchResult? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchResultDelta? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FileSearchResult>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchResultStep? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionCallStep? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionResultDelta? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionResultStep? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ToolChoiceConfig, global::Google.Gemini.NextGen.GenerationConfigToolChoice?>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ToolChoiceConfig? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GenerationConfigToolChoice? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThinkingLevel? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageConfig? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoConfig? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionConfig? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.SpeakerConfig, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig>>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeakerConfig? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeechConfig? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetEnvironmentFilesResponse? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.EnvironmentFile>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMaps? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallArguments? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallDelta? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallStep? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallArguments2? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResult? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Places>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Places? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultDelta? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResult>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResult2? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResultPlaces>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultPlaces? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ReviewSnippet>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ReviewSnippet? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultStep? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResult2>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchSearchType>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchSearchType? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallArguments? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallDelta? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallStep? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallArguments2? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallStepSearchType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResult? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResultDelta? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchResult>? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResult2? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResultStep? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchResult2>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GroundingToolCount? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GroundingToolCountType? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HarmCategory? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBody? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MediaResolution? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageContentMimeType? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageDelta? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageDeltaMimeType? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormat? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatMimeType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatDelivery? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatAspectRatio? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatImageSize? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Interaction? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatus? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Step? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Usage? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Error>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionCompletedEvent? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSseEventInteraction? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionCreatedEvent? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSSEEvent? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatusUpdate? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDelta? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepStart? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepStop? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSseEventInteractionStatus? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSSEStreamEvent? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatusUpdateStatus? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListAgentsResponse? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Agent>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListCredentialsResponse? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Credential>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListEnvironmentsResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Environment3>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListTriggerExecutionsResponse? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.TriggerExecution>? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerExecution? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListTriggersResponse? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Trigger>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Trigger? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListVoicesResponse? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Voice>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListWebhooksResponse? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Webhook>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowedTools>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.McpServerToolCallDelta? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.McpServerToolCallStep? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.McpServerToolResultDelta? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.McpServerToolResultStep? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MediaProcessing? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StaticMediaProcessing? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ModalityTokens? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ModelOutputStep? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PingWebhookRequest? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PingWebhookResponse? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Pitch? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingCallDelta? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingCallStep? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingResultDelta? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingResultStep? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PromptedVoice? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ReplicatedVoice? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextResponseFormat? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormat? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RotateSigningSecretRequest? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RotateSigningSecretResponse? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RunTriggerRequest? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySettingThreshold? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySettingMethod? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SigningSecret? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SmartTranscriptionMode? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SourceType? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtStep? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallStep? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultStep? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UserInputStep? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDeltaData? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDeltaMetadata? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextAnnotationDelta? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextDelta? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSignatureDelta? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSummaryDelta? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallDelta? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultDelta? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoDelta? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Annotation>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextResponseFormatMimeType? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSummaryContent? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.TranscriptionMode?, global::Google.Gemini.NextGen.TranscriptionConfigMode?>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionMode? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionConfigMode? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VerbatimTranscriptionMode? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerStatus? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerExecutionStatus? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerUpdate? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerUpdateStatus? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UpdateTriggerRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UpdateWebhookRequest? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookUpdate? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UploadEnvironmentFileRequest? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UploadEnvironmentFileResponse? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallArguments? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResult? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultStatus? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.URLContextResult>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GroundingToolCount>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoConfigTask? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.MediaProcessing?, global::Google.Gemini.NextGen.VideoContentProcessing?>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContentProcessing? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContentMimeType? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoDeltaMimeType? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatDelivery? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatAspectRatio? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatResolution? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VoiceType? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SigningSecret>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookState? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookUpdateState? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.CreateAgentInteraction, global::Google.Gemini.NextGen.CreateModelInteraction>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateInteractionResponse? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateInteractionResponse2? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeleteInteractionResponse? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeleteInteractionResponse2? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetInteractionByIdResponse? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetInteractionByIdResponse2? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CancelInteractionByIdResponse? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CancelInteractionByIdResponse2? Type315 { get; set; }

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
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Content>, string>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Content>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Tool>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ResponseModality>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ResponseFormat4?, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ResponseFormat4>>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ResponseFormat4>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SafetySetting>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Source>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::Google.Gemini.NextGen.EgressRule>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.EgressRule>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.InjectionLocation3?, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.InjectionLocation3>>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.InjectionLocation3>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.FileSearchResult>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.SpeakerConfig, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SpeechConfig>>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SpeechConfig>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.EnvironmentFile>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Places>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleMapsResult>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleMapsResultPlaces>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ReviewSnippet>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleMapsResult2>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleSearchSearchType>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleSearchResult>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleSearchResult2>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Step>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Error>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Agent>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Credential>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Environment3>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.TriggerExecution>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Trigger>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Voice>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Webhook>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AllowedTools>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Annotation>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.URLContextResult>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ModalityTokens>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GroundingToolCount>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SigningSecret>? ListType44 { get; set; }
    }
}