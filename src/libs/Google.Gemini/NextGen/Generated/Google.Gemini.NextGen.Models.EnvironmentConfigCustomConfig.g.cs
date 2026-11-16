
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Optional. Arbitrary customer-defined JSON configuration passed through<br/>
    /// to the self-hosted environment poller. Only supported when `mode` is<br/>
    /// `SELF_HOSTED`.
    /// </summary>
    public sealed partial class EnvironmentConfigCustomConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}