
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Output only. Arbitrary customer-defined JSON configuration passed through to the self-hosted environment poller. Only populated for `self_hosted` environments when configured.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class EnvironmentCustomConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}