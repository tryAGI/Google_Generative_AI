
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Interaction for generating the completion using agents.
    /// </summary>
    public sealed partial class CreateAgentInteraction
    {
        /// <summary>
        /// The agent to interact with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.AgentOptionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Google.Gemini.NextGen.AgentOption Agent { get; set; }

        /// <summary>
        /// Configuration parameters for the agent interaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.AntigravityAgentConfig, global::Google.Gemini.NextGen.CodeMenderAgentConfig, global::Google.Gemini.NextGen.DeepResearchAgentConfig, global::Google.Gemini.NextGen.DynamicAgentConfig>))]
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AntigravityAgentConfig, global::Google.Gemini.NextGen.CodeMenderAgentConfig, global::Google.Gemini.NextGen.DeepResearchAgentConfig, global::Google.Gemini.NextGen.DynamicAgentConfig>? AgentConfig { get; set; }

        /// <summary>
        /// Input only. Whether to run the model interaction in the background.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public bool? Background { get; set; }

        /// <summary>
        /// Required. Output only. The time at which the response was created in ISO 8601 format<br/>
        /// (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string Created { get; set; } = default!;

        /// <summary>
        /// The environment configuration for the interaction. Can be an object<br/>
        /// specifying remote environment sources or a string referencing an existing<br/>
        /// environment ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.Environment3, string>))]
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.Environment3, string>? Environment { get; set; }

        /// <summary>
        /// Output only. The environment ID for the interaction. Only populated if environment<br/>
        /// config is set in the request.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// Required. Output only. A unique identifier for the interaction completion.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The input for the interaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.InteractionsInputJsonConverter))]
        public global::Google.Gemini.NextGen.InteractionsInput? Input { get; set; }

        /// <summary>
        /// The labels with user-defined metadata for the request.<br/>
        /// Label keys and values can be no longer than 63 characters<br/>
        /// (Unicode codepoints) and can only contain lowercase letters, numeric<br/>
        /// characters, underscores, and dashes. International characters are allowed.<br/>
        /// Label values are optional. Label keys must start with a letter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// The ID of the previous interaction, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_interaction_id")]
        public string? PreviousInteractionId { get; set; }

        /// <summary>
        /// Enforces that the generated response is a JSON object that complies with<br/>
        /// the JSON schema specified in this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.ResponseFormat4?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>>))]
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ResponseFormat4?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>>? ResponseFormat { get; set; }

        /// <summary>
        /// The mime type of the response. This is required if response_format is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_mime_type")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ResponseMimeType { get; set; }

        /// <summary>
        /// The requested modalities of the response (TEXT, IMAGE, AUDIO).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_modalities")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseModality>? ResponseModalities { get; set; }

        /// <summary>
        /// Safety settings for the interaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_settings")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SafetySetting>? SafetySettings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ServiceTierJsonConverter))]
        public global::Google.Gemini.NextGen.ServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Required. Output only. The status of the interaction.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.CreateAgentInteractionStatusJsonConverter))]
        public global::Google.Gemini.NextGen.CreateAgentInteractionStatus Status { get; set; } = default!;

        /// <summary>
        /// Input only. Whether to store the response and request for later retrieval.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Input only. Whether the interaction will be streamed.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// System instruction for the interaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_instruction")]
        public string? SystemInstruction { get; set; }

        /// <summary>
        /// A list of tool declarations the model may call during interaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Tool>? Tools { get; set; }

        /// <summary>
        /// Required. Output only. The time at which the response was last updated in ISO 8601 format<br/>
        /// (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public string Updated { get; set; } = default!;

        /// <summary>
        /// Message for configuring webhook events for a request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_config")]
        public global::Google.Gemini.NextGen.WebhookConfig? WebhookConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentInteraction" /> class.
        /// </summary>
        /// <param name="agent">
        /// The agent to interact with.
        /// </param>
        /// <param name="agentConfig">
        /// Configuration parameters for the agent interaction.
        /// </param>
        /// <param name="background">
        /// Input only. Whether to run the model interaction in the background.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="environment">
        /// The environment configuration for the interaction. Can be an object<br/>
        /// specifying remote environment sources or a string referencing an existing<br/>
        /// environment ID.
        /// </param>
        /// <param name="environmentId">
        /// Output only. The environment ID for the interaction. Only populated if environment<br/>
        /// config is set in the request.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="input">
        /// The input for the interaction.
        /// </param>
        /// <param name="labels">
        /// The labels with user-defined metadata for the request.<br/>
        /// Label keys and values can be no longer than 63 characters<br/>
        /// (Unicode codepoints) and can only contain lowercase letters, numeric<br/>
        /// characters, underscores, and dashes. International characters are allowed.<br/>
        /// Label values are optional. Label keys must start with a letter.
        /// </param>
        /// <param name="previousInteractionId">
        /// The ID of the previous interaction, if any.
        /// </param>
        /// <param name="responseFormat">
        /// Enforces that the generated response is a JSON object that complies with<br/>
        /// the JSON schema specified in this field.
        /// </param>
        /// <param name="safetySettings">
        /// Safety settings for the interaction.
        /// </param>
        /// <param name="serviceTier"></param>
        /// <param name="store">
        /// Input only. Whether to store the response and request for later retrieval.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="stream">
        /// Input only. Whether the interaction will be streamed.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="systemInstruction">
        /// System instruction for the interaction.
        /// </param>
        /// <param name="tools">
        /// A list of tool declarations the model may call during interaction.
        /// </param>
        /// <param name="webhookConfig">
        /// Message for configuring webhook events for a request.
        /// </param>
        /// <param name="created">
        /// Required. Output only. The time at which the response was created in ISO 8601 format<br/>
        /// (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Required. Output only. A unique identifier for the interaction completion.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Required. Output only. The status of the interaction.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updated">
        /// Required. Output only. The time at which the response was last updated in ISO 8601 format<br/>
        /// (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentInteraction(
            global::Google.Gemini.NextGen.AgentOption agent,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AntigravityAgentConfig, global::Google.Gemini.NextGen.CodeMenderAgentConfig, global::Google.Gemini.NextGen.DeepResearchAgentConfig, global::Google.Gemini.NextGen.DynamicAgentConfig>? agentConfig,
            bool? background,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.Environment3, string>? environment,
            string? environmentId,
            global::Google.Gemini.NextGen.InteractionsInput? input,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            string? previousInteractionId,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ResponseFormat4?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>>? responseFormat,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SafetySetting>? safetySettings,
            global::Google.Gemini.NextGen.ServiceTier? serviceTier,
            bool? store,
            bool? stream,
            string? systemInstruction,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Tool>? tools,
            global::Google.Gemini.NextGen.WebhookConfig? webhookConfig,
            string created = default!,
            string id = default!,
            global::Google.Gemini.NextGen.CreateAgentInteractionStatus status = default!,
            string updated = default!)
        {
            this.Agent = agent;
            this.AgentConfig = agentConfig;
            this.Background = background;
            this.Created = created;
            this.Environment = environment;
            this.EnvironmentId = environmentId;
            this.Id = id;
            this.Input = input;
            this.Labels = labels;
            this.PreviousInteractionId = previousInteractionId;
            this.ResponseFormat = responseFormat;
            this.SafetySettings = safetySettings;
            this.ServiceTier = serviceTier;
            this.Status = status;
            this.Store = store;
            this.Stream = stream;
            this.SystemInstruction = systemInstruction;
            this.Tools = tools;
            this.Updated = updated;
            this.WebhookConfig = webhookConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentInteraction" /> class.
        /// </summary>
        public CreateAgentInteraction()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateAgentInteraction"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateAgentInteraction FromAgent(global::Google.Gemini.NextGen.AgentOption agent)
        {
            return new CreateAgentInteraction
            {
                Agent = agent,
            };
        }

    }
}