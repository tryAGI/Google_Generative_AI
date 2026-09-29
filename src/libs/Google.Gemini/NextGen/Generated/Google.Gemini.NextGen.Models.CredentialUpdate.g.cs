#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Represents the fields of a Credential that can be updated.
    /// </summary>
    public readonly partial struct CredentialUpdate : global::System.IEquatable<CredentialUpdate>
    {
        /// <summary>
        /// Configuration for updating environment variable credentials.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig? EnvironmentVariableConfig { get; init; }
#else
        public global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig? EnvironmentVariableConfig { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentVariableConfig))]
#endif
        public bool IsEnvironmentVariableConfig => EnvironmentVariableConfig != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnvironmentVariableConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig? value)
        {
            value = EnvironmentVariableConfig;
            return IsEnvironmentVariableConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig PickEnvironmentVariableConfig() => IsEnvironmentVariableConfig
            ? EnvironmentVariableConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentVariableConfig' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for updating HTTP Bearer token credentials.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.HttpBearerUpdateConfig? HttpBearerConfig { get; init; }
#else
        public global::Google.Gemini.NextGen.HttpBearerUpdateConfig? HttpBearerConfig { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HttpBearerConfig))]
#endif
        public bool IsHttpBearerConfig => HttpBearerConfig != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHttpBearerConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.HttpBearerUpdateConfig? value)
        {
            value = HttpBearerConfig;
            return IsHttpBearerConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBearerUpdateConfig PickHttpBearerConfig() => IsHttpBearerConfig
            ? HttpBearerConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'HttpBearerConfig' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for updating OAuth2 credentials.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.OAuth2UpdateConfig? OAuth2Config { get; init; }
#else
        public global::Google.Gemini.NextGen.OAuth2UpdateConfig? OAuth2Config { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OAuth2Config))]
#endif
        public bool IsOAuth2Config => OAuth2Config != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOAuth2Config(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.OAuth2UpdateConfig? value)
        {
            value = OAuth2Config;
            return IsOAuth2Config;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OAuth2UpdateConfig PickOAuth2Config() => IsOAuth2Config
            ? OAuth2Config!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OAuth2Config' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialUpdate(global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig value) => new CredentialUpdate((global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig?(CredentialUpdate @this) => @this.EnvironmentVariableConfig;

        /// <summary>
        ///
        /// </summary>
        public CredentialUpdate(global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig? value)
        {
            EnvironmentVariableConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialUpdate FromEnvironmentVariableConfig(global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig? value) => new CredentialUpdate(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialUpdate(global::Google.Gemini.NextGen.HttpBearerUpdateConfig value) => new CredentialUpdate((global::Google.Gemini.NextGen.HttpBearerUpdateConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.HttpBearerUpdateConfig?(CredentialUpdate @this) => @this.HttpBearerConfig;

        /// <summary>
        ///
        /// </summary>
        public CredentialUpdate(global::Google.Gemini.NextGen.HttpBearerUpdateConfig? value)
        {
            HttpBearerConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialUpdate FromHttpBearerConfig(global::Google.Gemini.NextGen.HttpBearerUpdateConfig? value) => new CredentialUpdate(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialUpdate(global::Google.Gemini.NextGen.OAuth2UpdateConfig value) => new CredentialUpdate((global::Google.Gemini.NextGen.OAuth2UpdateConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.OAuth2UpdateConfig?(CredentialUpdate @this) => @this.OAuth2Config;

        /// <summary>
        ///
        /// </summary>
        public CredentialUpdate(global::Google.Gemini.NextGen.OAuth2UpdateConfig? value)
        {
            OAuth2Config = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialUpdate FromOAuth2Config(global::Google.Gemini.NextGen.OAuth2UpdateConfig? value) => new CredentialUpdate(value);

        /// <summary>
        ///
        /// </summary>
        public CredentialUpdate(
            global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig? environmentVariableConfig,
            global::Google.Gemini.NextGen.HttpBearerUpdateConfig? httpBearerConfig,
            global::Google.Gemini.NextGen.OAuth2UpdateConfig? oAuth2Config
            )
        {
            EnvironmentVariableConfig = environmentVariableConfig;
            HttpBearerConfig = httpBearerConfig;
            OAuth2Config = oAuth2Config;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OAuth2Config as object ??
            HttpBearerConfig as object ??
            EnvironmentVariableConfig as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            EnvironmentVariableConfig?.ToString() ??
            HttpBearerConfig?.ToString() ??
            OAuth2Config?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnvironmentVariableConfig && !IsHttpBearerConfig && !IsOAuth2Config || !IsEnvironmentVariableConfig && IsHttpBearerConfig && !IsOAuth2Config || !IsEnvironmentVariableConfig && !IsHttpBearerConfig && IsOAuth2Config;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig, TResult>? environmentVariableConfig = null,
            global::System.Func<global::Google.Gemini.NextGen.HttpBearerUpdateConfig, TResult>? httpBearerConfig = null,
            global::System.Func<global::Google.Gemini.NextGen.OAuth2UpdateConfig, TResult>? oAuth2Config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnvironmentVariableConfig && environmentVariableConfig != null)
            {
                return environmentVariableConfig(EnvironmentVariableConfig!);
            }
            else if (IsHttpBearerConfig && httpBearerConfig != null)
            {
                return httpBearerConfig(HttpBearerConfig!);
            }
            else if (IsOAuth2Config && oAuth2Config != null)
            {
                return oAuth2Config(OAuth2Config!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig>? environmentVariableConfig = null,

            global::System.Action<global::Google.Gemini.NextGen.HttpBearerUpdateConfig>? httpBearerConfig = null,

            global::System.Action<global::Google.Gemini.NextGen.OAuth2UpdateConfig>? oAuth2Config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnvironmentVariableConfig)
            {
                environmentVariableConfig?.Invoke(EnvironmentVariableConfig!);
            }
            else if (IsHttpBearerConfig)
            {
                httpBearerConfig?.Invoke(HttpBearerConfig!);
            }
            else if (IsOAuth2Config)
            {
                oAuth2Config?.Invoke(OAuth2Config!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig>? environmentVariableConfig = null,
            global::System.Action<global::Google.Gemini.NextGen.HttpBearerUpdateConfig>? httpBearerConfig = null,
            global::System.Action<global::Google.Gemini.NextGen.OAuth2UpdateConfig>? oAuth2Config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnvironmentVariableConfig)
            {
                environmentVariableConfig?.Invoke(EnvironmentVariableConfig!);
            }
            else if (IsHttpBearerConfig)
            {
                httpBearerConfig?.Invoke(HttpBearerConfig!);
            }
            else if (IsOAuth2Config)
            {
                oAuth2Config?.Invoke(OAuth2Config!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EnvironmentVariableConfig,
                typeof(global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig),
                HttpBearerConfig,
                typeof(global::Google.Gemini.NextGen.HttpBearerUpdateConfig),
                OAuth2Config,
                typeof(global::Google.Gemini.NextGen.OAuth2UpdateConfig),
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
        public bool Equals(CredentialUpdate other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.EnvironmentVariableUpdateConfig?>.Default.Equals(EnvironmentVariableConfig, other.EnvironmentVariableConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.HttpBearerUpdateConfig?>.Default.Equals(HttpBearerConfig, other.HttpBearerConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.OAuth2UpdateConfig?>.Default.Equals(OAuth2Config, other.OAuth2Config)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CredentialUpdate obj1, CredentialUpdate obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CredentialUpdate>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CredentialUpdate obj1, CredentialUpdate obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CredentialUpdate o && Equals(o);
        }
    }
}
