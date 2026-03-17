
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. Specifies the mode in which function calling should execute. If unspecified, the default value will be set to AUTO.
    /// </summary>
    public enum FunctionCallingConfigMode
    {
        /// <summary>
        /// 
        /// </summary>
        ModeUnspecified,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Any,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Validated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionCallingConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallingConfigMode value)
        {
            return value switch
            {
                FunctionCallingConfigMode.ModeUnspecified => "MODE_UNSPECIFIED",
                FunctionCallingConfigMode.Auto => "AUTO",
                FunctionCallingConfigMode.Any => "ANY",
                FunctionCallingConfigMode.None => "NONE",
                FunctionCallingConfigMode.Validated => "VALIDATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallingConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "MODE_UNSPECIFIED" => FunctionCallingConfigMode.ModeUnspecified,
                "AUTO" => FunctionCallingConfigMode.Auto,
                "ANY" => FunctionCallingConfigMode.Any,
                "NONE" => FunctionCallingConfigMode.None,
                "VALIDATED" => FunctionCallingConfigMode.Validated,
                _ => null,
            };
        }
    }
}