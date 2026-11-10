
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. Arbitrary customer-defined JSON configuration passed through to the self-hosted environment poller. Only supported when `mode` is `SELF_HOSTED`.
    /// </summary>
    public sealed partial class CreateEnvironmentRequestCustomConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}