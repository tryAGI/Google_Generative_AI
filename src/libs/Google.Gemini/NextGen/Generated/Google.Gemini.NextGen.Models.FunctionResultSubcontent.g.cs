#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct FunctionResultSubcontent : global::System.IEquatable<FunctionResultSubcontent>
    {
        /// <summary>
        /// An image content block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ImageContent? ImageContent { get; init; }
#else
        public global::Google.Gemini.NextGen.ImageContent? ImageContent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageContent))]
#endif
        public bool IsImageContent => ImageContent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageContent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ImageContent? value)
        {
            value = ImageContent;
            return IsImageContent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageContent PickImageContent() => ImageContent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageContent' but the value was {ToString()}.");

        /// <summary>
        /// A text content block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.TextContent? TextContent { get; init; }
#else
        public global::Google.Gemini.NextGen.TextContent? TextContent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextContent))]
#endif
        public bool IsTextContent => TextContent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextContent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.TextContent? value)
        {
            value = TextContent;
            return IsTextContent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextContent PickTextContent() => TextContent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextContent' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator FunctionResultSubcontent(global::Google.Gemini.NextGen.ImageContent value) => new FunctionResultSubcontent((global::Google.Gemini.NextGen.ImageContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ImageContent?(FunctionResultSubcontent @this) => @this.ImageContent;

        /// <summary>
        ///
        /// </summary>
        public FunctionResultSubcontent(global::Google.Gemini.NextGen.ImageContent? value)
        {
            ImageContent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FunctionResultSubcontent FromImageContent(global::Google.Gemini.NextGen.ImageContent? value) => new FunctionResultSubcontent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator FunctionResultSubcontent(global::Google.Gemini.NextGen.TextContent value) => new FunctionResultSubcontent((global::Google.Gemini.NextGen.TextContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.TextContent?(FunctionResultSubcontent @this) => @this.TextContent;

        /// <summary>
        ///
        /// </summary>
        public FunctionResultSubcontent(global::Google.Gemini.NextGen.TextContent? value)
        {
            TextContent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static FunctionResultSubcontent FromTextContent(global::Google.Gemini.NextGen.TextContent? value) => new FunctionResultSubcontent(value);

        /// <summary>
        ///
        /// </summary>
        public FunctionResultSubcontent(
            global::Google.Gemini.NextGen.ImageContent? imageContent,
            global::Google.Gemini.NextGen.TextContent? textContent
            )
        {
            ImageContent = imageContent;
            TextContent = textContent;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TextContent as object ??
            ImageContent as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ImageContent?.ToString() ??
            TextContent?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsImageContent && !IsTextContent || !IsImageContent && IsTextContent;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.ImageContent, TResult>? imageContent = null,
            global::System.Func<global::Google.Gemini.NextGen.TextContent, TResult>? textContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ImageContent is { } __value0 && imageContent != null)
            {
                return imageContent(__value0);
            }
            else if (TextContent is { } __value1 && textContent != null)
            {
                return textContent(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.ImageContent>? imageContent = null,

            global::System.Action<global::Google.Gemini.NextGen.TextContent>? textContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ImageContent is { } __value0)
            {
                imageContent?.Invoke(__value0);
            }
            else if (TextContent is { } __value1)
            {
                textContent?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.ImageContent>? imageContent = null,
            global::System.Action<global::Google.Gemini.NextGen.TextContent>? textContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ImageContent is { } __value0)
            {
                imageContent?.Invoke(__value0);
            }
            else if (TextContent is { } __value1)
            {
                textContent?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImageContent,
                typeof(global::Google.Gemini.NextGen.ImageContent),
                TextContent,
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
        public bool Equals(FunctionResultSubcontent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ImageContent?>.Default.Equals(ImageContent, other.ImageContent) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.TextContent?>.Default.Equals(TextContent, other.TextContent)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(FunctionResultSubcontent obj1, FunctionResultSubcontent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionResultSubcontent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FunctionResultSubcontent obj1, FunctionResultSubcontent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionResultSubcontent o && Equals(o);
        }
    }
}
