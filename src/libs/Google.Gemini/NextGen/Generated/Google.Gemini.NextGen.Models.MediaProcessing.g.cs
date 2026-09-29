#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct MediaProcessing : global::System.IEquatable<MediaProcessing>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.StaticMediaProcessing? Static { get; init; }
#else
        public global::Google.Gemini.NextGen.StaticMediaProcessing? Static { get; }
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
            out global::Google.Gemini.NextGen.StaticMediaProcessing? value)
        {
            value = Static;
            return IsStatic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.StaticMediaProcessing PickStatic() => IsStatic
            ? Static!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Static' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator MediaProcessing(global::Google.Gemini.NextGen.StaticMediaProcessing value) => new MediaProcessing((global::Google.Gemini.NextGen.StaticMediaProcessing?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.StaticMediaProcessing?(MediaProcessing @this) => @this.Static;

        /// <summary>
        ///
        /// </summary>
        public MediaProcessing(global::Google.Gemini.NextGen.StaticMediaProcessing? value)
        {
            Static = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MediaProcessing FromStatic(global::Google.Gemini.NextGen.StaticMediaProcessing? value) => new MediaProcessing(value);

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
            global::System.Func<global::Google.Gemini.NextGen.StaticMediaProcessing, TResult>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStatic && @static != null)
            {
                return @static(Static!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.StaticMediaProcessing>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStatic)
            {
                @static?.Invoke(Static!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.StaticMediaProcessing>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStatic)
            {
                @static?.Invoke(Static!);
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
                typeof(global::Google.Gemini.NextGen.StaticMediaProcessing),
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
        public bool Equals(MediaProcessing other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.StaticMediaProcessing?>.Default.Equals(Static, other.Static)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(MediaProcessing obj1, MediaProcessing obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MediaProcessing>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MediaProcessing obj1, MediaProcessing obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MediaProcessing o && Equals(o);
        }
    }
}
