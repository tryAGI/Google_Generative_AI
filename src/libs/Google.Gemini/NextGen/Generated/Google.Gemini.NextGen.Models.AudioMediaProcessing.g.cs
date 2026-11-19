#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AudioMediaProcessing : global::System.IEquatable<AudioMediaProcessing>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.AudioStaticMediaProcessing? Static { get; init; }
#else
        public global::Google.Gemini.NextGen.AudioStaticMediaProcessing? Static { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Static))]
#endif
        public bool IsStatic => Static != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStatic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.AudioStaticMediaProcessing? value)
        {
            value = Static;
            return IsStatic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AudioStaticMediaProcessing PickStatic() => Static is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Static' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AudioMediaProcessing(global::Google.Gemini.NextGen.AudioStaticMediaProcessing value) => new AudioMediaProcessing((global::Google.Gemini.NextGen.AudioStaticMediaProcessing?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.AudioStaticMediaProcessing?(AudioMediaProcessing @this) => @this.Static;

        /// <summary>
        ///
        /// </summary>
        public AudioMediaProcessing(global::Google.Gemini.NextGen.AudioStaticMediaProcessing? value)
        {
            Static = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AudioMediaProcessing FromStatic(global::Google.Gemini.NextGen.AudioStaticMediaProcessing? value) => new AudioMediaProcessing(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Static as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Static?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStatic;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.AudioStaticMediaProcessing, TResult>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Static is { } __value0 && @static != null)
            {
                return @static(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.AudioStaticMediaProcessing>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Static is { } __value0)
            {
                @static?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.AudioStaticMediaProcessing>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Static is { } __value0)
            {
                @static?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Static,
                typeof(global::Google.Gemini.NextGen.AudioStaticMediaProcessing),
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
        public bool Equals(AudioMediaProcessing other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.AudioStaticMediaProcessing?>.Default.Equals(Static, other.Static)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AudioMediaProcessing obj1, AudioMediaProcessing obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AudioMediaProcessing>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AudioMediaProcessing obj1, AudioMediaProcessing obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AudioMediaProcessing o && Equals(o);
        }
    }
}
