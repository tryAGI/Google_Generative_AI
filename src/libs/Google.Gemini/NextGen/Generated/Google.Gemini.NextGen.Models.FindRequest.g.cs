
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Request parameters specific to FIND sessions, used for discovering<br/>
    /// vulnerabilities in a codebase.
    /// </summary>
    public sealed partial class FindRequest
    {
        /// <summary>
        /// Additional context or custom instructions provided by the user to guide<br/>
        /// the vulnerability analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The identifier of a specific finding to verify. This is primarily used in<br/>
        /// VERIFY mode to focus the agent's execution-based validation on a single<br/>
        /// vulnerability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finding_id")]
        public string? FindingId { get; set; }

        /// <summary>
        /// The mode of the find session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.FindRequestModeJsonConverter))]
        public global::Google.Gemini.NextGen.FindRequestMode? Mode { get; set; }

        /// <summary>
        /// A list of source files to provide as context for the scan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_files")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FileContent>? SourceFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// Additional context or custom instructions provided by the user to guide<br/>
        /// the vulnerability analysis.
        /// </param>
        /// <param name="findingId">
        /// The identifier of a specific finding to verify. This is primarily used in<br/>
        /// VERIFY mode to focus the agent's execution-based validation on a single<br/>
        /// vulnerability.
        /// </param>
        /// <param name="mode">
        /// The mode of the find session.
        /// </param>
        /// <param name="sourceFiles">
        /// A list of source files to provide as context for the scan.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindRequest(
            string? description,
            string? findingId,
            global::Google.Gemini.NextGen.FindRequestMode? mode,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FileContent>? sourceFiles)
        {
            this.Description = description;
            this.FindingId = findingId;
            this.Mode = mode;
            this.SourceFiles = sourceFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindRequest" /> class.
        /// </summary>
        public FindRequest()
        {
        }

    }
}