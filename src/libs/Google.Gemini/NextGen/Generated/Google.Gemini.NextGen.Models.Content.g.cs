#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// The content of the response.
    /// </summary>
    public readonly partial struct Content : global::System.IEquatable<Content>
    {
        /// <summary>
        /// An audio content block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.AudioContent? Audio { get; init; }
#else
        public global::Google.Gemini.NextGen.AudioContent? Audio { get; }
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
            out global::Google.Gemini.NextGen.AudioContent? value)
        {
            value = Audio;
            return IsAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioContent PickAudio() => IsAudio
            ? Audio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Audio' but the value was {ToString()}.");

        /// <summary>
        /// A document content block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.DocumentContent? Document { get; init; }
#else
        public global::Google.Gemini.NextGen.DocumentContent? Document { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Document))]
#endif
        public bool IsDocument => Document != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDocument(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.DocumentContent? value)
        {
            value = Document;
            return IsDocument;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DocumentContent PickDocument() => IsDocument
            ? Document!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Document' but the value was {ToString()}.");

        /// <summary>
        /// An image content block.
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
        public global::Google.Gemini.NextGen.ImageContent PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

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
        public global::Google.Gemini.NextGen.TextContent PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// A video content block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.VideoContent? Video { get; init; }
#else
        public global::Google.Gemini.NextGen.VideoContent? Video { get; }
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
            out global::Google.Gemini.NextGen.VideoContent? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VideoContent PickVideo() => IsVideo
            ? Video!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Video' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Content(global::Google.Gemini.NextGen.AudioContent value) => new Content((global::Google.Gemini.NextGen.AudioContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.AudioContent?(Content @this) => @this.Audio;

        /// <summary>
        ///
        /// </summary>
        public Content(global::Google.Gemini.NextGen.AudioContent? value)
        {
            Audio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Content FromAudio(global::Google.Gemini.NextGen.AudioContent? value) => new Content(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Content(global::Google.Gemini.NextGen.DocumentContent value) => new Content((global::Google.Gemini.NextGen.DocumentContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.DocumentContent?(Content @this) => @this.Document;

        /// <summary>
        ///
        /// </summary>
        public Content(global::Google.Gemini.NextGen.DocumentContent? value)
        {
            Document = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Content FromDocument(global::Google.Gemini.NextGen.DocumentContent? value) => new Content(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Content(global::Google.Gemini.NextGen.ImageContent value) => new Content((global::Google.Gemini.NextGen.ImageContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.ImageContent?(Content @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public Content(global::Google.Gemini.NextGen.ImageContent? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Content FromImage(global::Google.Gemini.NextGen.ImageContent? value) => new Content(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Content(global::Google.Gemini.NextGen.TextContent value) => new Content((global::Google.Gemini.NextGen.TextContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.TextContent?(Content @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public Content(global::Google.Gemini.NextGen.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Content FromText(global::Google.Gemini.NextGen.TextContent? value) => new Content(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Content(global::Google.Gemini.NextGen.VideoContent value) => new Content((global::Google.Gemini.NextGen.VideoContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.VideoContent?(Content @this) => @this.Video;

        /// <summary>
        ///
        /// </summary>
        public Content(global::Google.Gemini.NextGen.VideoContent? value)
        {
            Video = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Content FromVideo(global::Google.Gemini.NextGen.VideoContent? value) => new Content(value);

        /// <summary>
        ///
        /// </summary>
        public Content(
            global::Google.Gemini.NextGen.AudioContent? audio,
            global::Google.Gemini.NextGen.DocumentContent? document,
            global::Google.Gemini.NextGen.ImageContent? image,
            global::Google.Gemini.NextGen.TextContent? text,
            global::Google.Gemini.NextGen.VideoContent? video
            )
        {
            Audio = audio;
            Document = document;
            Image = image;
            Text = text;
            Video = video;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Video as object ??
            Text as object ??
            Image as object ??
            Document as object ??
            Audio as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Audio?.ToString() ??
            Document?.ToString() ??
            Image?.ToString() ??
            Text?.ToString() ??
            Video?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAudio && !IsDocument && !IsImage && !IsText && !IsVideo || !IsAudio && IsDocument && !IsImage && !IsText && !IsVideo || !IsAudio && !IsDocument && IsImage && !IsText && !IsVideo || !IsAudio && !IsDocument && !IsImage && IsText && !IsVideo || !IsAudio && !IsDocument && !IsImage && !IsText && IsVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.AudioContent, TResult>? audio = null,
            global::System.Func<global::Google.Gemini.NextGen.DocumentContent, TResult>? document = null,
            global::System.Func<global::Google.Gemini.NextGen.ImageContent, TResult>? image = null,
            global::System.Func<global::Google.Gemini.NextGen.TextContent, TResult>? text = null,
            global::System.Func<global::Google.Gemini.NextGen.VideoContent, TResult>? video = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }
            else if (IsDocument && document != null)
            {
                return document(Document!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsVideo && video != null)
            {
                return video(Video!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.AudioContent>? audio = null,

            global::System.Action<global::Google.Gemini.NextGen.DocumentContent>? document = null,

            global::System.Action<global::Google.Gemini.NextGen.ImageContent>? image = null,

            global::System.Action<global::Google.Gemini.NextGen.TextContent>? text = null,

            global::System.Action<global::Google.Gemini.NextGen.VideoContent>? video = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.AudioContent>? audio = null,
            global::System.Action<global::Google.Gemini.NextGen.DocumentContent>? document = null,
            global::System.Action<global::Google.Gemini.NextGen.ImageContent>? image = null,
            global::System.Action<global::Google.Gemini.NextGen.TextContent>? text = null,
            global::System.Action<global::Google.Gemini.NextGen.VideoContent>? video = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
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
                typeof(global::Google.Gemini.NextGen.AudioContent),
                Document,
                typeof(global::Google.Gemini.NextGen.DocumentContent),
                Image,
                typeof(global::Google.Gemini.NextGen.ImageContent),
                Text,
                typeof(global::Google.Gemini.NextGen.TextContent),
                Video,
                typeof(global::Google.Gemini.NextGen.VideoContent),
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
        public bool Equals(Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.AudioContent?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.DocumentContent?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.ImageContent?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.TextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.VideoContent?>.Default.Equals(Video, other.Video)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Content obj1, Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Content obj1, Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Content o && Equals(o);
        }
    }
}
