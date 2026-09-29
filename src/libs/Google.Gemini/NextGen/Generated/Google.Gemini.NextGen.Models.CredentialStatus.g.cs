
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Output only. Current status of the credential.<br/>
    /// Included only in responses
    /// </summary>
    public enum CredentialStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Revoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CredentialStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CredentialStatus value)
        {
            return value switch
            {
                CredentialStatus.Active => "active",
                CredentialStatus.Revoked => "revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CredentialStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CredentialStatus.Active,
                "revoked" => CredentialStatus.Revoked,
                _ => null,
            };
        }
    }
}