
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoDeltaMimeType
    {
        /// <summary>
        ///
        /// </summary>
        Video3gpp,
        /// <summary>
        ///
        /// </summary>
        VideoAvi,
        /// <summary>
        ///
        /// </summary>
        VideoJpeg2000,
        /// <summary>
        ///
        /// </summary>
        VideoMov,
        /// <summary>
        ///
        /// </summary>
        VideoMp4,
        /// <summary>
        ///
        /// </summary>
        VideoMpeg,
        /// <summary>
        ///
        /// </summary>
        VideoMpg,
        /// <summary>
        ///
        /// </summary>
        VideoWebm,
        /// <summary>
        ///
        /// </summary>
        VideoWmv,
        /// <summary>
        ///
        /// </summary>
        VideoXFlv,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoDeltaMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoDeltaMimeType value)
        {
            return value switch
            {
                VideoDeltaMimeType.Video3gpp => "video/3gpp",
                VideoDeltaMimeType.VideoAvi => "video/avi",
                VideoDeltaMimeType.VideoJpeg2000 => "video/jpeg2000",
                VideoDeltaMimeType.VideoMov => "video/mov",
                VideoDeltaMimeType.VideoMp4 => "video/mp4",
                VideoDeltaMimeType.VideoMpeg => "video/mpeg",
                VideoDeltaMimeType.VideoMpg => "video/mpg",
                VideoDeltaMimeType.VideoWebm => "video/webm",
                VideoDeltaMimeType.VideoWmv => "video/wmv",
                VideoDeltaMimeType.VideoXFlv => "video/x-flv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoDeltaMimeType? ToEnum(string value)
        {
            return value switch
            {
                "video/3gpp" => VideoDeltaMimeType.Video3gpp,
                "video/avi" => VideoDeltaMimeType.VideoAvi,
                "video/jpeg2000" => VideoDeltaMimeType.VideoJpeg2000,
                "video/mov" => VideoDeltaMimeType.VideoMov,
                "video/mp4" => VideoDeltaMimeType.VideoMp4,
                "video/mpeg" => VideoDeltaMimeType.VideoMpeg,
                "video/mpg" => VideoDeltaMimeType.VideoMpg,
                "video/webm" => VideoDeltaMimeType.VideoWebm,
                "video/wmv" => VideoDeltaMimeType.VideoWmv,
                "video/x-flv" => VideoDeltaMimeType.VideoXFlv,
                _ => null,
            };
        }
    }
}