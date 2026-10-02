
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The Interaction resource.<br/>
    /// Example: {"created":"2025-12-04T15:01:45Z","id":"v1_ChdXS0l4YWZXTk9xbk0xZThQczhEcmlROBIXV0tJeGFmV05PcW5NMWU4UHM4RHJpUTg","model":"gemini-3.6-flash","object":"interaction","status":"completed","steps":[{"type":"model_output","content":[{"type":"text","text":"Hello! I\u0027m doing well, functioning as expected. Thank you for asking! How are you doing today?"}]}],"updated":"2025-12-04T15:01:45Z","usage":{"input_tokens_by_modality":[{"modality":"text","tokens":7}],"total_cached_tokens":0,"total_input_tokens":7,"total_output_tokens":23,"total_thought_tokens":49,"total_tokens":79,"total_tool_use_tokens":0}}
    /// </summary>
    public sealed partial class Interaction
    {
        /// <summary>
        /// The agent to interact with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.AgentOptionJsonConverter))]
        public global::Google.Gemini.NextGen.AgentOption? Agent { get; set; }

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
        /// The name of the cached content used as context to serve the prediction. Note: only used in explicit caching, where users can have control over caching (e.g. what content to cache) and enjoy guaranteed cost savings. Format: cachedContents/{cachedContent}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_content")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? CachedContent { get; set; }

        /// <summary>
        /// Required. Output only. The time at which the response was created in ISO 8601 format<br/>
        /// (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string? Created { get; set; }

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
        /// Output only. Diagnostic faults / platform errors recorded on the interaction.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Error>? Errors { get; set; }

        /// <summary>
        /// Configuration parameters for model interactions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_config")]
        public global::Google.Gemini.NextGen.GenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        /// Required. Output only. A unique identifier for the interaction completion.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        /// The model that will complete your prompt.\n\nSee [models](https://ai.google.dev/gemini-api/docs/models) for additional details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ModelJsonConverter))]
        public global::Google.Gemini.NextGen.Model? Model { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.InteractionStatusJsonConverter))]
        public global::Google.Gemini.NextGen.InteractionStatus Status { get; set; } = default!;

        /// <summary>
        /// Required. Output only. The steps that make up the interaction, when included in the response.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? Steps { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public string? Updated { get; set; }

        /// <summary>
        /// Statistics on the interaction request's token usage.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Google.Gemini.NextGen.Usage? Usage { get; set; }

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
        /// Initializes a new instance of the <see cref="Interaction" /> class.
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
        /// <param name="created">
        /// Required. Output only. The time at which the response was created in ISO 8601 format<br/>
        /// (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
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
        /// <param name="errors">
        /// Output only. Diagnostic faults / platform errors recorded on the interaction.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="generationConfig">
        /// Configuration parameters for model interactions.
        /// </param>
        /// <param name="id">
        /// Required. Output only. A unique identifier for the interaction completion.<br/>
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
        /// <param name="model">
        /// The model that will complete your prompt.\n\nSee [models](https://ai.google.dev/gemini-api/docs/models) for additional details.
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
        /// <param name="steps">
        /// Required. Output only. The steps that make up the interaction, when included in the response.<br/>
        /// Included only in responses
        /// </param>
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
        /// <param name="updated">
        /// Required. Output only. The time at which the response was last updated in ISO 8601 format<br/>
        /// (YYYY-MM-DDThh:mm:ssZ).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="usage">
        /// Statistics on the interaction request's token usage.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="webhookConfig">
        /// Message for configuring webhook events for a request.
        /// </param>
        /// <param name="status">
        /// Required. Output only. The status of the interaction.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Interaction(
            global::Google.Gemini.NextGen.AgentOption? agent,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.AntigravityAgentConfig, global::Google.Gemini.NextGen.CodeMenderAgentConfig, global::Google.Gemini.NextGen.DeepResearchAgentConfig, global::Google.Gemini.NextGen.DynamicAgentConfig>? agentConfig,
            bool? background,
            string? created,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.Environment3, string>? environment,
            string? environmentId,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Error>? errors,
            global::Google.Gemini.NextGen.GenerationConfig? generationConfig,
            string? id,
            global::Google.Gemini.NextGen.InteractionsInput? input,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            global::Google.Gemini.NextGen.Model? model,
            string? previousInteractionId,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.ResponseFormat4?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.ResponseFormat4>>? responseFormat,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.SafetySetting>? safetySettings,
            global::Google.Gemini.NextGen.ServiceTier? serviceTier,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? steps,
            bool? store,
            bool? stream,
            string? systemInstruction,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Tool>? tools,
            string? updated,
            global::Google.Gemini.NextGen.Usage? usage,
            global::Google.Gemini.NextGen.WebhookConfig? webhookConfig,
            global::Google.Gemini.NextGen.InteractionStatus status = default!)
        {
            this.Agent = agent;
            this.AgentConfig = agentConfig;
            this.Background = background;
            this.Created = created;
            this.Environment = environment;
            this.EnvironmentId = environmentId;
            this.Errors = errors;
            this.GenerationConfig = generationConfig;
            this.Id = id;
            this.Input = input;
            this.Labels = labels;
            this.Model = model;
            this.PreviousInteractionId = previousInteractionId;
            this.ResponseFormat = responseFormat;
            this.SafetySettings = safetySettings;
            this.ServiceTier = serviceTier;
            this.Status = status;
            this.Steps = steps;
            this.Store = store;
            this.Stream = stream;
            this.SystemInstruction = systemInstruction;
            this.Tools = tools;
            this.Updated = updated;
            this.Usage = usage;
            this.WebhookConfig = webhookConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Interaction" /> class.
        /// </summary>
        public Interaction()
        {
        }

    }
}