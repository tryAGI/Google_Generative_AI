
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
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.Environment3, string>? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Environment3? Type4 { get; set; }
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
        public bool? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionsInput? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ResponseFormat4?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ResponseFormat4? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseModality>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ResponseModality? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SafetySetting>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySetting? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ServiceTier? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Tool>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Tool? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookConfig? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeExecution? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Function? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearch? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServer? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContext? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AllowedTools? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AllowedToolsMode? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Annotation? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileCitation? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PlaceCitation? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeechAnnotation? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLCitation? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WordInfo? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ArgumentsDelta? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioContent? Type44 { get; set; }
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
        public global::Google.Gemini.NextGen.AudioResponseFormatDelivery? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormatMimeType? Type52 { get; set; }
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
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUseDisabledSafetyPolicie? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ComputerUseEnvironment? Type67 { get; set; }
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
        public global::System.DateTime? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialStatus? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialType? Type86 { get; set; }
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
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>, string>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Google.Gemini.NextGen.EnvVar>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlist, global::Google.Gemini.NextGen.EnvironmentNetwork2?>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetwork2? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentFile? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentFileType? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>, global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist?>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowlistEntry>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistAllowlist? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.InjectionLocation3?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation3>>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InjectionLocation3? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation3>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Error? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ErrorEvent? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ExaAISearchConfig? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileContent? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearch? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchCallDelta? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchCallStep? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchResult? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchResultDelta? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FileSearchResult>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileSearchResultStep? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Filter? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FindRequestMode? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FileContent>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionCallStep? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionResultDelta? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>, object, string>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ImageContent, global::Google.Gemini.NextGen.TextContent>? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FunctionResultStep? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GenerationConfig? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageConfig? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.SpeakerConfig, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig2>>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeakerConfig? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SpeechConfig2>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeechConfig2? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThinkingLevel? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ToolChoiceConfig, global::Google.Gemini.NextGen.GenerationConfigToolChoice?>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ToolChoiceConfig? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GenerationConfigToolChoice? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionConfig? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoConfig? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetEnvironmentFilesResponse? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.EnvironmentFile>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetInteractionRequest? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMaps? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallArguments? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallDelta? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallStep? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsCallArguments2? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResult? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Places>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Places? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultDelta? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResult>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResult2? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResultPlaces>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultPlaces? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ReviewSnippet>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ReviewSnippet? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleMapsResultStep? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleMapsResult2>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchSearchType>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchSearchType? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallArguments? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallDelta? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallStep? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallArguments2? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchCallStepSearchType? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResult? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResultDelta? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchResult>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResult2? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GoogleSearchResultStep? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GoogleSearchResult2>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GroundingToolCount? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GroundingToolCountType? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HarmCategory? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBody? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HybridSearch? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageConfigAspectRatio? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageConfigImageSize? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageContentMimeType? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MediaResolution? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageDelta? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageDeltaMimeType? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormat? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatAspectRatio? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatDelivery? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatImageSize? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormatMimeType? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Interaction? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Error>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Model? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatus? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Step? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Usage? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionCompletedEvent? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSseEventInteraction? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionCreatedEvent? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSseEventInteractionStatus? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSSEStreamEvent? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionSSEEvent? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatusUpdate? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDelta? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepStart? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepStop? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.InteractionStatusUpdateStatus? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AgentListResponse? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Agent>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CredentialListResponse? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Credential>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListEnvironmentsResponse? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Environment2>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListTriggerExecutionsResponse? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.TriggerExecution>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerExecution? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListTriggersResponse? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Trigger>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Trigger? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ListVoicesResponse? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Voice>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookListResponse? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Webhook>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.AllowedTools>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServerToolCallDelta? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServerToolCallStep? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServerToolResultDelta? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MCPServerToolResultStep? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.MediaProcessing? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StaticMediaProcessing? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ModalityTokens? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateModelInteraction? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateModelInteractionStatus? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ModelOutputStep? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Status? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ParallelAISearchConfig? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PingWebhookRequest? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookPingResponse? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Pitch? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingCallDelta? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingCallStep? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingResultDelta? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ProcessingResultStep? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PromptedVoice? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RagResource? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RagRetrievalConfig? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.Ranking? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RagStoreConfig? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.RagResource>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RankService? Type267 { get; set; }
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
        public global::Google.Gemini.NextGen.Retrieval? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.RetrievalRetrievalType>? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalRetrievalType? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VertexAISearchConfig? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalCallDelta? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalCallArguments? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalCallDeltaRetrievalType? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalCallStep? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalCallStepRetrievalType? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalResultDelta? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RetrievalResultStep? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RotateSigningSecretRequest? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RotateSigningSecretRequestRevocationBehavior? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookRotateSigningSecretResponse? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.RunTriggerRequest? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySettingMethod? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SafetySettingThreshold? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SigningSecret? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SmartTranscriptionMode? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SourceType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtStep? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallStep? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultStep? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UserInputStep? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDeltaData? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StepDeltaMetadata? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextAnnotationDelta? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextDelta? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSignatureDelta? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSummaryDelta? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallDelta? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultDelta? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoDelta? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Annotation>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextResponseFormatMimeType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ThoughtSummaryContent? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ThoughtSummaryContent>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.TranscriptionMode?, global::Google.Gemini.NextGen.TranscriptionConfigMode?>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionMode? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TranscriptionConfigMode? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VerbatimTranscriptionMode? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerStatus? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerCreateParams? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerExecutionStatus? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerUpdate? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TriggerUpdateStatus? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UpdateTriggerRequest? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UpdateWebhookRequest? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookUpdate? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UploadEnvironmentFileRequest? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UploadEnvironmentFileResponse? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextCallArguments? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UrlContextCallStepArguments? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResult? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLContextResultStatus? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.URLContextResult>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UrlContextResultItem? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.UrlContextResultItemStatus? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ModalityTokens>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.GroundingToolCount>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoConfigTask? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContentMimeType? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.MediaProcessing?, global::Google.Gemini.NextGen.VideoContentProcessing?>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContentProcessing? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoDeltaMimeType? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatAspectRatio? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatDelivery? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormatResolution? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VoiceType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SigningSecret>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookState? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.WebhookSubscribedEvent>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookSubscribedEvent? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookUpdateState? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.CreateAgentInteraction, global::Google.Gemini.NextGen.CreateModelInteraction>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateInteractionResponse? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CreateInteractionResponse2? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeleteInteractionResponse? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeleteInteractionResponse2? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetInteractionByIdResponse? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.GetInteractionByIdResponse2? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CancelInteractionByIdResponse? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CancelInteractionByIdResponse2? Type356 { get; set; }

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
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.ResponseModality>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SafetySetting>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Tool>? ListType5 { get; set; }
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
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Error>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.Step>? ListType32 { get; set; }
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
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.SigningSecret>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.WebhookSubscribedEvent>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Google.Gemini.NextGen.WebhookUpdateSubscribedEvent>? ListType51 { get; set; }
    }
}