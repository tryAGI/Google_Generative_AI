
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Config for ranking and reranking.
    /// </summary>
    public sealed partial class Ranking
    {
        /// <summary>
        /// Optional. The model name of the rank service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// Config for Rank Service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank_service")]
        public global::Google.Gemini.NextGen.RankService? RankService { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranking_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object RankingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Ranking" /> class.
        /// </summary>
        /// <param name="rankingConfig"></param>
        /// <param name="modelName">
        /// Optional. The model name of the rank service.
        /// </param>
        /// <param name="rankService">
        /// Config for Rank Service.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Ranking(
            object rankingConfig,
            string? modelName,
            global::Google.Gemini.NextGen.RankService? rankService)
        {
            this.ModelName = modelName;
            this.RankService = rankService;
            this.RankingConfig = rankingConfig ?? throw new global::System.ArgumentNullException(nameof(rankingConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ranking" /> class.
        /// </summary>
        public Ranking()
        {
        }

    }
}