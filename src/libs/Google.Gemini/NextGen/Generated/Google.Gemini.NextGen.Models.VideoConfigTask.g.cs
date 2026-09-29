
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Optional task mode for video generation. If not specified, the model<br/>
    /// automatically determines the appropriate mode based on the provided text<br/>
    /// prompt and input media.
    /// </summary>
    public enum VideoConfigTask
    {
        /// <summary>
        ///
        /// </summary>
        Edit,
        /// <summary>
        ///
        /// </summary>
        Extend,
        /// <summary>
        ///
        /// </summary>
        ImageToVideo,
        /// <summary>
        ///
        /// </summary>
        ReferenceToVideo,
        /// <summary>
        ///
        /// </summary>
        TextToVideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoConfigTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoConfigTask value)
        {
            return value switch
            {
                VideoConfigTask.Edit => "edit",
                VideoConfigTask.Extend => "extend",
                VideoConfigTask.ImageToVideo => "image_to_video",
                VideoConfigTask.ReferenceToVideo => "reference_to_video",
                VideoConfigTask.TextToVideo => "text_to_video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoConfigTask? ToEnum(string value)
        {
            return value switch
            {
                "edit" => VideoConfigTask.Edit,
                "extend" => VideoConfigTask.Extend,
                "image_to_video" => VideoConfigTask.ImageToVideo,
                "reference_to_video" => VideoConfigTask.ReferenceToVideo,
                "text_to_video" => VideoConfigTask.TextToVideo,
                _ => null,
            };
        }
    }
}