
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. The aspect ratio for the image output.
    /// </summary>
    public enum ImageResponseFormatAspectRatio
    {
        /// <summary>
        /// 8:1 aspect ratio.
        /// </summary>
        AspectRatioEightByOne,
        /// <summary>
        /// 5:4 aspect ratio.
        /// </summary>
        AspectRatioFiveByFour,
        /// <summary>
        /// 4:5 aspect ratio.
        /// </summary>
        AspectRatioFourByFive,
        /// <summary>
        /// 4:1 aspect ratio.
        /// </summary>
        AspectRatioFourByOne,
        /// <summary>
        /// 4:3 aspect ratio.
        /// </summary>
        AspectRatioFourByThree,
        /// <summary>
        /// 9:16 aspect ratio.
        /// </summary>
        AspectRatioNineBySixteen,
        /// <summary>
        /// 1:8 aspect ratio.
        /// </summary>
        AspectRatioOneByEight,
        /// <summary>
        /// 1:4 aspect ratio.
        /// </summary>
        AspectRatioOneByFour,
        /// <summary>
        /// 1:1 aspect ratio.
        /// </summary>
        AspectRatioOneByOne,
        /// <summary>
        /// 16:9 aspect ratio.
        /// </summary>
        AspectRatioSixteenByNine,
        /// <summary>
        /// 3:4 aspect ratio.
        /// </summary>
        AspectRatioThreeByFour,
        /// <summary>
        /// 3:2 aspect ratio.
        /// </summary>
        AspectRatioThreeByTwo,
        /// <summary>
        /// 21:9 aspect ratio.
        /// </summary>
        AspectRatioTwentyOneByNine,
        /// <summary>
        /// 2:3 aspect ratio.
        /// </summary>
        AspectRatioTwoByThree,
        /// <summary>
        /// Default value. This value is unused.
        /// </summary>
        AspectRatioUnspecified,
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
                ImageResponseFormatAspectRatio.AspectRatioEightByOne => "ASPECT_RATIO_EIGHT_BY_ONE",
                ImageResponseFormatAspectRatio.AspectRatioFiveByFour => "ASPECT_RATIO_FIVE_BY_FOUR",
                ImageResponseFormatAspectRatio.AspectRatioFourByFive => "ASPECT_RATIO_FOUR_BY_FIVE",
                ImageResponseFormatAspectRatio.AspectRatioFourByOne => "ASPECT_RATIO_FOUR_BY_ONE",
                ImageResponseFormatAspectRatio.AspectRatioFourByThree => "ASPECT_RATIO_FOUR_BY_THREE",
                ImageResponseFormatAspectRatio.AspectRatioNineBySixteen => "ASPECT_RATIO_NINE_BY_SIXTEEN",
                ImageResponseFormatAspectRatio.AspectRatioOneByEight => "ASPECT_RATIO_ONE_BY_EIGHT",
                ImageResponseFormatAspectRatio.AspectRatioOneByFour => "ASPECT_RATIO_ONE_BY_FOUR",
                ImageResponseFormatAspectRatio.AspectRatioOneByOne => "ASPECT_RATIO_ONE_BY_ONE",
                ImageResponseFormatAspectRatio.AspectRatioSixteenByNine => "ASPECT_RATIO_SIXTEEN_BY_NINE",
                ImageResponseFormatAspectRatio.AspectRatioThreeByFour => "ASPECT_RATIO_THREE_BY_FOUR",
                ImageResponseFormatAspectRatio.AspectRatioThreeByTwo => "ASPECT_RATIO_THREE_BY_TWO",
                ImageResponseFormatAspectRatio.AspectRatioTwentyOneByNine => "ASPECT_RATIO_TWENTY_ONE_BY_NINE",
                ImageResponseFormatAspectRatio.AspectRatioTwoByThree => "ASPECT_RATIO_TWO_BY_THREE",
                ImageResponseFormatAspectRatio.AspectRatioUnspecified => "ASPECT_RATIO_UNSPECIFIED",
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
                "ASPECT_RATIO_EIGHT_BY_ONE" => ImageResponseFormatAspectRatio.AspectRatioEightByOne,
                "ASPECT_RATIO_FIVE_BY_FOUR" => ImageResponseFormatAspectRatio.AspectRatioFiveByFour,
                "ASPECT_RATIO_FOUR_BY_FIVE" => ImageResponseFormatAspectRatio.AspectRatioFourByFive,
                "ASPECT_RATIO_FOUR_BY_ONE" => ImageResponseFormatAspectRatio.AspectRatioFourByOne,
                "ASPECT_RATIO_FOUR_BY_THREE" => ImageResponseFormatAspectRatio.AspectRatioFourByThree,
                "ASPECT_RATIO_NINE_BY_SIXTEEN" => ImageResponseFormatAspectRatio.AspectRatioNineBySixteen,
                "ASPECT_RATIO_ONE_BY_EIGHT" => ImageResponseFormatAspectRatio.AspectRatioOneByEight,
                "ASPECT_RATIO_ONE_BY_FOUR" => ImageResponseFormatAspectRatio.AspectRatioOneByFour,
                "ASPECT_RATIO_ONE_BY_ONE" => ImageResponseFormatAspectRatio.AspectRatioOneByOne,
                "ASPECT_RATIO_SIXTEEN_BY_NINE" => ImageResponseFormatAspectRatio.AspectRatioSixteenByNine,
                "ASPECT_RATIO_THREE_BY_FOUR" => ImageResponseFormatAspectRatio.AspectRatioThreeByFour,
                "ASPECT_RATIO_THREE_BY_TWO" => ImageResponseFormatAspectRatio.AspectRatioThreeByTwo,
                "ASPECT_RATIO_TWENTY_ONE_BY_NINE" => ImageResponseFormatAspectRatio.AspectRatioTwentyOneByNine,
                "ASPECT_RATIO_TWO_BY_THREE" => ImageResponseFormatAspectRatio.AspectRatioTwoByThree,
                "ASPECT_RATIO_UNSPECIFIED" => ImageResponseFormatAspectRatio.AspectRatioUnspecified,
                _ => null,
            };
        }
    }
}