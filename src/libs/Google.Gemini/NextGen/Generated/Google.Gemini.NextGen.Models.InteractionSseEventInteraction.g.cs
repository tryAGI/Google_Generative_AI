
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Partial interaction resource emitted by interaction lifecycle SSE events.<br/>
    /// Streaming lifecycle payloads may omit fields that are only available on<br/>
    /// full non-streaming Interaction responses.
    /// </summary>
    public sealed partial class InteractionSseEventInteraction
    {
        /// <summary>
        /// The agent to interact with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public string? Agent { get; set; }

        /// <summary>
        /// Output only. The time at which the response was created in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string? Created { get; set; }

        /// <summary>
        /// Required. Output only. A unique identifier for the interaction completion.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The model that will complete your prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Output only. The resource type.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.InteractionSseEventInteractionStatusJsonConverter))]
        public global::Google.Gemini.NextGen.InteractionSseEventInteractionStatus Status { get; set; } = default!;

        /// <summary>
        /// Output only. The steps that make up the interaction, if included in this event.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? Steps { get; set; }

        /// <summary>
        /// Output only. The time at which the response was last updated in ISO 8601 format.<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionSseEventInteraction" /> class.
        /// </summary>
        /// <param name="agent">
        /// The agent to interact with.
        /// </param>
        /// <param name="created">
        /// Output only. The time at which the response was created in ISO 8601 format.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="model">
        /// The model that will complete your prompt.
        /// </param>
        /// <param name="object">
        /// Output only. The resource type.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="serviceTier"></param>
        /// <param name="steps">
        /// Output only. The steps that make up the interaction, if included in this event.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updated">
        /// Output only. The time at which the response was last updated in ISO 8601 format.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="usage">
        /// Statistics on the interaction request's token usage.<br/>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InteractionSseEventInteraction(
            string? agent,
            string? created,
            string? model,
            string? @object,
            global::Google.Gemini.NextGen.ServiceTier? serviceTier,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? steps,
            string? updated,
            global::Google.Gemini.NextGen.Usage? usage,
            string id = default!,
            global::Google.Gemini.NextGen.InteractionSseEventInteractionStatus status = default!)
        {
            this.Agent = agent;
            this.Created = created;
            this.Id = id;
            this.Model = model;
            this.Object = @object;
            this.ServiceTier = serviceTier;
            this.Status = status;
            this.Steps = steps;
            this.Updated = updated;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionSseEventInteraction" /> class.
        /// </summary>
        public InteractionSseEventInteraction()
        {
        }

    }
}