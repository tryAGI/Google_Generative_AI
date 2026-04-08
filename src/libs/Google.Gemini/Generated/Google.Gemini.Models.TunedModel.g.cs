
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A fine-tuned model created using ModelService.CreateTunedModel.
    /// </summary>
    public sealed partial class TunedModel
    {
        /// <summary>
        /// Optional. Controls the randomness of the output. Values can range over `[0.0,1.0]`, inclusive. A value closer to `1.0` will produce responses that are more varied, while a value closer to `0.0` will typically result in less surprising responses from the model. This value specifies default to be the one used by the base model while creating the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Tuned model as a source for training a new model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tunedModelSource")]
        public global::Google.Gemini.TunedModelSource? TunedModelSource { get; set; }

        /// <summary>
        /// Output only. The state of the tuned model.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.TunedModelStateJsonConverter))]
        public global::Google.Gemini.TunedModelState? State { get; set; }

        /// <summary>
        /// Optional. List of project numbers that have read access to the tuned model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readerProjectNumbers")]
        public global::System.Collections.Generic.IList<string>? ReaderProjectNumbers { get; set; }

        /// <summary>
        /// Immutable. The name of the `Model` to tune. Example: `models/gemini-1.5-flash-001`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseModel")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// Optional. For Top-k sampling. Top-k sampling considers the set of `top_k` most probable tokens. This value specifies default to be used by the backend while making the call to the model. This value specifies default to be the one used by the base model while creating the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public int? TopK { get; set; }

        /// <summary>
        /// Output only. The timestamp when this model was updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// Output only. The timestamp when this model was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// Optional. The name to display for this model in user interfaces. The display name must be up to 40 characters including spaces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Optional. A short description of this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Output only. The tuned model name. A unique name will be generated on create. Example: `tunedModels/az2mb0bpw6i` If display_name is set on create, the id portion of the name will be set by concatenating the words of the display_name with hyphens and adding a random portion for uniqueness. Example: * display_name = `Sentence Translator` * name = `tunedModels/sentence-translator-u3b7m`<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Tuning tasks that create tuned models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tuningTask")]
        public global::Google.Gemini.TuningTask? TuningTask { get; set; }

        /// <summary>
        /// Optional. For Nucleus sampling. Nucleus sampling considers the smallest set of tokens whose probability sum is at least `top_p`. This value specifies default to be the one used by the base model while creating the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topP")]
        public float? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TunedModel" /> class.
        /// </summary>
        /// <param name="temperature">
        /// Optional. Controls the randomness of the output. Values can range over `[0.0,1.0]`, inclusive. A value closer to `1.0` will produce responses that are more varied, while a value closer to `0.0` will typically result in less surprising responses from the model. This value specifies default to be the one used by the base model while creating the model.
        /// </param>
        /// <param name="tunedModelSource">
        /// Tuned model as a source for training a new model.
        /// </param>
        /// <param name="state">
        /// Output only. The state of the tuned model.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="readerProjectNumbers">
        /// Optional. List of project numbers that have read access to the tuned model.
        /// </param>
        /// <param name="baseModel">
        /// Immutable. The name of the `Model` to tune. Example: `models/gemini-1.5-flash-001`
        /// </param>
        /// <param name="topK">
        /// Optional. For Top-k sampling. Top-k sampling considers the set of `top_k` most probable tokens. This value specifies default to be used by the backend while making the call to the model. This value specifies default to be the one used by the base model while creating the model.
        /// </param>
        /// <param name="updateTime">
        /// Output only. The timestamp when this model was updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Output only. The timestamp when this model was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// Optional. The name to display for this model in user interfaces. The display name must be up to 40 characters including spaces.
        /// </param>
        /// <param name="description">
        /// Optional. A short description of this model.
        /// </param>
        /// <param name="name">
        /// Output only. The tuned model name. A unique name will be generated on create. Example: `tunedModels/az2mb0bpw6i` If display_name is set on create, the id portion of the name will be set by concatenating the words of the display_name with hyphens and adding a random portion for uniqueness. Example: * display_name = `Sentence Translator` * name = `tunedModels/sentence-translator-u3b7m`<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tuningTask">
        /// Tuning tasks that create tuned models.
        /// </param>
        /// <param name="topP">
        /// Optional. For Nucleus sampling. Nucleus sampling considers the smallest set of tokens whose probability sum is at least `top_p`. This value specifies default to be the one used by the base model while creating the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TunedModel(
            float? temperature,
            global::Google.Gemini.TunedModelSource? tunedModelSource,
            global::Google.Gemini.TunedModelState? state,
            global::System.Collections.Generic.IList<string>? readerProjectNumbers,
            string? baseModel,
            int? topK,
            string? updateTime,
            string? createTime,
            string? displayName,
            string? description,
            string? name,
            global::Google.Gemini.TuningTask? tuningTask,
            float? topP)
        {
            this.Temperature = temperature;
            this.TunedModelSource = tunedModelSource;
            this.State = state;
            this.ReaderProjectNumbers = readerProjectNumbers;
            this.BaseModel = baseModel;
            this.TopK = topK;
            this.UpdateTime = updateTime;
            this.CreateTime = createTime;
            this.DisplayName = displayName;
            this.Description = description;
            this.Name = name;
            this.TuningTask = tuningTask;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TunedModel" /> class.
        /// </summary>
        public TunedModel()
        {
        }
    }
}