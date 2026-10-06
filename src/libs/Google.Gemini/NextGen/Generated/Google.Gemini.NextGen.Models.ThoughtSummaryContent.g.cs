#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ThoughtSummaryContent : global::System.IEquatable<ThoughtSummaryContent>
    {
        /// <summary>
        /// An image content block.<br/>
        /// Example: {"type":"image","data":"BASE64_ENCODED_IMAGE","mime_type":"image/png"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ImageContent? Image { get; init; }
#else
        public global::Google.Gemini.NextGen.ImageContent? Image { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ImageContent? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageContent PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        /// A text content block.<br/>
        /// Example: {"type":"text","text":"Hello, how are you?"}
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
        public static implicit operator ThoughtSummaryContent(global::Google.Gemini.NextGen.ImageContent value) => new ThoughtSummaryContent((global::Google.Gemini.NextGen.ImageContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ImageContent?(ThoughtSummaryContent @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public ThoughtSummaryContent(global::Google.Gemini.NextGen.ImageContent? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ThoughtSummaryContent FromImage(global::Google.Gemini.NextGen.ImageContent? value) => new ThoughtSummaryContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ThoughtSummaryContent(global::Google.Gemini.NextGen.TextContent value) => new ThoughtSummaryContent((global::Google.Gemini.NextGen.TextContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.TextContent?(ThoughtSummaryContent @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ThoughtSummaryContent(global::Google.Gemini.NextGen.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ThoughtSummaryContent FromText(global::Google.Gemini.NextGen.TextContent? value) => new ThoughtSummaryContent(value);

        /// <summary>
        ///
        /// </summary>
        public ThoughtSummaryContent(
            global::Google.Gemini.NextGen.ImageContent? image,
            global::Google.Gemini.NextGen.TextContent? text
            )
        {
            Image = image;
            Text = text;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Text as object ??
            Image as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Image?.ToString() ??
            Text?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsImage && !IsText || !IsImage && IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.ImageContent, TResult>? image = null,
            global::System.Func<global::Google.Gemini.NextGen.TextContent, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Image is { } __value0 && image != null)
            {
                return image(__value0);
            }
            else if (Text is { } __value1 && text != null)
            {
                return text(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.ImageContent>? image = null,

            global::System.Action<global::Google.Gemini.NextGen.TextContent>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Image is { } __value0)
            {
                image?.Invoke(__value0);
            }
            else if (Text is { } __value1)
            {
                text?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.ImageContent>? image = null,
            global::System.Action<global::Google.Gemini.NextGen.TextContent>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Image is { } __value0)
            {
                image?.Invoke(__value0);
            }
            else if (Text is { } __value1)
            {
                text?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Image,
                typeof(global::Google.Gemini.NextGen.ImageContent),
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
        public bool Equals(ThoughtSummaryContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ImageContent?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.TextContent?>.Default.Equals(Text, other.Text)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ThoughtSummaryContent obj1, ThoughtSummaryContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ThoughtSummaryContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ThoughtSummaryContent obj1, ThoughtSummaryContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ThoughtSummaryContent o && Equals(o);
        }
    }
}
