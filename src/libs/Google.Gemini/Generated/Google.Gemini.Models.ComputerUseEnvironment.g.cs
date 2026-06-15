
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Required. The environment being operated.
    /// </summary>
    public enum ComputerUseEnvironment
    {
        /// <summary>
        /// Operates in a web browser.
        /// </summary>
        EnvironmentBrowser,
        /// <summary>
        /// Operates in a desktop environment.
        /// </summary>
        EnvironmentDesktop,
        /// <summary>
        /// Operates in a mobile environment.
        /// </summary>
        EnvironmentMobile,
        /// <summary>
        /// Defaults to browser.
        /// </summary>
        EnvironmentUnspecified,
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
                ComputerUseEnvironment.EnvironmentBrowser => "ENVIRONMENT_BROWSER",
                ComputerUseEnvironment.EnvironmentDesktop => "ENVIRONMENT_DESKTOP",
                ComputerUseEnvironment.EnvironmentMobile => "ENVIRONMENT_MOBILE",
                ComputerUseEnvironment.EnvironmentUnspecified => "ENVIRONMENT_UNSPECIFIED",
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
                "ENVIRONMENT_BROWSER" => ComputerUseEnvironment.EnvironmentBrowser,
                "ENVIRONMENT_DESKTOP" => ComputerUseEnvironment.EnvironmentDesktop,
                "ENVIRONMENT_MOBILE" => ComputerUseEnvironment.EnvironmentMobile,
                "ENVIRONMENT_UNSPECIFIED" => ComputerUseEnvironment.EnvironmentUnspecified,
                _ => null,
            };
        }
    }
}