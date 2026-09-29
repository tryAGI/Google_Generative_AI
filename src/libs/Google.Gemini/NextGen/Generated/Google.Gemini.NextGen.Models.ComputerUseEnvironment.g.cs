
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The environment being operated.
    /// </summary>
    public enum ComputerUseEnvironment
    {
        /// <summary>
        ///
        /// </summary>
        Browser,
        /// <summary>
        ///
        /// </summary>
        Desktop,
        /// <summary>
        ///
        /// </summary>
        Mobile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseEnvironment value)
        {
            return value switch
            {
                ComputerUseEnvironment.Browser => "browser",
                ComputerUseEnvironment.Desktop => "desktop",
                ComputerUseEnvironment.Mobile => "mobile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "browser" => ComputerUseEnvironment.Browser,
                "desktop" => ComputerUseEnvironment.Desktop,
                "mobile" => ComputerUseEnvironment.Mobile,
                _ => null,
            };
        }
    }
}