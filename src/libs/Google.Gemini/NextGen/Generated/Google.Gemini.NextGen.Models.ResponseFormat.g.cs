#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ResponseFormat : global::System.IEquatable<ResponseFormat>
    {
        /// <summary>
        /// Configuration for audio output format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.AudioResponseFormat? Audio { get; init; }
#else
        public global::Google.Gemini.NextGen.AudioResponseFormat? Audio { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.AudioResponseFormat? value)
        {
            value = Audio;
            return IsAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioResponseFormat PickAudio() => Audio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Audio' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for image output format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.ImageResponseFormat? Image { get; init; }
#else
        public global::Google.Gemini.NextGen.ImageResponseFormat? Image { get; }
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
            out global::Google.Gemini.NextGen.ImageResponseFormat? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.ImageResponseFormat PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for text output format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.TextResponseFormat? Text { get; init; }
#else
        public global::Google.Gemini.NextGen.TextResponseFormat? Text { get; }
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
            out global::Google.Gemini.NextGen.TextResponseFormat? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.TextResponseFormat PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for video output format.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.VideoResponseFormat? Video { get; init; }
#else
        public global::Google.Gemini.NextGen.VideoResponseFormat? Video { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.VideoResponseFormat? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoResponseFormat PickVideo() => Video is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Video' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ResponseFormatVariant5 { get; init; }
#else
        public object? ResponseFormatVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFormatVariant5))]
#endif
        public bool IsResponseFormatVariant5 => ResponseFormatVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFormatVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ResponseFormatVariant5;
            return IsResponseFormatVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickResponseFormatVariant5() => ResponseFormatVariant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFormatVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormat(global::Google.Gemini.NextGen.AudioResponseFormat value) => new ResponseFormat((global::Google.Gemini.NextGen.AudioResponseFormat?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.AudioResponseFormat?(ResponseFormat @this) => @this.Audio;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat(global::Google.Gemini.NextGen.AudioResponseFormat? value)
        {
            Audio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormat FromAudio(global::Google.Gemini.NextGen.AudioResponseFormat? value) => new ResponseFormat(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormat(global::Google.Gemini.NextGen.ImageResponseFormat value) => new ResponseFormat((global::Google.Gemini.NextGen.ImageResponseFormat?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ImageResponseFormat?(ResponseFormat @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat(global::Google.Gemini.NextGen.ImageResponseFormat? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormat FromImage(global::Google.Gemini.NextGen.ImageResponseFormat? value) => new ResponseFormat(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormat(global::Google.Gemini.NextGen.TextResponseFormat value) => new ResponseFormat((global::Google.Gemini.NextGen.TextResponseFormat?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.TextResponseFormat?(ResponseFormat @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat(global::Google.Gemini.NextGen.TextResponseFormat? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormat FromText(global::Google.Gemini.NextGen.TextResponseFormat? value) => new ResponseFormat(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseFormat(global::Google.Gemini.NextGen.VideoResponseFormat value) => new ResponseFormat((global::Google.Gemini.NextGen.VideoResponseFormat?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.VideoResponseFormat?(ResponseFormat @this) => @this.Video;

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat(global::Google.Gemini.NextGen.VideoResponseFormat? value)
        {
            Video = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseFormat FromVideo(global::Google.Gemini.NextGen.VideoResponseFormat? value) => new ResponseFormat(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseFormat(
            global::Google.Gemini.NextGen.AudioResponseFormat? audio,
            global::Google.Gemini.NextGen.ImageResponseFormat? image,
            global::Google.Gemini.NextGen.TextResponseFormat? text,
            global::Google.Gemini.NextGen.VideoResponseFormat? video,
            object? responseFormatVariant5
            )
        {
            Audio = audio;
            Image = image;
            Text = text;
            Video = video;
            ResponseFormatVariant5 = responseFormatVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ResponseFormatVariant5 as object ??
            Video as object ??
            Text as object ??
            Image as object ??
            Audio as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Audio?.ToString() ??
            Image?.ToString() ??
            Text?.ToString() ??
            Video?.ToString() ??
            ResponseFormatVariant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAudio && !IsImage && !IsText && !IsVideo && !IsResponseFormatVariant5 || !IsAudio && IsImage && !IsText && !IsVideo && !IsResponseFormatVariant5 || !IsAudio && !IsImage && IsText && !IsVideo && !IsResponseFormatVariant5 || !IsAudio && !IsImage && !IsText && IsVideo && !IsResponseFormatVariant5 || !IsAudio && !IsImage && !IsText && !IsVideo && IsResponseFormatVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.AudioResponseFormat, TResult>? audio = null,
            global::System.Func<global::Google.Gemini.NextGen.ImageResponseFormat, TResult>? image = null,
            global::System.Func<global::Google.Gemini.NextGen.TextResponseFormat, TResult>? text = null,
            global::System.Func<global::Google.Gemini.NextGen.VideoResponseFormat, TResult>? video = null,
            global::System.Func<object, TResult>? responseFormatVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Audio is { } __value0 && audio != null)
            {
                return audio(__value0);
            }
            else if (Image is { } __value1 && image != null)
            {
                return image(__value1);
            }
            else if (Text is { } __value2 && text != null)
            {
                return text(__value2);
            }
            else if (Video is { } __value3 && video != null)
            {
                return video(__value3);
            }
            else if (ResponseFormatVariant5 is { } __value4 && responseFormatVariant5 != null)
            {
                return responseFormatVariant5(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.AudioResponseFormat>? audio = null,

            global::System.Action<global::Google.Gemini.NextGen.ImageResponseFormat>? image = null,

            global::System.Action<global::Google.Gemini.NextGen.TextResponseFormat>? text = null,

            global::System.Action<global::Google.Gemini.NextGen.VideoResponseFormat>? video = null,

            global::System.Action<object>? responseFormatVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Audio is { } __value0)
            {
                audio?.Invoke(__value0);
            }
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
            }
            else if (Text is { } __value2)
            {
                text?.Invoke(__value2);
            }
            else if (Video is { } __value3)
            {
                video?.Invoke(__value3);
            }
            else if (ResponseFormatVariant5 is { } __value4)
            {
                responseFormatVariant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.AudioResponseFormat>? audio = null,
            global::System.Action<global::Google.Gemini.NextGen.ImageResponseFormat>? image = null,
            global::System.Action<global::Google.Gemini.NextGen.TextResponseFormat>? text = null,
            global::System.Action<global::Google.Gemini.NextGen.VideoResponseFormat>? video = null,
            global::System.Action<object>? responseFormatVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Audio is { } __value0)
            {
                audio?.Invoke(__value0);
            }
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
            }
            else if (Text is { } __value2)
            {
                text?.Invoke(__value2);
            }
            else if (Video is { } __value3)
            {
                video?.Invoke(__value3);
            }
            else if (ResponseFormatVariant5 is { } __value4)
            {
                responseFormatVariant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Audio,
                typeof(global::Google.Gemini.NextGen.AudioResponseFormat),
                Image,
                typeof(global::Google.Gemini.NextGen.ImageResponseFormat),
                Text,
                typeof(global::Google.Gemini.NextGen.TextResponseFormat),
                Video,
                typeof(global::Google.Gemini.NextGen.VideoResponseFormat),
                ResponseFormatVariant5,
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
        public bool Equals(ResponseFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.AudioResponseFormat?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ImageResponseFormat?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.TextResponseFormat?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.VideoResponseFormat?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ResponseFormatVariant5, other.ResponseFormatVariant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseFormat obj1, ResponseFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseFormat obj1, ResponseFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormat o && Equals(o);
        }
    }
}
