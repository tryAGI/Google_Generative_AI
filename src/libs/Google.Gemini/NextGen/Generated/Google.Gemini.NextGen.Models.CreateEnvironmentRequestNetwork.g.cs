
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateEnvironmentRequestNetwork
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEnvironmentRequestNetworkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEnvironmentRequestNetwork value)
        {
            return value switch
            {
                CreateEnvironmentRequestNetwork.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEnvironmentRequestNetwork? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CreateEnvironmentRequestNetwork.Disabled,
                _ => null,
            };
        }
    }
}