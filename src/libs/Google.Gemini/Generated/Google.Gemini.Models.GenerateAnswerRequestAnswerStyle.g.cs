
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Required. Style in which answers should be returned.
    /// </summary>
    public enum GenerateAnswerRequestAnswerStyle
    {
        /// <summary>
        /// 
        /// </summary>
        AnswerStyleUnspecified,
        /// <summary>
        /// 
        /// </summary>
        Abstractive,
        /// <summary>
        /// 
        /// </summary>
        Extractive,
        /// <summary>
        /// 
        /// </summary>
        Verbose,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateAnswerRequestAnswerStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateAnswerRequestAnswerStyle value)
        {
            return value switch
            {
                GenerateAnswerRequestAnswerStyle.AnswerStyleUnspecified => "ANSWER_STYLE_UNSPECIFIED",
                GenerateAnswerRequestAnswerStyle.Abstractive => "ABSTRACTIVE",
                GenerateAnswerRequestAnswerStyle.Extractive => "EXTRACTIVE",
                GenerateAnswerRequestAnswerStyle.Verbose => "VERBOSE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateAnswerRequestAnswerStyle? ToEnum(string value)
        {
            return value switch
            {
                "ANSWER_STYLE_UNSPECIFIED" => GenerateAnswerRequestAnswerStyle.AnswerStyleUnspecified,
                "ABSTRACTIVE" => GenerateAnswerRequestAnswerStyle.Abstractive,
                "EXTRACTIVE" => GenerateAnswerRequestAnswerStyle.Extractive,
                "VERBOSE" => GenerateAnswerRequestAnswerStyle.Verbose,
                _ => null,
            };
        }
    }
}