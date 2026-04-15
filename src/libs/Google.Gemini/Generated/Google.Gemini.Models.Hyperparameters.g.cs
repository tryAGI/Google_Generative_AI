
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Hyperparameters controlling the tuning process. Read more at https://ai.google.dev/docs/model_tuning_guidance
    /// </summary>
    public sealed partial class Hyperparameters
    {
        /// <summary>
        /// Immutable. The number of training epochs. An epoch is one pass through the training data. If not set, a default of 5 will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("epochCount")]
        public int? EpochCount { get; set; }

        /// <summary>
        /// Optional. Immutable. The learning rate hyperparameter for tuning. If not set, a default of 0.001 or 0.0002 will be calculated based on the number of training examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learningRate")]
        public float? LearningRate { get; set; }

        /// <summary>
        /// Immutable. The batch size hyperparameter for tuning. If not set, a default of 4 or 16 will be used based on the number of training examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batchSize")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Optional. Immutable. The learning rate multiplier is used to calculate a final learning_rate based on the default (recommended) value. Actual learning rate := learning_rate_multiplier * default learning rate Default learning rate is dependent on base model and dataset size. If not set, a default of 1.0 will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learningRateMultiplier")]
        public float? LearningRateMultiplier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Hyperparameters" /> class.
        /// </summary>
        /// <param name="epochCount">
        /// Immutable. The number of training epochs. An epoch is one pass through the training data. If not set, a default of 5 will be used.
        /// </param>
        /// <param name="learningRate">
        /// Optional. Immutable. The learning rate hyperparameter for tuning. If not set, a default of 0.001 or 0.0002 will be calculated based on the number of training examples.
        /// </param>
        /// <param name="batchSize">
        /// Immutable. The batch size hyperparameter for tuning. If not set, a default of 4 or 16 will be used based on the number of training examples.
        /// </param>
        /// <param name="learningRateMultiplier">
        /// Optional. Immutable. The learning rate multiplier is used to calculate a final learning_rate based on the default (recommended) value. Actual learning rate := learning_rate_multiplier * default learning rate Default learning rate is dependent on base model and dataset size. If not set, a default of 1.0 will be used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Hyperparameters(
            int? epochCount,
            float? learningRate,
            int? batchSize,
            float? learningRateMultiplier)
        {
            this.EpochCount = epochCount;
            this.LearningRate = learningRate;
            this.BatchSize = batchSize;
            this.LearningRateMultiplier = learningRateMultiplier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hyperparameters" /> class.
        /// </summary>
        public Hyperparameters()
        {
        }
    }
}