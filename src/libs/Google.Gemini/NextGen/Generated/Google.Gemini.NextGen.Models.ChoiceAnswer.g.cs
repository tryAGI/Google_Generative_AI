
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Calibrated result for a `ChoiceQuestion`.
    /// </summary>
    public sealed partial class ChoiceAnswer
    {
        /// <summary>
        /// Required. Output only. The option ID with the highest probability.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("choice")]
        public string Choice { get; set; } = default!;

        /// <summary>
        /// Required. Output only. Closed-world normalized probability in `[0, 1]` for each option ID.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("probabilities")]
        public global::System.Collections.Generic.Dictionary<string, double> Probabilities { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ChoiceAnswer" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="choice">
        /// Required. Output only. The option ID with the highest probability.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="probabilities">
        /// Required. Output only. Closed-world normalized probability in `[0, 1]` for each option ID.<br/>
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
        public ChoiceAnswer(
            object type,
            string choice = default!,
            global::System.Collections.Generic.Dictionary<string, double> probabilities = default!,
            double confidence = default!)
        {
            this.Choice = choice;
            this.Probabilities = probabilities;
            this.Confidence = confidence;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceAnswer" /> class.
        /// </summary>
        public ChoiceAnswer()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChoiceAnswer"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChoiceAnswer FromType(object type)
        {
            return new ChoiceAnswer
            {
                Type = type,
            };
        }

    }
}