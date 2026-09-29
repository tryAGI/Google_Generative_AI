#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ResponseFormat4 : global::System.IEquatable<ResponseFormat4>
    {
        /// <summary>
        /// Configuration for audio output format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.AudioResponseFormat? AudioFormat { get; init; }
#else
        public global::Google.Gemini.NextGen.AudioResponseFormat? AudioFormat { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioFormat))]
#endif
        public bool IsAudioFormat => AudioFormat != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioFormat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.AudioResponseFormat? value)
        {
            value = AudioFormat;
            return IsAudioFormat;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormat PickAudioFormat() => IsAudioFormat
            ? AudioFormat!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioFormat' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for image output format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ImageResponseFormat? ImageFormat { get; init; }
#else
        public global::Google.Gemini.NextGen.ImageResponseFormat? ImageFormat { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageFormat))]
#endif
        public bool IsImageFormat => ImageFormat != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageFormat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.ImageResponseFormat? value)
        {
            value = ImageFormat;
            return IsImageFormat;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormat PickImageFormat() => IsImageFormat
            ? ImageFormat!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageFormat' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for text output format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.TextResponseFormat? TextFormat { get; init; }
#else
        public global::Google.Gemini.NextGen.TextResponseFormat? TextFormat { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextFormat))]
#endif
        public bool IsTextFormat => TextFormat != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextFormat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.TextResponseFormat? value)
        {
            value = TextFormat;
            return IsTextFormat;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextResponseFormat PickTextFormat() => IsTextFormat
            ? TextFormat!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextFormat' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for video output format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.VideoResponseFormat? VideoFormat { get; init; }
#else
        public global::Google.Gemini.NextGen.VideoResponseFormat? VideoFormat { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoFormat))]
#endif
        public bool IsVideoFormat => VideoFormat != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideoFormat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.VideoResponseFormat? value)
        {
            value = VideoFormat;
            return IsVideoFormat;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormat PickVideoFormat() => IsVideoFormat
            ? VideoFormat!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoFormat' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? FormatVariant5 { get; init; }
#else
        public object? FormatVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FormatVariant5))]
#endif
        public bool IsFormatVariant5 => FormatVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFormatVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = FormatVariant5;
            return IsFormatVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickFormatVariant5() => IsFormatVariant5
            ? FormatVariant5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FormatVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormat4(global::Google.Gemini.NextGen.AudioResponseFormat value) => new ResponseFormat4((global::Google.Gemini.NextGen.AudioResponseFormat?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.AudioResponseFormat?(ResponseFormat4 @this) => @this.AudioFormat;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat4(global::Google.Gemini.NextGen.AudioResponseFormat? value)
        {
            AudioFormat = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormat4 FromAudioFormat(global::Google.Gemini.NextGen.AudioResponseFormat? value) => new ResponseFormat4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormat4(global::Google.Gemini.NextGen.ImageResponseFormat value) => new ResponseFormat4((global::Google.Gemini.NextGen.ImageResponseFormat?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ImageResponseFormat?(ResponseFormat4 @this) => @this.ImageFormat;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat4(global::Google.Gemini.NextGen.ImageResponseFormat? value)
        {
            ImageFormat = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormat4 FromImageFormat(global::Google.Gemini.NextGen.ImageResponseFormat? value) => new ResponseFormat4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormat4(global::Google.Gemini.NextGen.TextResponseFormat value) => new ResponseFormat4((global::Google.Gemini.NextGen.TextResponseFormat?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.TextResponseFormat?(ResponseFormat4 @this) => @this.TextFormat;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat4(global::Google.Gemini.NextGen.TextResponseFormat? value)
        {
            TextFormat = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormat4 FromTextFormat(global::Google.Gemini.NextGen.TextResponseFormat? value) => new ResponseFormat4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormat4(global::Google.Gemini.NextGen.VideoResponseFormat value) => new ResponseFormat4((global::Google.Gemini.NextGen.VideoResponseFormat?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.VideoResponseFormat?(ResponseFormat4 @this) => @this.VideoFormat;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat4(global::Google.Gemini.NextGen.VideoResponseFormat? value)
        {
            VideoFormat = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormat4 FromVideoFormat(global::Google.Gemini.NextGen.VideoResponseFormat? value) => new ResponseFormat4(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat4(
            global::Google.Gemini.NextGen.AudioResponseFormat? audioFormat,
            global::Google.Gemini.NextGen.ImageResponseFormat? imageFormat,
            global::Google.Gemini.NextGen.TextResponseFormat? textFormat,
            global::Google.Gemini.NextGen.VideoResponseFormat? videoFormat,
            object? formatVariant5
            )
        {
            AudioFormat = audioFormat;
            ImageFormat = imageFormat;
            TextFormat = textFormat;
            VideoFormat = videoFormat;
            FormatVariant5 = formatVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FormatVariant5 as object ??
            VideoFormat as object ??
            TextFormat as object ??
            ImageFormat as object ??
            AudioFormat as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AudioFormat?.ToString() ??
            ImageFormat?.ToString() ??
            TextFormat?.ToString() ??
            VideoFormat?.ToString() ??
            FormatVariant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAudioFormat && !IsImageFormat && !IsTextFormat && !IsVideoFormat && !IsFormatVariant5 || !IsAudioFormat && IsImageFormat && !IsTextFormat && !IsVideoFormat && !IsFormatVariant5 || !IsAudioFormat && !IsImageFormat && IsTextFormat && !IsVideoFormat && !IsFormatVariant5 || !IsAudioFormat && !IsImageFormat && !IsTextFormat && IsVideoFormat && !IsFormatVariant5 || !IsAudioFormat && !IsImageFormat && !IsTextFormat && !IsVideoFormat && IsFormatVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.AudioResponseFormat, TResult>? audioFormat = null,
            global::System.Func<global::Google.Gemini.NextGen.ImageResponseFormat, TResult>? imageFormat = null,
            global::System.Func<global::Google.Gemini.NextGen.TextResponseFormat, TResult>? textFormat = null,
            global::System.Func<global::Google.Gemini.NextGen.VideoResponseFormat, TResult>? videoFormat = null,
            global::System.Func<object, TResult>? formatVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioFormat && audioFormat != null)
            {
                return audioFormat(AudioFormat!);
            }
            else if (IsImageFormat && imageFormat != null)
            {
                return imageFormat(ImageFormat!);
            }
            else if (IsTextFormat && textFormat != null)
            {
                return textFormat(TextFormat!);
            }
            else if (IsVideoFormat && videoFormat != null)
            {
                return videoFormat(VideoFormat!);
            }
            else if (IsFormatVariant5 && formatVariant5 != null)
            {
                return formatVariant5(FormatVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.AudioResponseFormat>? audioFormat = null,

            global::System.Action<global::Google.Gemini.NextGen.ImageResponseFormat>? imageFormat = null,

            global::System.Action<global::Google.Gemini.NextGen.TextResponseFormat>? textFormat = null,

            global::System.Action<global::Google.Gemini.NextGen.VideoResponseFormat>? videoFormat = null,

            global::System.Action<object>? formatVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioFormat)
            {
                audioFormat?.Invoke(AudioFormat!);
            }
            else if (IsImageFormat)
            {
                imageFormat?.Invoke(ImageFormat!);
            }
            else if (IsTextFormat)
            {
                textFormat?.Invoke(TextFormat!);
            }
            else if (IsVideoFormat)
            {
                videoFormat?.Invoke(VideoFormat!);
            }
            else if (IsFormatVariant5)
            {
                formatVariant5?.Invoke(FormatVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.AudioResponseFormat>? audioFormat = null,
            global::System.Action<global::Google.Gemini.NextGen.ImageResponseFormat>? imageFormat = null,
            global::System.Action<global::Google.Gemini.NextGen.TextResponseFormat>? textFormat = null,
            global::System.Action<global::Google.Gemini.NextGen.VideoResponseFormat>? videoFormat = null,
            global::System.Action<object>? formatVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudioFormat)
            {
                audioFormat?.Invoke(AudioFormat!);
            }
            else if (IsImageFormat)
            {
                imageFormat?.Invoke(ImageFormat!);
            }
            else if (IsTextFormat)
            {
                textFormat?.Invoke(TextFormat!);
            }
            else if (IsVideoFormat)
            {
                videoFormat?.Invoke(VideoFormat!);
            }
            else if (IsFormatVariant5)
            {
                formatVariant5?.Invoke(FormatVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AudioFormat,
                typeof(global::Google.Gemini.NextGen.AudioResponseFormat),
                ImageFormat,
                typeof(global::Google.Gemini.NextGen.ImageResponseFormat),
                TextFormat,
                typeof(global::Google.Gemini.NextGen.TextResponseFormat),
                VideoFormat,
                typeof(global::Google.Gemini.NextGen.VideoResponseFormat),
                FormatVariant5,
                typeof(object),
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
        public bool Equals(ResponseFormat4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.AudioResponseFormat?>.Default.Equals(AudioFormat, other.AudioFormat) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ImageResponseFormat?>.Default.Equals(ImageFormat, other.ImageFormat) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.TextResponseFormat?>.Default.Equals(TextFormat, other.TextFormat) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.VideoResponseFormat?>.Default.Equals(VideoFormat, other.VideoFormat) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(FormatVariant5, other.FormatVariant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseFormat4 obj1, ResponseFormat4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormat4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseFormat4 obj1, ResponseFormat4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormat4 o && Equals(o);
        }
    }
}
