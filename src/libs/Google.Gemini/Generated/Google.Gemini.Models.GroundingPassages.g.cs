
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// A repeated list of passages.
    /// </summary>
    public sealed partial class GroundingPassages
    {
        /// <summary>
        /// List of passages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passages")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.GroundingPassage>? Passages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingPassages" /> class.
        /// </summary>
        /// <param name="passages">
        /// List of passages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundingPassages(
            global::System.Collections.Generic.IList<global::Google.Gemini.GroundingPassage>? passages)
        {
            this.Passages = passages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingPassages" /> class.
        /// </summary>
        public GroundingPassages()
        {
        }
    }
}