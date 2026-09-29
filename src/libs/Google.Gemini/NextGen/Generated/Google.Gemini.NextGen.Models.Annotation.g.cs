#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Citation information for model-generated content.
    /// </summary>
    public readonly partial struct Annotation : global::System.IEquatable<Annotation>
    {
        /// <summary>
        /// A file citation annotation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.FileCitation? FileCitation { get; init; }
#else
        public global::Google.Gemini.NextGen.FileCitation? FileCitation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileCitation))]
#endif
        public bool IsFileCitation => FileCitation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFileCitation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.FileCitation? value)
        {
            value = FileCitation;
            return IsFileCitation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.FileCitation PickFileCitation() => IsFileCitation
            ? FileCitation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileCitation' but the value was {ToString()}.");

        /// <summary>
        /// A place citation annotation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.PlaceCitation? PlaceCitation { get; init; }
#else
        public global::Google.Gemini.NextGen.PlaceCitation? PlaceCitation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlaceCitation))]
#endif
        public bool IsPlaceCitation => PlaceCitation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPlaceCitation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.PlaceCitation? value)
        {
            value = PlaceCitation;
            return IsPlaceCitation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.PlaceCitation PickPlaceCitation() => IsPlaceCitation
            ? PlaceCitation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PlaceCitation' but the value was {ToString()}.");

        /// <summary>
        /// Speech annotation for text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.SpeechAnnotation? Speech { get; init; }
#else
        public global::Google.Gemini.NextGen.SpeechAnnotation? Speech { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Speech))]
#endif
        public bool IsSpeech => Speech != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpeech(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.SpeechAnnotation? value)
        {
            value = Speech;
            return IsSpeech;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SpeechAnnotation PickSpeech() => IsSpeech
            ? Speech!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Speech' but the value was {ToString()}.");

        /// <summary>
        /// A URL citation annotation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.URLCitation? URLCitation { get; init; }
#else
        public global::Google.Gemini.NextGen.URLCitation? URLCitation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(URLCitation))]
#endif
        public bool IsURLCitation => URLCitation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickURLCitation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.URLCitation? value)
        {
            value = URLCitation;
            return IsURLCitation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.URLCitation PickURLCitation() => IsURLCitation
            ? URLCitation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'URLCitation' but the value was {ToString()}.");

        /// <summary>
        /// Word-level ASR annotation for transcription output.<br/>
        /// Carries the word text, optional timing, and optional speaker attribution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.WordInfo? WordInfo { get; init; }
#else
        public global::Google.Gemini.NextGen.WordInfo? WordInfo { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WordInfo))]
#endif
        public bool IsWordInfo => WordInfo != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWordInfo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.WordInfo? value)
        {
            value = WordInfo;
            return IsWordInfo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.WordInfo PickWordInfo() => IsWordInfo
            ? WordInfo!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WordInfo' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Annotation(global::Google.Gemini.NextGen.FileCitation value) => new Annotation((global::Google.Gemini.NextGen.FileCitation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.FileCitation?(Annotation @this) => @this.FileCitation;

        /// <summary>
        ///
        /// </summary>
        public Annotation(global::Google.Gemini.NextGen.FileCitation? value)
        {
            FileCitation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Annotation FromFileCitation(global::Google.Gemini.NextGen.FileCitation? value) => new Annotation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Annotation(global::Google.Gemini.NextGen.PlaceCitation value) => new Annotation((global::Google.Gemini.NextGen.PlaceCitation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.PlaceCitation?(Annotation @this) => @this.PlaceCitation;

        /// <summary>
        ///
        /// </summary>
        public Annotation(global::Google.Gemini.NextGen.PlaceCitation? value)
        {
            PlaceCitation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Annotation FromPlaceCitation(global::Google.Gemini.NextGen.PlaceCitation? value) => new Annotation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Annotation(global::Google.Gemini.NextGen.SpeechAnnotation value) => new Annotation((global::Google.Gemini.NextGen.SpeechAnnotation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.SpeechAnnotation?(Annotation @this) => @this.Speech;

        /// <summary>
        ///
        /// </summary>
        public Annotation(global::Google.Gemini.NextGen.SpeechAnnotation? value)
        {
            Speech = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Annotation FromSpeech(global::Google.Gemini.NextGen.SpeechAnnotation? value) => new Annotation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Annotation(global::Google.Gemini.NextGen.URLCitation value) => new Annotation((global::Google.Gemini.NextGen.URLCitation?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.URLCitation?(Annotation @this) => @this.URLCitation;

        /// <summary>
        ///
        /// </summary>
        public Annotation(global::Google.Gemini.NextGen.URLCitation? value)
        {
            URLCitation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Annotation FromURLCitation(global::Google.Gemini.NextGen.URLCitation? value) => new Annotation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Annotation(global::Google.Gemini.NextGen.WordInfo value) => new Annotation((global::Google.Gemini.NextGen.WordInfo?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.WordInfo?(Annotation @this) => @this.WordInfo;

        /// <summary>
        ///
        /// </summary>
        public Annotation(global::Google.Gemini.NextGen.WordInfo? value)
        {
            WordInfo = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Annotation FromWordInfo(global::Google.Gemini.NextGen.WordInfo? value) => new Annotation(value);

        /// <summary>
        ///
        /// </summary>
        public Annotation(
            global::Google.Gemini.NextGen.FileCitation? fileCitation,
            global::Google.Gemini.NextGen.PlaceCitation? placeCitation,
            global::Google.Gemini.NextGen.SpeechAnnotation? speech,
            global::Google.Gemini.NextGen.URLCitation? uRLCitation,
            global::Google.Gemini.NextGen.WordInfo? wordInfo
            )
        {
            FileCitation = fileCitation;
            PlaceCitation = placeCitation;
            Speech = speech;
            URLCitation = uRLCitation;
            WordInfo = wordInfo;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WordInfo as object ??
            URLCitation as object ??
            Speech as object ??
            PlaceCitation as object ??
            FileCitation as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            FileCitation?.ToString() ??
            PlaceCitation?.ToString() ??
            Speech?.ToString() ??
            URLCitation?.ToString() ??
            WordInfo?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFileCitation && !IsPlaceCitation && !IsSpeech && !IsURLCitation && !IsWordInfo || !IsFileCitation && IsPlaceCitation && !IsSpeech && !IsURLCitation && !IsWordInfo || !IsFileCitation && !IsPlaceCitation && IsSpeech && !IsURLCitation && !IsWordInfo || !IsFileCitation && !IsPlaceCitation && !IsSpeech && IsURLCitation && !IsWordInfo || !IsFileCitation && !IsPlaceCitation && !IsSpeech && !IsURLCitation && IsWordInfo;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.FileCitation, TResult>? fileCitation = null,
            global::System.Func<global::Google.Gemini.NextGen.PlaceCitation, TResult>? placeCitation = null,
            global::System.Func<global::Google.Gemini.NextGen.SpeechAnnotation, TResult>? speech = null,
            global::System.Func<global::Google.Gemini.NextGen.URLCitation, TResult>? uRLCitation = null,
            global::System.Func<global::Google.Gemini.NextGen.WordInfo, TResult>? wordInfo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileCitation && fileCitation != null)
            {
                return fileCitation(FileCitation!);
            }
            else if (IsPlaceCitation && placeCitation != null)
            {
                return placeCitation(PlaceCitation!);
            }
            else if (IsSpeech && speech != null)
            {
                return speech(Speech!);
            }
            else if (IsURLCitation && uRLCitation != null)
            {
                return uRLCitation(URLCitation!);
            }
            else if (IsWordInfo && wordInfo != null)
            {
                return wordInfo(WordInfo!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.FileCitation>? fileCitation = null,

            global::System.Action<global::Google.Gemini.NextGen.PlaceCitation>? placeCitation = null,

            global::System.Action<global::Google.Gemini.NextGen.SpeechAnnotation>? speech = null,

            global::System.Action<global::Google.Gemini.NextGen.URLCitation>? uRLCitation = null,

            global::System.Action<global::Google.Gemini.NextGen.WordInfo>? wordInfo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileCitation)
            {
                fileCitation?.Invoke(FileCitation!);
            }
            else if (IsPlaceCitation)
            {
                placeCitation?.Invoke(PlaceCitation!);
            }
            else if (IsSpeech)
            {
                speech?.Invoke(Speech!);
            }
            else if (IsURLCitation)
            {
                uRLCitation?.Invoke(URLCitation!);
            }
            else if (IsWordInfo)
            {
                wordInfo?.Invoke(WordInfo!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.FileCitation>? fileCitation = null,
            global::System.Action<global::Google.Gemini.NextGen.PlaceCitation>? placeCitation = null,
            global::System.Action<global::Google.Gemini.NextGen.SpeechAnnotation>? speech = null,
            global::System.Action<global::Google.Gemini.NextGen.URLCitation>? uRLCitation = null,
            global::System.Action<global::Google.Gemini.NextGen.WordInfo>? wordInfo = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileCitation)
            {
                fileCitation?.Invoke(FileCitation!);
            }
            else if (IsPlaceCitation)
            {
                placeCitation?.Invoke(PlaceCitation!);
            }
            else if (IsSpeech)
            {
                speech?.Invoke(Speech!);
            }
            else if (IsURLCitation)
            {
                uRLCitation?.Invoke(URLCitation!);
            }
            else if (IsWordInfo)
            {
                wordInfo?.Invoke(WordInfo!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FileCitation,
                typeof(global::Google.Gemini.NextGen.FileCitation),
                PlaceCitation,
                typeof(global::Google.Gemini.NextGen.PlaceCitation),
                Speech,
                typeof(global::Google.Gemini.NextGen.SpeechAnnotation),
                URLCitation,
                typeof(global::Google.Gemini.NextGen.URLCitation),
                WordInfo,
                typeof(global::Google.Gemini.NextGen.WordInfo),
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
        public bool Equals(Annotation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.FileCitation?>.Default.Equals(FileCitation, other.FileCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.PlaceCitation?>.Default.Equals(PlaceCitation, other.PlaceCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.SpeechAnnotation?>.Default.Equals(Speech, other.Speech) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.URLCitation?>.Default.Equals(URLCitation, other.URLCitation) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.WordInfo?>.Default.Equals(WordInfo, other.WordInfo)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Annotation obj1, Annotation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Annotation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Annotation obj1, Annotation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Annotation o && Equals(o);
        }
    }
}
