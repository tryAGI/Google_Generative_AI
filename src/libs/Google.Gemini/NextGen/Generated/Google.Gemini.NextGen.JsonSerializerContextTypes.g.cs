
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
        public global::Google.Gemini.NextGen.AntigravityAgentConfig? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.Environment3, string>? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Environment3? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type4 { get; set; }
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
        public global::Google.Gemini.NextGen.CreateAgentInteraction? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AgentOption? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AntigravityAgentConfig, global::Google.Gemini.NextGen.CodeMenderAgentConfig, global::Google.Gemini.NextGen.DeepResearchAgentConfig, global::Google.Gemini.NextGen.DynamicAgentConfig>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeMenderAgentConfig? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeepResearchAgentConfig? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DynamicAgentConfig? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionsInput? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ResponseFormat4?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ResponseFormat4? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Tool>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Tool? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseModality>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ResponseModality? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ServiceTier? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookConfig? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SafetySetting>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySetting? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecution? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Function? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearch? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServer? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContext? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AllowedTools? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AllowedToolsMode? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Annotation? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileCitation? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PlaceCitation? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeechAnnotation? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLCitation? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WordInfo? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ArgumentsDelta? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioContent? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioContentMimeType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioData? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioDelta? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioDeltaMimeType? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormat? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormatMimeType? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormatDelivery? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallArguments? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallArgumentsLanguage? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallDelta? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallStep? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallArguments2? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionCallArgumentsLanguage2? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionResultDelta? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecutionResultStep? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FindRequest? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FixRequest? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SessionConfig? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUse? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUseEnvironment? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Content? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentContent? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageContent? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextContent? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContent? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateEnvironmentRequest? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork?>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateEnvironmentRequestNetwork? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Source>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Source? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateVoiceRequest? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Voice? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateWebhookRequest? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Webhook? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Credential? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialType? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialStatus? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialCreateParams? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentVariableConfig? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBearerConfig? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OAuth2Config? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialUpdate? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBearerUpdateConfig? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OAuth2UpdateConfig? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThinkingSummaries? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeepResearchAgentConfigVisualization? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeleteVoiceResponse? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentContentMimeType? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentDelta? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentDeltaMimeType? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AllowlistEntry? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Empty? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvVar? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Environment2? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentNetwork?>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetwork? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentStatus? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentNetwork2?>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetwork2? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvVar, string>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentFile? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentFileType? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.InjectionLocation3?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation3>>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InjectionLocation3? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation3>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Error? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ErrorEvent? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ExaAISearchConfig? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileContent? Type124 { get; set; }
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
        public global::Google.Gemini.NextGen.Filter? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FileContent>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FindRequestMode? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionCallStep? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionResultDelta? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionResultStep? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GenerationConfig? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ToolChoiceConfig, global::Google.Gemini.NextGen.GenerationConfigToolChoice?>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ToolChoiceConfig? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GenerationConfigToolChoice? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThinkingLevel? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageConfig? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoConfig? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionConfig? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.SpeakerConfig, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig2>>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeakerConfig? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig2>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeechConfig2? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetEnvironmentFilesResponse? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.EnvironmentFile>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetInteractionRequest? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMaps? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallArguments? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallDelta? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallStep? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallArguments2? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResult? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Places>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Places? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultDelta? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResult>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResult2? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResultPlaces>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultPlaces? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ReviewSnippet>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ReviewSnippet? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultStep? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResult2>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchSearchType>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchSearchType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallArguments? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallDelta? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallStep? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallArguments2? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallStepSearchType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResult? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResultDelta? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchResult>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResult2? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResultStep? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchResult2>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GroundingToolCount? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GroundingToolCountType? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HarmCategory? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBody? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HybridSearch? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageConfigAspectRatio? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageConfigImageSize? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MediaResolution? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageContentMimeType? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageDelta? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageDeltaMimeType? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormat? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatMimeType? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatDelivery? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatAspectRatio? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatImageSize? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Interaction? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatus? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Step? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Model? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Usage? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Error>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionCompletedEvent? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSseEventInteraction? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionCreatedEvent? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSseEventInteractionStatus? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSSEStreamEvent? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSSEEvent? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatusUpdate? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDelta? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepStart? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepStop? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatusUpdateStatus? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AgentListResponse? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Agent>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialListResponse? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Credential>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListEnvironmentsResponse? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Environment2>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListTriggerExecutionsResponse? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.TriggerExecution>? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerExecution? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListTriggersResponse? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Trigger>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Trigger? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListVoicesResponse? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Voice>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookListResponse? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Webhook>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowedTools>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServerToolCallDelta? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServerToolCallStep? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServerToolResultDelta? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServerToolResultStep? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MediaProcessing? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StaticMediaProcessing? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ModalityTokens? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateModelInteraction? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateModelInteractionStatus? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ModelOutputStep? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Status? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ParallelAISearchConfig? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PingWebhookRequest? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookPingResponse? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Pitch? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingCallDelta? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingCallStep? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingResultDelta? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingResultStep? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PromptedVoice? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RagResource? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RagRetrievalConfig? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Ranking? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RagStoreConfig? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.RagResource>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RankService? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ReplicatedVoice? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextResponseFormat? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormat? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Retrieval? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.RetrievalRetrievalType>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalRetrievalType? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VertexAISearchConfig? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalCallDelta? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalCallArguments? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalCallDeltaRetrievalType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalCallStep? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalCallStepRetrievalType? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalResultDelta? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalResultStep? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RotateSigningSecretRequest? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookRotateSigningSecretResponse? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RunTriggerRequest? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySettingThreshold? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySettingMethod? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SigningSecret? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SmartTranscriptionMode? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SourceType? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtStep? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallStep? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultStep? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UserInputStep? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDeltaData? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDeltaMetadata? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextAnnotationDelta? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextDelta? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSignatureDelta? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSummaryDelta? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallDelta? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultDelta? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoDelta? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Annotation>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextResponseFormatMimeType? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSummaryContent? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ThoughtSummaryContent>? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.TranscriptionMode?, global::Google.Gemini.NextGen.TranscriptionConfigMode?>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionMode? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionConfigMode? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VerbatimTranscriptionMode? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerStatus? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerCreateParams? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerExecutionStatus? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerUpdate? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerUpdateStatus? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UpdateTriggerRequest? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UpdateWebhookRequest? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookUpdate? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UploadEnvironmentFileRequest? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UploadEnvironmentFileResponse? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallArguments? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UrlContextCallStepArguments? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResult? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultStatus? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.URLContextResult>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UrlContextResultItem? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UrlContextResultItemStatus? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GroundingToolCount>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoConfigTask? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.MediaProcessing?, global::Google.Gemini.NextGen.VideoContentProcessing?>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContentProcessing? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContentMimeType? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoDeltaMimeType? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatDelivery? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatAspectRatio? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatResolution? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VoiceType? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.WebhookSubscribedEvent>? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookSubscribedEvent? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SigningSecret>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookState? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent>? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookUpdateState? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.CreateAgentInteraction, global::Google.Gemini.NextGen.CreateModelInteraction>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateInteractionResponse? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateInteractionResponse2? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeleteInteractionResponse? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeleteInteractionResponse2? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetInteractionByIdResponse? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetInteractionByIdResponse2? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CancelInteractionByIdResponse? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CancelInteractionByIdResponse2? Type355 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AgentTool>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ResponseFormat4?, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ResponseFormat4>>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ResponseFormat4>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Tool>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ResponseModality>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SafetySetting>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Source>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>, global::System.Collections.Generic.Dictionary<string, string>>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AllowlistEntry>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AllowlistEntry>? ListType12 { get; set; }
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
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.FileContent>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.List<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.SpeakerConfig, global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SpeechConfig2>>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SpeechConfig2>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.EnvironmentFile>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Places>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleMapsResult>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleMapsResultPlaces>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ReviewSnippet>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleMapsResult2>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleSearchSearchType>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleSearchResult>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GoogleSearchResult2>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Step>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Error>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Content>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Agent>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Credential>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Environment2>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.TriggerExecution>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Trigger>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Voice>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Webhook>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.AllowedTools>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.RagResource>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.RetrievalRetrievalType>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Annotation>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ThoughtSummaryContent>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.URLContextResult>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ModalityTokens>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.GroundingToolCount>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.WebhookSubscribedEvent>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SigningSecret>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent>? ListType51 { get; set; }
    }
}