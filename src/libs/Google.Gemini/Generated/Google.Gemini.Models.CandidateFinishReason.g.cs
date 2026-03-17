
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. Output only. The reason why the model stopped generating tokens. If empty, the model has not stopped generating tokens.<br/>
    /// Included only in responses
    /// </summary>
    public enum CandidateFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        FinishReasonUnspecified,
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        Safety,
        /// <summary>
        /// 
        /// </summary>
        Recitation,
        /// <summary>
        /// 
        /// </summary>
        Language,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Blocklist,
        /// <summary>
        /// 
        /// </summary>
        ProhibitedContent,
        /// <summary>
        /// 
        /// </summary>
        Spii,
        /// <summary>
        /// 
        /// </summary>
        MalformedFunctionCall,
        /// <summary>
        /// 
        /// </summary>
        ImageSafety,
        /// <summary>
        /// 
        /// </summary>
        ImageProhibitedContent,
        /// <summary>
        /// 
        /// </summary>
        ImageOther,
        /// <summary>
        /// 
        /// </summary>
        NoImage,
        /// <summary>
        /// 
        /// </summary>
        ImageRecitation,
        /// <summary>
        /// 
        /// </summary>
        UnexpectedToolCall,
        /// <summary>
        /// 
        /// </summary>
        TooManyToolCalls,
        /// <summary>
        /// 
        /// </summary>
        MissingThoughtSignature,
        /// <summary>
        /// 
        /// </summary>
        MalformedResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CandidateFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CandidateFinishReason value)
        {
            return value switch
            {
                CandidateFinishReason.FinishReasonUnspecified => "FINISH_REASON_UNSPECIFIED",
                CandidateFinishReason.Stop => "STOP",
                CandidateFinishReason.MaxTokens => "MAX_TOKENS",
                CandidateFinishReason.Safety => "SAFETY",
                CandidateFinishReason.Recitation => "RECITATION",
                CandidateFinishReason.Language => "LANGUAGE",
                CandidateFinishReason.Other => "OTHER",
                CandidateFinishReason.Blocklist => "BLOCKLIST",
                CandidateFinishReason.ProhibitedContent => "PROHIBITED_CONTENT",
                CandidateFinishReason.Spii => "SPII",
                CandidateFinishReason.MalformedFunctionCall => "MALFORMED_FUNCTION_CALL",
                CandidateFinishReason.ImageSafety => "IMAGE_SAFETY",
                CandidateFinishReason.ImageProhibitedContent => "IMAGE_PROHIBITED_CONTENT",
                CandidateFinishReason.ImageOther => "IMAGE_OTHER",
                CandidateFinishReason.NoImage => "NO_IMAGE",
                CandidateFinishReason.ImageRecitation => "IMAGE_RECITATION",
                CandidateFinishReason.UnexpectedToolCall => "UNEXPECTED_TOOL_CALL",
                CandidateFinishReason.TooManyToolCalls => "TOO_MANY_TOOL_CALLS",
                CandidateFinishReason.MissingThoughtSignature => "MISSING_THOUGHT_SIGNATURE",
                CandidateFinishReason.MalformedResponse => "MALFORMED_RESPONSE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CandidateFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "FINISH_REASON_UNSPECIFIED" => CandidateFinishReason.FinishReasonUnspecified,
                "STOP" => CandidateFinishReason.Stop,
                "MAX_TOKENS" => CandidateFinishReason.MaxTokens,
                "SAFETY" => CandidateFinishReason.Safety,
                "RECITATION" => CandidateFinishReason.Recitation,
                "LANGUAGE" => CandidateFinishReason.Language,
                "OTHER" => CandidateFinishReason.Other,
                "BLOCKLIST" => CandidateFinishReason.Blocklist,
                "PROHIBITED_CONTENT" => CandidateFinishReason.ProhibitedContent,
                "SPII" => CandidateFinishReason.Spii,
                "MALFORMED_FUNCTION_CALL" => CandidateFinishReason.MalformedFunctionCall,
                "IMAGE_SAFETY" => CandidateFinishReason.ImageSafety,
                "IMAGE_PROHIBITED_CONTENT" => CandidateFinishReason.ImageProhibitedContent,
                "IMAGE_OTHER" => CandidateFinishReason.ImageOther,
                "NO_IMAGE" => CandidateFinishReason.NoImage,
                "IMAGE_RECITATION" => CandidateFinishReason.ImageRecitation,
                "UNEXPECTED_TOOL_CALL" => CandidateFinishReason.UnexpectedToolCall,
                "TOO_MANY_TOOL_CALLS" => CandidateFinishReason.TooManyToolCalls,
                "MISSING_THOUGHT_SIGNATURE" => CandidateFinishReason.MissingThoughtSignature,
                "MALFORMED_RESPONSE" => CandidateFinishReason.MalformedResponse,
                _ => null,
            };
        }
    }
}