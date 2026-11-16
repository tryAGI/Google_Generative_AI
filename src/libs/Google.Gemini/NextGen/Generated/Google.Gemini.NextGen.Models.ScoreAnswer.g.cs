
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Calibrated result for a `ScoreQuestion`.
    /// </summary>
    public sealed partial class ScoreAnswer
    {
        /// <summary>
        /// Required. Output only. Probability-weighted expected score (`sum_k k * probability_k`).<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double Score { get; set; } = default!;

        /// <summary>
        /// Required. Output only. Closed-world normalized probability in `[0, 1]` for each 0-based level<br/>
        /// index.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("probabilities")]
        public global::System.Collections.Generic.Dictionary<string, double> Probabilities { get; set; } = default!;

        /// <summary>
        /// Required. Output only. Rubric description for each non-empty 0-based level index.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("legend")]
        public global::System.Collections.Generic.Dictionary<string, string> Legend { get; set; } = default!;

        /// <summary>
        /// Required. Output only. Closed-world confidence score in `[0, 1]`, equal to the calibrated<br/>
        /// probability of the winning outcome:<br/>
        /// - `NoulAnswer`: `max(noul, 1 - noul)`<br/>
        /// - `ChoiceAnswer`: `p_max` (the probability of `choice`)<br/>
        /// - `ScoreAnswer`: `p_max` (the highest probability in `probabilities`).<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double Confidence { get; set; } = default!;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreAnswer" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="score">
        /// Required. Output only. Probability-weighted expected score (`sum_k k * probability_k`).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="probabilities">
        /// Required. Output only. Closed-world normalized probability in `[0, 1]` for each 0-based level<br/>
        /// index.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="legend">
        /// Required. Output only. Rubric description for each non-empty 0-based level index.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="confidence">
        /// Required. Output only. Closed-world confidence score in `[0, 1]`, equal to the calibrated<br/>
        /// probability of the winning outcome:<br/>
        /// - `NoulAnswer`: `max(noul, 1 - noul)`<br/>
        /// - `ChoiceAnswer`: `p_max` (the probability of `choice`)<br/>
        /// - `ScoreAnswer`: `p_max` (the highest probability in `probabilities`).<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreAnswer(
            object type,
            double score = default!,
            global::System.Collections.Generic.Dictionary<string, double> probabilities = default!,
            global::System.Collections.Generic.Dictionary<string, string> legend = default!,
            double confidence = default!)
        {
            this.Score = score;
            this.Probabilities = probabilities;
            this.Legend = legend;
            this.Confidence = confidence;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreAnswer" /> class.
        /// </summary>
        public ScoreAnswer()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ScoreAnswer"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ScoreAnswer FromType(object type)
        {
            return new ScoreAnswer
            {
                Type = type,
            };
        }

    }
}