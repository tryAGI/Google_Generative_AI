
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Request to generate a completion from the model.
    /// </summary>
    public sealed partial class GenerateContentRequest
    {
        /// <summary>
        /// Required. The content of the current conversation with the model. For single-turn queries, this is a single instance. For multi-turn queries like [chat](https://ai.google.dev/gemini-api/docs/text-generation#chat), this is a repeated field that contains the conversation history and the latest request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Content>? Contents { get; set; }

        /// <summary>
        /// Optional. A list of `Tools` the `Model` may use to generate the next response. A `Tool` is a piece of code that enables the system to interact with external systems to perform an action, or set of actions, outside of knowledge and scope of the `Model`. Supported `Tool`s are `Function` and `code_execution`. Refer to the [Function calling](https://ai.google.dev/gemini-api/docs/function-calling) and the [Code execution](https://ai.google.dev/gemini-api/docs/code-execution) guides to learn more.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.Tool>? Tools { get; set; }

        /// <summary>
        /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content. This will be enforced on the `GenerateContentRequest.contents` and `GenerateContentResponse.candidates`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT, HARM_CATEGORY_CIVIC_INTEGRITY are supported. Refer to the [guide](https://ai.google.dev/gemini-api/docs/safety-settings) for detailed information on available safety settings. Also refer to the [Safety guidance](https://ai.google.dev/gemini-api/docs/safety-guidance) to learn how to incorporate safety considerations in your AI applications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safetySettings")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? SafetySettings { get; set; }

        /// <summary>
        /// Required. The name of the `Model` to use for generating the completion. Format: `models/{model}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The Tool configuration containing parameters for specifying `Tool` use in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolConfig")]
        public global::Google.Gemini.ToolConfig? ToolConfig { get; set; }

        /// <summary>
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemInstruction")]
        public global::Google.Gemini.Content? SystemInstruction { get; set; }

        /// <summary>
        /// Optional. The service tier of the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceTier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.GenerateContentRequestServiceTierJsonConverter))]
        public global::Google.Gemini.GenerateContentRequestServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Optional. Configures the logging behavior for a given request. If set, it takes precedence over the project-level logging config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Configuration options for model generation and outputs. Not all parameters are configurable for every model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generationConfig")]
        public global::Google.Gemini.GenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        /// Optional. The name of the content [cached](https://ai.google.dev/gemini-api/docs/caching) to use as context to serve the prediction. Format: `cachedContents/{cachedContent}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedContent")]
        public string? CachedContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentRequest" /> class.
        /// </summary>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model. For single-turn queries, this is a single instance. For multi-turn queries like [chat](https://ai.google.dev/gemini-api/docs/text-generation#chat), this is a repeated field that contains the conversation history and the latest request.
        /// </param>
        /// <param name="tools">
        /// Optional. A list of `Tools` the `Model` may use to generate the next response. A `Tool` is a piece of code that enables the system to interact with external systems to perform an action, or set of actions, outside of knowledge and scope of the `Model`. Supported `Tool`s are `Function` and `code_execution`. Refer to the [Function calling](https://ai.google.dev/gemini-api/docs/function-calling) and the [Code execution](https://ai.google.dev/gemini-api/docs/code-execution) guides to learn more.
        /// </param>
        /// <param name="safetySettings">
        /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content. This will be enforced on the `GenerateContentRequest.contents` and `GenerateContentResponse.candidates`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT, HARM_CATEGORY_CIVIC_INTEGRITY are supported. Refer to the [guide](https://ai.google.dev/gemini-api/docs/safety-settings) for detailed information on available safety settings. Also refer to the [Safety guidance](https://ai.google.dev/gemini-api/docs/safety-guidance) to learn how to incorporate safety considerations in your AI applications.
        /// </param>
        /// <param name="model">
        /// Required. The name of the `Model` to use for generating the completion. Format: `models/{model}`.
        /// </param>
        /// <param name="toolConfig">
        /// The Tool configuration containing parameters for specifying `Tool` use in the request.
        /// </param>
        /// <param name="systemInstruction">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
        /// <param name="serviceTier">
        /// Optional. The service tier of the request.
        /// </param>
        /// <param name="store">
        /// Optional. Configures the logging behavior for a given request. If set, it takes precedence over the project-level logging config.
        /// </param>
        /// <param name="generationConfig">
        /// Configuration options for model generation and outputs. Not all parameters are configurable for every model.
        /// </param>
        /// <param name="cachedContent">
        /// Optional. The name of the content [cached](https://ai.google.dev/gemini-api/docs/caching) to use as context to serve the prediction. Format: `cachedContents/{cachedContent}`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateContentRequest(
            global::System.Collections.Generic.IList<global::Google.Gemini.Content>? contents,
            global::System.Collections.Generic.IList<global::Google.Gemini.Tool>? tools,
            global::System.Collections.Generic.IList<global::Google.Gemini.SafetySetting>? safetySettings,
            string? model,
            global::Google.Gemini.ToolConfig? toolConfig,
            global::Google.Gemini.Content? systemInstruction,
            global::Google.Gemini.GenerateContentRequestServiceTier? serviceTier,
            bool? store,
            global::Google.Gemini.GenerationConfig? generationConfig,
            string? cachedContent)
        {
            this.Contents = contents;
            this.Tools = tools;
            this.SafetySettings = safetySettings;
            this.Model = model;
            this.ToolConfig = toolConfig;
            this.SystemInstruction = systemInstruction;
            this.ServiceTier = serviceTier;
            this.Store = store;
            this.GenerationConfig = generationConfig;
            this.CachedContent = cachedContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentRequest" /> class.
        /// </summary>
        public GenerateContentRequest()
        {
        }
    }
}