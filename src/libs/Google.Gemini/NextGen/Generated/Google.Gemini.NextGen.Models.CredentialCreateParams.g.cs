#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Represents the fields of a Credential provided on creation.
    /// </summary>
    public readonly partial struct CredentialCreateParams : global::System.IEquatable<CredentialCreateParams>
    {
        /// <summary>
        /// Configuration for environment variable credentials.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.EnvironmentVariableConfig? EnvironmentVariableConfig { get; init; }
#else
        public global::Google.Gemini.NextGen.EnvironmentVariableConfig? EnvironmentVariableConfig { get; }
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
            out global::Google.Gemini.NextGen.EnvironmentVariableConfig? value)
        {
            value = EnvironmentVariableConfig;
            return IsEnvironmentVariableConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.EnvironmentVariableConfig PickEnvironmentVariableConfig() => EnvironmentVariableConfig is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentVariableConfig' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for HTTP Bearer token credentials.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.HttpBearerConfig? HttpBearerConfig { get; init; }
#else
        public global::Google.Gemini.NextGen.HttpBearerConfig? HttpBearerConfig { get; }
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
            out global::Google.Gemini.NextGen.HttpBearerConfig? value)
        {
            value = HttpBearerConfig;
            return IsHttpBearerConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.HttpBearerConfig PickHttpBearerConfig() => HttpBearerConfig is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HttpBearerConfig' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for OAuth2 credentials with automatic token refresh.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.OAuth2Config? OAuth2Config { get; init; }
#else
        public global::Google.Gemini.NextGen.OAuth2Config? OAuth2Config { get; }
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
            out global::Google.Gemini.NextGen.OAuth2Config? value)
        {
            value = OAuth2Config;
            return IsOAuth2Config;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.OAuth2Config PickOAuth2Config() => OAuth2Config is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OAuth2Config' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialCreateParams(global::Google.Gemini.NextGen.EnvironmentVariableConfig value) => new CredentialCreateParams((global::Google.Gemini.NextGen.EnvironmentVariableConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.EnvironmentVariableConfig?(CredentialCreateParams @this) => @this.EnvironmentVariableConfig;

        /// <summary>
        ///
        /// </summary>
        public CredentialCreateParams(global::Google.Gemini.NextGen.EnvironmentVariableConfig? value)
        {
            EnvironmentVariableConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialCreateParams FromEnvironmentVariableConfig(global::Google.Gemini.NextGen.EnvironmentVariableConfig? value) => new CredentialCreateParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialCreateParams(global::Google.Gemini.NextGen.HttpBearerConfig value) => new CredentialCreateParams((global::Google.Gemini.NextGen.HttpBearerConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.HttpBearerConfig?(CredentialCreateParams @this) => @this.HttpBearerConfig;

        /// <summary>
        ///
        /// </summary>
        public CredentialCreateParams(global::Google.Gemini.NextGen.HttpBearerConfig? value)
        {
            HttpBearerConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialCreateParams FromHttpBearerConfig(global::Google.Gemini.NextGen.HttpBearerConfig? value) => new CredentialCreateParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialCreateParams(global::Google.Gemini.NextGen.OAuth2Config value) => new CredentialCreateParams((global::Google.Gemini.NextGen.OAuth2Config?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.OAuth2Config?(CredentialCreateParams @this) => @this.OAuth2Config;

        /// <summary>
        ///
        /// </summary>
        public CredentialCreateParams(global::Google.Gemini.NextGen.OAuth2Config? value)
        {
            OAuth2Config = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialCreateParams FromOAuth2Config(global::Google.Gemini.NextGen.OAuth2Config? value) => new CredentialCreateParams(value);

        /// <summary>
        ///
        /// </summary>
        public CredentialCreateParams(
            global::Google.Gemini.NextGen.EnvironmentVariableConfig? environmentVariableConfig,
            global::Google.Gemini.NextGen.HttpBearerConfig? httpBearerConfig,
            global::Google.Gemini.NextGen.OAuth2Config? oAuth2Config
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
            global::System.Func<global::Google.Gemini.NextGen.EnvironmentVariableConfig, TResult>? environmentVariableConfig = null,
            global::System.Func<global::Google.Gemini.NextGen.HttpBearerConfig, TResult>? httpBearerConfig = null,
            global::System.Func<global::Google.Gemini.NextGen.OAuth2Config, TResult>? oAuth2Config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (EnvironmentVariableConfig is { } __value0 && environmentVariableConfig != null)
            {
                return environmentVariableConfig(__value0);
            }
            else if (HttpBearerConfig is { } __value1 && httpBearerConfig != null)
            {
                return httpBearerConfig(__value1);
            }
            else if (OAuth2Config is { } __value2 && oAuth2Config != null)
            {
                return oAuth2Config(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.EnvironmentVariableConfig>? environmentVariableConfig = null,

            global::System.Action<global::Google.Gemini.NextGen.HttpBearerConfig>? httpBearerConfig = null,

            global::System.Action<global::Google.Gemini.NextGen.OAuth2Config>? oAuth2Config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (EnvironmentVariableConfig is { } __value0)
            {
                environmentVariableConfig?.Invoke(__value0);
            }
            else if (HttpBearerConfig is { } __value1)
            {
                httpBearerConfig?.Invoke(__value1);
            }
            else if (OAuth2Config is { } __value2)
            {
                oAuth2Config?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.EnvironmentVariableConfig>? environmentVariableConfig = null,
            global::System.Action<global::Google.Gemini.NextGen.HttpBearerConfig>? httpBearerConfig = null,
            global::System.Action<global::Google.Gemini.NextGen.OAuth2Config>? oAuth2Config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (EnvironmentVariableConfig is { } __value0)
            {
                environmentVariableConfig?.Invoke(__value0);
            }
            else if (HttpBearerConfig is { } __value1)
            {
                httpBearerConfig?.Invoke(__value1);
            }
            else if (OAuth2Config is { } __value2)
            {
                oAuth2Config?.Invoke(__value2);
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
                typeof(global::Google.Gemini.NextGen.EnvironmentVariableConfig),
                HttpBearerConfig,
                typeof(global::Google.Gemini.NextGen.HttpBearerConfig),
                OAuth2Config,
                typeof(global::Google.Gemini.NextGen.OAuth2Config),
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
        public bool Equals(CredentialCreateParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.EnvironmentVariableConfig?>.Default.Equals(EnvironmentVariableConfig, other.EnvironmentVariableConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.HttpBearerConfig?>.Default.Equals(HttpBearerConfig, other.HttpBearerConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.OAuth2Config?>.Default.Equals(OAuth2Config, other.OAuth2Config)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CredentialCreateParams obj1, CredentialCreateParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CredentialCreateParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CredentialCreateParams obj1, CredentialCreateParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CredentialCreateParams o && Equals(o);
        }
    }
}
