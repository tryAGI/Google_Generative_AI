
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum GenerationConfigToolChoice
    {
        /// <summary>
        ///
        /// </summary>
        Any,
        /// <summary>
        ///
        /// </summary>
        Auto,
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
    public static class GenerationConfigToolChoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationConfigToolChoice value)
        {
            return value switch
            {
                GenerationConfigToolChoice.Any => "any",
                GenerationConfigToolChoice.Auto => "auto",
                GenerationConfigToolChoice.None => "none",
                GenerationConfigToolChoice.Validated => "validated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationConfigToolChoice? ToEnum(string value)
        {
            return value switch
            {
                "any" => GenerationConfigToolChoice.Any,
                "auto" => GenerationConfigToolChoice.Auto,
                "none" => GenerationConfigToolChoice.None,
                "validated" => GenerationConfigToolChoice.Validated,
                _ => null,
            };
        }
    }
}