#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DecisionInstructionContent : global::System.IEquatable<DecisionInstructionContent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminatorType? Type { get; }

        /// <summary>
        /// A text content block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.TextContent? Text { get; init; }
#else
        public global::Google.Gemini.NextGen.TextContent? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.TextContent? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextContent PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionInstructionContent(global::Google.Gemini.NextGen.TextContent value) => new DecisionInstructionContent((global::Google.Gemini.NextGen.TextContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.TextContent?(DecisionInstructionContent @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public DecisionInstructionContent(global::Google.Gemini.NextGen.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionInstructionContent FromText(global::Google.Gemini.NextGen.TextContent? value) => new DecisionInstructionContent(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionInstructionContent(
            global::Google.Gemini.NextGen.DecisionInstructionContentDiscriminatorType? type,
            global::Google.Gemini.NextGen.TextContent? text
            )
        {
            Type = type;

            Text = text;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.TextContent, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.TextContent>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.TextContent>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Google.Gemini.NextGen.TextContent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(DecisionInstructionContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.TextContent?>.Default.Equals(Text, other.Text)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionInstructionContent obj1, DecisionInstructionContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionInstructionContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionInstructionContent obj1, DecisionInstructionContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionInstructionContent o && Equals(o);
        }
    }
}
