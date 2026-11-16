
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Output only. Arbitrary customer-defined JSON configuration passed through to the<br/>
    /// self-hosted environment poller. Only populated for `self_hosted`<br/>
    /// environments when configured.
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