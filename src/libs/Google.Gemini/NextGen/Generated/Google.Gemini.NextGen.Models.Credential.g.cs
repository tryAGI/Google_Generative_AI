
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Server-managed credential resource stored in Secret Manager.
    /// </summary>
    public sealed partial class Credential
    {
        /// <summary>
        /// Output only. The timestamp when the credential was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Required. Output only. Identifier. Unique identifier for the credential.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Output only. Current status of the credential.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.CredentialStatusJsonConverter))]
        public global::Google.Gemini.NextGen.CredentialStatus? Status { get; set; }

        /// <summary>
        /// Required. Output only. The type of credential.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.CredentialTypeJsonConverter))]
        public global::Google.Gemini.NextGen.CredentialType? Type { get; set; }

        /// <summary>
        /// Output only. The timestamp when the credential was last updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_time")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Credential" /> class.
        /// </summary>
        /// <param name="createTime">
        /// Output only. The timestamp when the credential was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Output only. Current status of the credential.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="type">
        /// Required. Output only. The type of credential.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Output only. The timestamp when the credential was last updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Required. Output only. Identifier. Unique identifier for the credential.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Credential(
            global::System.DateTime? createTime,
            global::Google.Gemini.NextGen.CredentialStatus? status,
            global::Google.Gemini.NextGen.CredentialType? type,
            global::System.DateTime? updateTime,
            string id = default!)
        {
            this.CreateTime = createTime;
            this.Id = id;
            this.Status = status;
            this.Type = type;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Credential" /> class.
        /// </summary>
        public Credential()
        {
        }

    }
}