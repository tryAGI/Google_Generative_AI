
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Config for Rank Service.
    /// </summary>
    public sealed partial class RankService
    {
        /// <summary>
        /// Optional. The model name of the rank service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankService" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Optional. The model name of the rank service.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankService(
            string? modelName)
        {
            this.ModelName = modelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankService" /> class.
        /// </summary>
        public RankService()
        {
        }

    }
}