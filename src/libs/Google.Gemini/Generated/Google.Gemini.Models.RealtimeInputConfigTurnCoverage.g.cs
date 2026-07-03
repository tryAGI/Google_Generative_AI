
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. Defines which input is included in the user's turn.
    /// </summary>
    public enum RealtimeInputConfigTurnCoverage
    {
        /// <summary>
        /// If unspecified, a default behavior is selected based on the model. E.g., for Gemini 2.5, the default is `TURN_INCLUDES_ONLY_ACTIVITY`, while for Gemini 3.1 and onwards, it's `TURN_INCLUDES_AUDIO_ACTIVITY_AND_ALL_VIDEO`.
        /// </summary>
        TurnCoverageUnspecified,
        /// <summary>
        /// Includes all realtime input since the last turn, including inactivity (e.g. silence on the audio stream).
        /// </summary>
        TurnIncludesAllInput,
        /// <summary>
        /// Includes audio activity and all video since the last turn. With automatic activity detection, audio activity means speech and excludes silence.
        /// </summary>
        TurnIncludesAudioActivityAndAllVideo,
        /// <summary>
        /// Includes activity since the last turn, excluding inactivity (e.g. silence on the audio stream).
        /// </summary>
        TurnIncludesOnlyActivity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeInputConfigTurnCoverageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeInputConfigTurnCoverage value)
        {
            return value switch
            {
                RealtimeInputConfigTurnCoverage.TurnCoverageUnspecified => "TURN_COVERAGE_UNSPECIFIED",
                RealtimeInputConfigTurnCoverage.TurnIncludesAllInput => "TURN_INCLUDES_ALL_INPUT",
                RealtimeInputConfigTurnCoverage.TurnIncludesAudioActivityAndAllVideo => "TURN_INCLUDES_AUDIO_ACTIVITY_AND_ALL_VIDEO",
                RealtimeInputConfigTurnCoverage.TurnIncludesOnlyActivity => "TURN_INCLUDES_ONLY_ACTIVITY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeInputConfigTurnCoverage? ToEnum(string value)
        {
            return value switch
            {
                "TURN_COVERAGE_UNSPECIFIED" => RealtimeInputConfigTurnCoverage.TurnCoverageUnspecified,
                "TURN_INCLUDES_ALL_INPUT" => RealtimeInputConfigTurnCoverage.TurnIncludesAllInput,
                "TURN_INCLUDES_AUDIO_ACTIVITY_AND_ALL_VIDEO" => RealtimeInputConfigTurnCoverage.TurnIncludesAudioActivityAndAllVideo,
                "TURN_INCLUDES_ONLY_ACTIVITY" => RealtimeInputConfigTurnCoverage.TurnIncludesOnlyActivity,
                _ => null,
            };
        }
    }
}