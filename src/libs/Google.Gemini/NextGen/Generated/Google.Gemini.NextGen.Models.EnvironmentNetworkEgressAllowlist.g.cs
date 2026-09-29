#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Outbound networking configuration for the sandbox. Accepts an object with an 'allowlist' array to restrict traffic, or the string 'disabled' to turn off all network access. Omit entirely to allow all outbound traffic with no header injection.
    /// </summary>
    public readonly partial struct EnvironmentNetworkEgressAllowlist : global::System.IEquatable<EnvironmentNetworkEgressAllowlist>
    {
        /// <summary>
        /// Outbound networking configuration for the sandbox. When specified, restricts which external domains the sandbox can reach. Omit entirely to allow all outbound traffic with no header injection.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum? Allowlist { get; init; }
#else
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum? Allowlist { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Allowlist))]
#endif
        public bool IsAllowlist => Allowlist != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAllowlist(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum? value)
        {
            value = Allowlist;
            return IsAllowlist;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum PickAllowlist() => IsAllowlist
            ? Allowlist!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Allowlist' but the value was {ToString()}.");

        /// <summary>
        /// Turns all network off.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2? Disabled { get; init; }
#else
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2? Disabled { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Disabled))]
#endif
        public bool IsDisabled => Disabled != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDisabled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2 PickDisabled() => IsDisabled
            ? Disabled!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentNetworkEgressAllowlist(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum value) => new EnvironmentNetworkEgressAllowlist((global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum?(EnvironmentNetworkEgressAllowlist @this) => @this.Allowlist;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentNetworkEgressAllowlist(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum? value)
        {
            Allowlist = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentNetworkEgressAllowlist FromAllowlist(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum? value) => new EnvironmentNetworkEgressAllowlist(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentNetworkEgressAllowlist(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2 value) => new EnvironmentNetworkEgressAllowlist((global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2?(EnvironmentNetworkEgressAllowlist @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentNetworkEgressAllowlist(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentNetworkEgressAllowlist FromDisabled(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2? value) => new EnvironmentNetworkEgressAllowlist(value);

        /// <summary>
        ///
        /// </summary>
        public EnvironmentNetworkEgressAllowlist(
            global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum? allowlist,
            global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2? disabled
            )
        {
            Allowlist = allowlist;
            Disabled = disabled;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Disabled as object ??
            Allowlist as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Allowlist?.ToString() ??
            Disabled?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAllowlist && !IsDisabled || !IsAllowlist && IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum, TResult>? allowlist = null,
            global::System.Func<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2?, TResult>? disabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAllowlist && allowlist != null)
            {
                return allowlist(Allowlist!);
            }
            else if (IsDisabled && disabled != null)
            {
                return disabled(Disabled!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum>? allowlist = null,

            global::System.Action<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2?>? disabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAllowlist)
            {
                allowlist?.Invoke(Allowlist!);
            }
            else if (IsDisabled)
            {
                disabled?.Invoke(Disabled!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum>? allowlist = null,
            global::System.Action<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2?>? disabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAllowlist)
            {
                allowlist?.Invoke(Allowlist!);
            }
            else if (IsDisabled)
            {
                disabled?.Invoke(Disabled!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Allowlist,
                typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum),
                Disabled,
                typeof(global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2),
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
        public bool Equals(EnvironmentNetworkEgressAllowlist other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum?>.Default.Equals(Allowlist, other.Allowlist) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.EnvironmentNetworkEgressAllowlistEnum2?>.Default.Equals(Disabled, other.Disabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EnvironmentNetworkEgressAllowlist obj1, EnvironmentNetworkEgressAllowlist obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EnvironmentNetworkEgressAllowlist>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EnvironmentNetworkEgressAllowlist obj1, EnvironmentNetworkEgressAllowlist obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EnvironmentNetworkEgressAllowlist o && Equals(o);
        }
    }
}
