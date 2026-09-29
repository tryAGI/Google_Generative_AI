
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The mime type of the video.
    /// </summary>
    public enum VideoContentMimeType
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
    public static class VideoContentMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoContentMimeType value)
        {
            return value switch
            {
                VideoContentMimeType.Video3gpp => "video/3gpp",
                VideoContentMimeType.VideoAvi => "video/avi",
                VideoContentMimeType.VideoMov => "video/mov",
                VideoContentMimeType.VideoMp4 => "video/mp4",
                VideoContentMimeType.VideoMpeg => "video/mpeg",
                VideoContentMimeType.VideoMpg => "video/mpg",
                VideoContentMimeType.VideoWebm => "video/webm",
                VideoContentMimeType.VideoWmv => "video/wmv",
                VideoContentMimeType.VideoXFlv => "video/x-flv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoContentMimeType? ToEnum(string value)
        {
            return value switch
            {
                "video/3gpp" => VideoContentMimeType.Video3gpp,
                "video/avi" => VideoContentMimeType.VideoAvi,
                "video/mov" => VideoContentMimeType.VideoMov,
                "video/mp4" => VideoContentMimeType.VideoMp4,
                "video/mpeg" => VideoContentMimeType.VideoMpeg,
                "video/mpg" => VideoContentMimeType.VideoMpg,
                "video/webm" => VideoContentMimeType.VideoWebm,
                "video/wmv" => VideoContentMimeType.VideoWmv,
                "video/x-flv" => VideoContentMimeType.VideoXFlv,
                _ => null,
            };
        }
    }
}