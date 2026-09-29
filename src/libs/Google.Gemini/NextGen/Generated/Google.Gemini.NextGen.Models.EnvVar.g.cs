
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// An environment variable to set in the execution environment.
    /// </summary>
    public sealed partial class EnvVar
    {
        /// <summary>
        /// Optional reference to a server-managed Credential resource by ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential")]
        public string? Credential { get; set; }

        /// <summary>
        /// Direct string value for plain environment variables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvVar" /> class.
        /// </summary>
        /// <param name="credential">
        /// Optional reference to a server-managed Credential resource by ID.
        /// </param>
        /// <param name="value">
        /// Direct string value for plain environment variables.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvVar(
            string? credential,
            string? value)
        {
            this.Credential = credential;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvVar" /> class.
        /// </summary>
        public EnvVar()
        {
        }

    }
}