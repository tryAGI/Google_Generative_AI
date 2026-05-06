
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Tuned model as a source for training a new model.
    /// </summary>
    public sealed partial class TunedModelSource
    {
        /// <summary>
        /// Output only. The name of the base `Model` this `TunedModel` was tuned from. Example: `models/gemini-1.5-flash-001`<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseModel")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// Immutable. The name of the `TunedModel` to use as the starting point for training the new model. Example: `tunedModels/my-tuned-model`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tunedModel")]
        public string? TunedModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TunedModelSource" /> class.
        /// </summary>
        /// <param name="baseModel">
        /// Output only. The name of the base `Model` this `TunedModel` was tuned from. Example: `models/gemini-1.5-flash-001`<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tunedModel">
        /// Immutable. The name of the `TunedModel` to use as the starting point for training the new model. Example: `tunedModels/my-tuned-model`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TunedModelSource(
            string? baseModel,
            string? tunedModel)
        {
            this.BaseModel = baseModel;
            this.TunedModel = tunedModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TunedModelSource" /> class.
        /// </summary>
        public TunedModelSource()
        {
        }
    }
}