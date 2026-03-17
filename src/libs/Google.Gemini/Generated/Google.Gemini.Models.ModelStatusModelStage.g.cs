
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The stage of the underlying model.
    /// </summary>
    public enum ModelStatusModelStage
    {
        /// <summary>
        /// 
        /// </summary>
        ModelStageUnspecified,
        /// <summary>
        /// 
        /// </summary>
        UnstableExperimental,
        /// <summary>
        /// 
        /// </summary>
        Experimental,
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Stable,
        /// <summary>
        /// 
        /// </summary>
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        Deprecated,
        /// <summary>
        /// 
        /// </summary>
        Retired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelStatusModelStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelStatusModelStage value)
        {
            return value switch
            {
                ModelStatusModelStage.ModelStageUnspecified => "MODEL_STAGE_UNSPECIFIED",
                ModelStatusModelStage.UnstableExperimental => "UNSTABLE_EXPERIMENTAL",
                ModelStatusModelStage.Experimental => "EXPERIMENTAL",
                ModelStatusModelStage.Preview => "PREVIEW",
                ModelStatusModelStage.Stable => "STABLE",
                ModelStatusModelStage.Legacy => "LEGACY",
                ModelStatusModelStage.Deprecated => "DEPRECATED",
                ModelStatusModelStage.Retired => "RETIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelStatusModelStage? ToEnum(string value)
        {
            return value switch
            {
                "MODEL_STAGE_UNSPECIFIED" => ModelStatusModelStage.ModelStageUnspecified,
                "UNSTABLE_EXPERIMENTAL" => ModelStatusModelStage.UnstableExperimental,
                "EXPERIMENTAL" => ModelStatusModelStage.Experimental,
                "PREVIEW" => ModelStatusModelStage.Preview,
                "STABLE" => ModelStatusModelStage.Stable,
                "LEGACY" => ModelStatusModelStage.Legacy,
                "DEPRECATED" => ModelStatusModelStage.Deprecated,
                "RETIRED" => ModelStatusModelStage.Retired,
                _ => null,
            };
        }
    }
}