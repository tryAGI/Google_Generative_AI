#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration for transcription mode.
    /// </summary>
    public readonly partial struct TranscriptionMode : global::System.IEquatable<TranscriptionMode>
    {
        /// <summary>
        /// Configuration for smart transcription mode.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.SmartTranscriptionMode? Smart { get; init; }
#else
        public global::Google.Gemini.NextGen.SmartTranscriptionMode? Smart { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Smart))]
#endif
        public bool IsSmart => Smart != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSmart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.SmartTranscriptionMode? value)
        {
            value = Smart;
            return IsSmart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.SmartTranscriptionMode PickSmart() => IsSmart
            ? Smart!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Smart' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for verbatim transcription mode.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.VerbatimTranscriptionMode? Verbatim { get; init; }
#else
        public global::Google.Gemini.NextGen.VerbatimTranscriptionMode? Verbatim { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Verbatim))]
#endif
        public bool IsVerbatim => Verbatim != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVerbatim(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.VerbatimTranscriptionMode? value)
        {
            value = Verbatim;
            return IsVerbatim;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.VerbatimTranscriptionMode PickVerbatim() => IsVerbatim
            ? Verbatim!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Verbatim' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TranscriptionMode(global::Google.Gemini.NextGen.SmartTranscriptionMode value) => new TranscriptionMode((global::Google.Gemini.NextGen.SmartTranscriptionMode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.SmartTranscriptionMode?(TranscriptionMode @this) => @this.Smart;

        /// <summary>
        ///
        /// </summary>
        public TranscriptionMode(global::Google.Gemini.NextGen.SmartTranscriptionMode? value)
        {
            Smart = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TranscriptionMode FromSmart(global::Google.Gemini.NextGen.SmartTranscriptionMode? value) => new TranscriptionMode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TranscriptionMode(global::Google.Gemini.NextGen.VerbatimTranscriptionMode value) => new TranscriptionMode((global::Google.Gemini.NextGen.VerbatimTranscriptionMode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.VerbatimTranscriptionMode?(TranscriptionMode @this) => @this.Verbatim;

        /// <summary>
        ///
        /// </summary>
        public TranscriptionMode(global::Google.Gemini.NextGen.VerbatimTranscriptionMode? value)
        {
            Verbatim = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TranscriptionMode FromVerbatim(global::Google.Gemini.NextGen.VerbatimTranscriptionMode? value) => new TranscriptionMode(value);

        /// <summary>
        ///
        /// </summary>
        public TranscriptionMode(
            global::Google.Gemini.NextGen.SmartTranscriptionMode? smart,
            global::Google.Gemini.NextGen.VerbatimTranscriptionMode? verbatim
            )
        {
            Smart = smart;
            Verbatim = verbatim;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Verbatim as object ??
            Smart as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Smart?.ToString() ??
            Verbatim?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSmart && !IsVerbatim || !IsSmart && IsVerbatim;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.SmartTranscriptionMode, TResult>? smart = null,
            global::System.Func<global::Google.Gemini.NextGen.VerbatimTranscriptionMode, TResult>? verbatim = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSmart && smart != null)
            {
                return smart(Smart!);
            }
            else if (IsVerbatim && verbatim != null)
            {
                return verbatim(Verbatim!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.SmartTranscriptionMode>? smart = null,

            global::System.Action<global::Google.Gemini.NextGen.VerbatimTranscriptionMode>? verbatim = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSmart)
            {
                smart?.Invoke(Smart!);
            }
            else if (IsVerbatim)
            {
                verbatim?.Invoke(Verbatim!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.SmartTranscriptionMode>? smart = null,
            global::System.Action<global::Google.Gemini.NextGen.VerbatimTranscriptionMode>? verbatim = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSmart)
            {
                smart?.Invoke(Smart!);
            }
            else if (IsVerbatim)
            {
                verbatim?.Invoke(Verbatim!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Smart,
                typeof(global::Google.Gemini.NextGen.SmartTranscriptionMode),
                Verbatim,
                typeof(global::Google.Gemini.NextGen.VerbatimTranscriptionMode),
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
        public bool Equals(TranscriptionMode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.SmartTranscriptionMode?>.Default.Equals(Smart, other.Smart) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.VerbatimTranscriptionMode?>.Default.Equals(Verbatim, other.Verbatim)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TranscriptionMode obj1, TranscriptionMode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TranscriptionMode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TranscriptionMode obj1, TranscriptionMode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TranscriptionMode o && Equals(o);
        }
    }
}
