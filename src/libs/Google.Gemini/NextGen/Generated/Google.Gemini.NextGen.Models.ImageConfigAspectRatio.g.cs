
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The aspect ratio of the image to generate. Supported aspect ratios: 1:1,<br/>
    /// 2:3, 3:2, 3:4, 4:3, 9:16, 16:9, 21:9.<br/>
    /// If not specified, the model will choose a default aspect ratio based on any<br/>
    /// reference images provided.
    /// </summary>
    public enum ImageConfigAspectRatio
    {
        /// <summary>
        /// 3, 3:2, 3:4, 4:3, 9:16, 16:9, 21:9.
        /// </summary>
        x16_9,
        /// <summary>
        /// 1:1,
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
        /// 3, 3:2, 3:4, 4:3, 9:16, 16:9, 21:9.
        /// </summary>
        x21_9,
        /// <summary>
        /// 3, 3:2, 3:4, 4:3, 9:16, 16:9, 21:9.
        /// </summary>
        x2_3,
        /// <summary>
        /// 3, 3:2, 3:4, 4:3, 9:16, 16:9, 21:9.
        /// </summary>
        x3_2,
        /// <summary>
        /// 3, 3:2, 3:4, 4:3, 9:16, 16:9, 21:9.
        /// </summary>
        x3_4,
        /// <summary>
        ///
        /// </summary>
        x4_1,
        /// <summary>
        /// 3, 3:2, 3:4, 4:3, 9:16, 16:9, 21:9.
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
        /// 3, 3:2, 3:4, 4:3, 9:16, 16:9, 21:9.
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageConfigAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageConfigAspectRatio value)
        {
            return value switch
            {
                ImageConfigAspectRatio.x16_9 => "16:9",
                ImageConfigAspectRatio.x1_1 => "1:1",
                ImageConfigAspectRatio.x1_4 => "1:4",
                ImageConfigAspectRatio.x1_8 => "1:8",
                ImageConfigAspectRatio.x21_9 => "21:9",
                ImageConfigAspectRatio.x2_3 => "2:3",
                ImageConfigAspectRatio.x3_2 => "3:2",
                ImageConfigAspectRatio.x3_4 => "3:4",
                ImageConfigAspectRatio.x4_1 => "4:1",
                ImageConfigAspectRatio.x4_3 => "4:3",
                ImageConfigAspectRatio.x4_5 => "4:5",
                ImageConfigAspectRatio.x5_4 => "5:4",
                ImageConfigAspectRatio.x8_1 => "8:1",
                ImageConfigAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageConfigAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => ImageConfigAspectRatio.x16_9,
                "1:1" => ImageConfigAspectRatio.x1_1,
                "1:4" => ImageConfigAspectRatio.x1_4,
                "1:8" => ImageConfigAspectRatio.x1_8,
                "21:9" => ImageConfigAspectRatio.x21_9,
                "2:3" => ImageConfigAspectRatio.x2_3,
                "3:2" => ImageConfigAspectRatio.x3_2,
                "3:4" => ImageConfigAspectRatio.x3_4,
                "4:1" => ImageConfigAspectRatio.x4_1,
                "4:3" => ImageConfigAspectRatio.x4_3,
                "4:5" => ImageConfigAspectRatio.x4_5,
                "5:4" => ImageConfigAspectRatio.x5_4,
                "8:1" => ImageConfigAspectRatio.x8_1,
                "9:16" => ImageConfigAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}