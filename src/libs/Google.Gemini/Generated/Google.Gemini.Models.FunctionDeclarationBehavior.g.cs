
#nullable enable

namespace Google.Gemini
{
    /// <summary>
    /// Optional. Specifies the function Behavior. Currently only supported by the BidiGenerateContent method.
    /// </summary>
    public enum FunctionDeclarationBehavior
    {
        /// <summary>
        /// This value is unused.
        /// </summary>
        Unspecified,
        /// <summary>
        /// If set, the system will wait to receive the function response before continuing the conversation.
        /// </summary>
        Blocking,
        /// <summary>
        /// If set, the system will not wait to receive the function response. Instead, it will attempt to handle function responses as they become available while maintaining the conversation between the user and the model.
        /// </summary>
        NonBlocking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDeclarationBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDeclarationBehavior value)
        {
            return value switch
            {
                FunctionDeclarationBehavior.Unspecified => "UNSPECIFIED",
                FunctionDeclarationBehavior.Blocking => "BLOCKING",
                FunctionDeclarationBehavior.NonBlocking => "NON_BLOCKING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDeclarationBehavior? ToEnum(string value)
        {
            return value switch
            {
                "UNSPECIFIED" => FunctionDeclarationBehavior.Unspecified,
                "BLOCKING" => FunctionDeclarationBehavior.Blocking,
                "NON_BLOCKING" => FunctionDeclarationBehavior.NonBlocking,
                _ => null,
            };
        }
    }
}