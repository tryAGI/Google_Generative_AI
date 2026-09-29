
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Optional. The revocation behavior for previous signing secrets.
    /// </summary>
    public enum RotateSigningSecretRequestRevocationBehavior
    {
        /// <summary>
        ///
        /// </summary>
        RevokePreviousSecretsAfterH24,
        /// <summary>
        ///
        /// </summary>
        RevokePreviousSecretsImmediately,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RotateSigningSecretRequestRevocationBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RotateSigningSecretRequestRevocationBehavior value)
        {
            return value switch
            {
                RotateSigningSecretRequestRevocationBehavior.RevokePreviousSecretsAfterH24 => "revoke_previous_secrets_after_h24",
                RotateSigningSecretRequestRevocationBehavior.RevokePreviousSecretsImmediately => "revoke_previous_secrets_immediately",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RotateSigningSecretRequestRevocationBehavior? ToEnum(string value)
        {
            return value switch
            {
                "revoke_previous_secrets_after_h24" => RotateSigningSecretRequestRevocationBehavior.RevokePreviousSecretsAfterH24,
                "revoke_previous_secrets_immediately" => RotateSigningSecretRequestRevocationBehavior.RevokePreviousSecretsImmediately,
                _ => null,
            };
        }
    }
}