
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. Defines what effect activity has.
    /// </summary>
    public enum RealtimeInputConfigActivityHandling
    {
        /// <summary>
        /// If unspecified, the default behavior is `START_OF_ACTIVITY_INTERRUPTS`.
        /// </summary>
        ActivityHandlingUnspecified,
        /// <summary>
        /// The model's response will not be interrupted.
        /// </summary>
        NoInterruption,
        /// <summary>
        /// If true, start of activity will interrupt the model's response (also called "barge in"). The model's current response will be cut-off in the moment of the interruption. This is the default behavior.
        /// </summary>
        StartOfActivityInterrupts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeInputConfigActivityHandlingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeInputConfigActivityHandling value)
        {
            return value switch
            {
                RealtimeInputConfigActivityHandling.ActivityHandlingUnspecified => "ACTIVITY_HANDLING_UNSPECIFIED",
                RealtimeInputConfigActivityHandling.NoInterruption => "NO_INTERRUPTION",
                RealtimeInputConfigActivityHandling.StartOfActivityInterrupts => "START_OF_ACTIVITY_INTERRUPTS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeInputConfigActivityHandling? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVITY_HANDLING_UNSPECIFIED" => RealtimeInputConfigActivityHandling.ActivityHandlingUnspecified,
                "NO_INTERRUPTION" => RealtimeInputConfigActivityHandling.NoInterruption,
                "START_OF_ACTIVITY_INTERRUPTS" => RealtimeInputConfigActivityHandling.StartOfActivityInterrupts,
                _ => null,
            };
        }
    }
}