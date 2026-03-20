
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// The stage of the underlying model.
    /// </summary>
    public enum ModelStatusModelStage
    {
        /// <summary>
        /// Unspecified model stage.
        /// </summary>
        ModelStageUnspecified,
        /// <summary>
        /// The underlying model is subject to lots of tunings.
        /// </summary>
        UnstableExperimental,
        /// <summary>
        /// Models in this stage are for experimental purposes only.
        /// </summary>
        Experimental,
        /// <summary>
        /// Models in this stage are more mature than experimental models.
        /// </summary>
        Preview,
        /// <summary>
        /// Models in this stage are considered stable and ready for production use.
        /// </summary>
        Stable,
        /// <summary>
        /// If the model is on this stage, it means that this model is on the path to deprecation in near future. Only existing customers can use this model.
        /// </summary>
        Legacy,
        /// <summary>
        /// Models in this stage are deprecated. These models cannot be used.
        /// </summary>
        Deprecated,
        /// <summary>
        /// Models in this stage are retired. These models cannot be used.
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