
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Input provided by the user.
    /// </summary>
    public sealed partial class UserInputStep
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>? Content { get; set; }

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
        /// Initializes a new instance of the <see cref="UserInputStep" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserInputStep(
            object type,
            global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.Content>? content)
        {
            this.Content = content;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInputStep" /> class.
        /// </summary>
        public UserInputStep()
        {
        }

    }
}