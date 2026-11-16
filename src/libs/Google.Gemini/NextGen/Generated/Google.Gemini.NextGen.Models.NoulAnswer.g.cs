
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Calibrated result for a `NoulQuestion`.
    /// </summary>
    public sealed partial class NoulAnswer
    {
        /// <summary>
        /// Required. Output only. Calibrated probability `P(true)` in `[0.01, 0.99]`.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("noul")]
        public double Noul { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="NoulAnswer" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="noul">
        /// Required. Output only. Calibrated probability `P(true)` in `[0.01, 0.99]`.<br/>
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
        public NoulAnswer(
            object type,
            double noul = default!,
            double confidence = default!)
        {
            this.Noul = noul;
            this.Confidence = confidence;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoulAnswer" /> class.
        /// </summary>
        public NoulAnswer()
        {
        }

        /// <summary>
        /// Creates a new <see cref="NoulAnswer"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static NoulAnswer FromType(object type)
        {
            return new NoulAnswer
            {
                Type = type,
            };
        }

    }
}