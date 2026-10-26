
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
        /// Required. Output only. A unique identifier for the interaction completion.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Required. Output only. The status of the interaction.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.InteractionSseEventInteractionStatusJsonConverter))]
        public global::Google.Gemini.NextGen.InteractionSseEventInteractionStatus Status { get; set; } = default!;

        /// <summary>
        /// The model that will complete your prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Output only. The time at which the response was created in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string? Created { get; set; }

        /// <summary>
        /// Output only. The time at which the response was last updated in ISO 8601 format.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public string? Updated { get; set; }

        /// <summary>
        /// Statistics on the interaction request's token usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Google.Gemini.NextGen.Usage? Usage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.ServiceTierJsonConverter))]
        public global::Google.Gemini.NextGen.ServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Output only. The steps that make up the interaction, if included in this event.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? Steps { get; set; }

        /// <summary>
        /// The agent to interact with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public string? Agent { get; set; }

        /// <summary>
        /// Opaque token to resume a long decode.<br/>
        /// Output: set when status is INCOMPLETE and decoding can be resumed.<br/>
        /// Input: pass the latest token back unchanged in CreateInteraction to<br/>
        /// continue decoding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continuation_token")]
        public byte[]? ContinuationToken { get; set; }

        /// <summary>
        /// Output only. The resource type.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionSseEventInteraction" /> class.
        /// </summary>
        /// <param name="model">
        /// The model that will complete your prompt.
        /// </param>
        /// <param name="created">
        /// Output only. The time at which the response was created in ISO 8601 format.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updated">
        /// Output only. The time at which the response was last updated in ISO 8601 format.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="usage">
        /// Statistics on the interaction request's token usage.
        /// </param>
        /// <param name="serviceTier"></param>
        /// <param name="steps">
        /// Output only. The steps that make up the interaction, if included in this event.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="agent">
        /// The agent to interact with.
        /// </param>
        /// <param name="continuationToken">
        /// Opaque token to resume a long decode.<br/>
        /// Output: set when status is INCOMPLETE and decoding can be resumed.<br/>
        /// Input: pass the latest token back unchanged in CreateInteraction to<br/>
        /// continue decoding.
        /// </param>
        /// <param name="object">
        /// Output only. The resource type.<br/>
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
            string? model,
            string? created,
            string? updated,
            global::Google.Gemini.NextGen.Usage? usage,
            global::Google.Gemini.NextGen.ServiceTier? serviceTier,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Step>? steps,
            string? agent,
            byte[]? continuationToken,
            string? @object,
            string id = default!,
            global::Google.Gemini.NextGen.InteractionSseEventInteractionStatus status = default!)
        {
            this.Id = id;
            this.Status = status;
            this.Model = model;
            this.Created = created;
            this.Updated = updated;
            this.Usage = usage;
            this.ServiceTier = serviceTier;
            this.Steps = steps;
            this.Agent = agent;
            this.ContinuationToken = continuationToken;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionSseEventInteraction" /> class.
        /// </summary>
        public InteractionSseEventInteraction()
        {
        }

    }
}