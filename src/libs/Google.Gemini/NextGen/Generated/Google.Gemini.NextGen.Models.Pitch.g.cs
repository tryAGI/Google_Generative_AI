
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum Pitch
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PitchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Pitch value)
        {
            return value switch
            {
                Pitch.High => "high",
                Pitch.Low => "low",
                Pitch.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Pitch? ToEnum(string value)
        {
            return value switch
            {
                "high" => Pitch.High,
                "low" => Pitch.Low,
                "medium" => Pitch.Medium,
                _ => null,
            };
        }
    }
}