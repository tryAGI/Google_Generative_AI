
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Request parameters specific to FIX sessions, used for generating and<br/>
    /// validating security patches.
    /// </summary>
    public sealed partial class FixRequest
    {
        /// <summary>
        /// Additional context or custom instructions provided by the user to guide<br/>
        /// the patch generation process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The identifier of the specific security finding to be remediated. This ID<br/>
        /// maps to a previously discovered vulnerability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finding_id")]
        public string? FindingId { get; set; }

        /// <summary>
        /// A list of source files providing context for the remediation. These files<br/>
        /// are typically the ones containing the identified vulnerability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_files")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FileContent>? SourceFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FixRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// Additional context or custom instructions provided by the user to guide<br/>
        /// the patch generation process.
        /// </param>
        /// <param name="findingId">
        /// The identifier of the specific security finding to be remediated. This ID<br/>
        /// maps to a previously discovered vulnerability.
        /// </param>
        /// <param name="sourceFiles">
        /// A list of source files providing context for the remediation. These files<br/>
        /// are typically the ones containing the identified vulnerability.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FixRequest(
            string? description,
            string? findingId,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.FileContent>? sourceFiles)
        {
            this.Description = description;
            this.FindingId = findingId;
            this.SourceFiles = sourceFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FixRequest" /> class.
        /// </summary>
        public FixRequest()
        {
        }

    }
}