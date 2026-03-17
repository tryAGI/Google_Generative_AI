
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Filter condition applicable to a single key.
    /// </summary>
    public sealed partial class Condition
    {
        /// <summary>
        /// The string value to filter the metadata on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stringValue")]
        public string? StringValue { get; set; }

        /// <summary>
        /// The numeric value to filter the metadata on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numericValue")]
        public float? NumericValue { get; set; }

        /// <summary>
        /// Required. Operator applied to the given key-value pair to trigger the condition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.JsonConverters.ConditionOperationJsonConverter))]
        public global::Google.Gemini.ConditionOperation? Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Condition" /> class.
        /// </summary>
        /// <param name="stringValue">
        /// The string value to filter the metadata on.
        /// </param>
        /// <param name="numericValue">
        /// The numeric value to filter the metadata on.
        /// </param>
        /// <param name="operation">
        /// Required. Operator applied to the given key-value pair to trigger the condition.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Condition(
            string? stringValue,
            float? numericValue,
            global::Google.Gemini.ConditionOperation? operation)
        {
            this.StringValue = stringValue;
            this.NumericValue = numericValue;
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Condition" /> class.
        /// </summary>
        public Condition()
        {
        }
    }
}