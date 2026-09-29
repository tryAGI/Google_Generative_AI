
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for updating environment variable credentials.
    /// </summary>
    public sealed partial class EnvironmentVariableUpdateConfig
    {
        /// <summary>
        /// Optional. Locations where the environment variable can be injected in<br/>
        /// outgoing HTTP requests.<br/>
        /// Accepts either a single location (e.g. "header") or an array of locations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("injection_location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Google.Gemini.NextGen.JsonConverters.OneOfJsonConverter<global::Google.Gemini.NextGen.InjectionLocation3?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation3>>))]
        public global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.InjectionLocation3?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation3>>? InjectionLocation { get; set; }

        /// <summary>
        /// Optional. List of domains allowed to receive this environment variable<br/>
        /// value in HTTP requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trusted_domains")]
        public global::System.Collections.Generic.IList<string>? TrustedDomains { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// Optional. Input only. Secret value of the environment variable. Write-only; never<br/>
        /// returned in responses.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentVariableUpdateConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="injectionLocation">
        /// Optional. Locations where the environment variable can be injected in<br/>
        /// outgoing HTTP requests.<br/>
        /// Accepts either a single location (e.g. "header") or an array of locations.
        /// </param>
        /// <param name="trustedDomains">
        /// Optional. List of domains allowed to receive this environment variable<br/>
        /// value in HTTP requests.
        /// </param>
        /// <param name="value">
        /// Optional. Input only. Secret value of the environment variable. Write-only; never<br/>
        /// returned in responses.<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentVariableUpdateConfig(
            object type,
            global::Google.Gemini.NextGen.OneOf<global::Google.Gemini.NextGen.InjectionLocation3?, global::System.Collections.Generic.IList<global::Google.Gemini.NextGen.InjectionLocation3>>? injectionLocation,
            global::System.Collections.Generic.IList<string>? trustedDomains,
            string? value)
        {
            this.InjectionLocation = injectionLocation;
            this.TrustedDomains = trustedDomains;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentVariableUpdateConfig" /> class.
        /// </summary>
        public EnvironmentVariableUpdateConfig()
        {
        }

    }
}