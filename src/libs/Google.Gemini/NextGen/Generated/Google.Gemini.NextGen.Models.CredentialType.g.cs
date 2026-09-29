
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Required. Output only. The type of credential.<br/>
    /// Included only in responses
    /// </summary>
    public enum CredentialType
    {
        /// <summary>
        ///
        /// </summary>
        BearerToken,
        /// <summary>
        ///
        /// </summary>
        EnvironmentVariable,
        /// <summary>
        ///
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CredentialTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CredentialType value)
        {
            return value switch
            {
                CredentialType.BearerToken => "bearer_token",
                CredentialType.EnvironmentVariable => "environment_variable",
                CredentialType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CredentialType? ToEnum(string value)
        {
            return value switch
            {
                "bearer_token" => CredentialType.BearerToken,
                "environment_variable" => CredentialType.EnvironmentVariable,
                "oauth2" => CredentialType.Oauth2,
                _ => null,
            };
        }
    }
}