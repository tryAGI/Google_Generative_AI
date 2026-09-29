
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The aspect ratio for the image output.
    /// </summary>
    public enum ImageResponseFormatAspectRatio
    {
        /// <summary>
        ///
        /// </summary>
        x16_9,
        /// <summary>
        ///
        /// </summary>
        x1_1,
        /// <summary>
        ///
        /// </summary>
        x1_4,
        /// <summary>
        ///
        /// </summary>
        x1_8,
        /// <summary>
        ///
        /// </summary>
        x21_9,
        /// <summary>
        ///
        /// </summary>
        x2_3,
        /// <summary>
        ///
        /// </summary>
        x3_2,
        /// <summary>
        ///
        /// </summary>
        x3_4,
        /// <summary>
        ///
        /// </summary>
        x4_1,
        /// <summary>
        ///
        /// </summary>
        x4_3,
        /// <summary>
        ///
        /// </summary>
        x4_5,
        /// <summary>
        ///
        /// </summary>
        x5_4,
        /// <summary>
        ///
        /// </summary>
        x8_1,
        /// <summary>
        ///
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageResponseFormatAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageResponseFormatAspectRatio value)
        {
            return value switch
            {
                ImageResponseFormatAspectRatio.x16_9 => "16:9",
                ImageResponseFormatAspectRatio.x1_1 => "1:1",
                ImageResponseFormatAspectRatio.x1_4 => "1:4",
                ImageResponseFormatAspectRatio.x1_8 => "1:8",
                ImageResponseFormatAspectRatio.x21_9 => "21:9",
                ImageResponseFormatAspectRatio.x2_3 => "2:3",
                ImageResponseFormatAspectRatio.x3_2 => "3:2",
                ImageResponseFormatAspectRatio.x3_4 => "3:4",
                ImageResponseFormatAspectRatio.x4_1 => "4:1",
                ImageResponseFormatAspectRatio.x4_3 => "4:3",
                ImageResponseFormatAspectRatio.x4_5 => "4:5",
                ImageResponseFormatAspectRatio.x5_4 => "5:4",
                ImageResponseFormatAspectRatio.x8_1 => "8:1",
                ImageResponseFormatAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageResponseFormatAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => ImageResponseFormatAspectRatio.x16_9,
                "1:1" => ImageResponseFormatAspectRatio.x1_1,
                "1:4" => ImageResponseFormatAspectRatio.x1_4,
                "1:8" => ImageResponseFormatAspectRatio.x1_8,
                "21:9" => ImageResponseFormatAspectRatio.x21_9,
                "2:3" => ImageResponseFormatAspectRatio.x2_3,
                "3:2" => ImageResponseFormatAspectRatio.x3_2,
                "3:4" => ImageResponseFormatAspectRatio.x3_4,
                "4:1" => ImageResponseFormatAspectRatio.x4_1,
                "4:3" => ImageResponseFormatAspectRatio.x4_3,
                "4:5" => ImageResponseFormatAspectRatio.x4_5,
                "5:4" => ImageResponseFormatAspectRatio.x5_4,
                "8:1" => ImageResponseFormatAspectRatio.x8_1,
                "9:16" => ImageResponseFormatAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}