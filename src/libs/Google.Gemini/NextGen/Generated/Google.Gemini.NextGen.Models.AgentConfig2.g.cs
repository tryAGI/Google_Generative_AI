#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Configuration parameters for the agent interaction.
    /// </summary>
    public readonly partial struct AgentConfig2 : global::System.IEquatable<AgentConfig2>
    {
        /// <summary>
        /// Configuration for the Antigravity agent runtime.<br/>
        /// Provides server-side control over the agent's execution environment<br/>
        /// and tool configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.AntigravityAgentConfig? AntigravityConfig { get; init; }
#else
        public global::Google.Gemini.NextGen.AntigravityAgentConfig? AntigravityConfig { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AntigravityConfig))]
#endif
        public bool IsAntigravityConfig => AntigravityConfig != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAntigravityConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.AntigravityAgentConfig? value)
        {
            value = AntigravityConfig;
            return IsAntigravityConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.AntigravityAgentConfig PickAntigravityConfig() => IsAntigravityConfig
            ? AntigravityConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AntigravityConfig' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for the CodeMender agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.CodeMenderAgentConfig? CodeMenderConfig { get; init; }
#else
        public global::Google.Gemini.NextGen.CodeMenderAgentConfig? CodeMenderConfig { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeMenderConfig))]
#endif
        public bool IsCodeMenderConfig => CodeMenderConfig != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeMenderConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.CodeMenderAgentConfig? value)
        {
            value = CodeMenderConfig;
            return IsCodeMenderConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.CodeMenderAgentConfig PickCodeMenderConfig() => IsCodeMenderConfig
            ? CodeMenderConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeMenderConfig' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for the Deep Research agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.DeepResearchAgentConfig? DeepResearchConfig { get; init; }
#else
        public global::Google.Gemini.NextGen.DeepResearchAgentConfig? DeepResearchConfig { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeepResearchConfig))]
#endif
        public bool IsDeepResearchConfig => DeepResearchConfig != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeepResearchConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.DeepResearchAgentConfig? value)
        {
            value = DeepResearchConfig;
            return IsDeepResearchConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DeepResearchAgentConfig PickDeepResearchConfig() => IsDeepResearchConfig
            ? DeepResearchConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeepResearchConfig' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for dynamic agents.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Google.Gemini.NextGen.DynamicAgentConfig? DynamicConfig { get; init; }
#else
        public global::Google.Gemini.NextGen.DynamicAgentConfig? DynamicConfig { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicConfig))]
#endif
        public bool IsDynamicConfig => DynamicConfig != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDynamicConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Google.Gemini.NextGen.DynamicAgentConfig? value)
        {
            value = DynamicConfig;
            return IsDynamicConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Google.Gemini.NextGen.DynamicAgentConfig PickDynamicConfig() => IsDynamicConfig
            ? DynamicConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DynamicConfig' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentConfig2(global::Google.Gemini.NextGen.AntigravityAgentConfig value) => new AgentConfig2((global::Google.Gemini.NextGen.AntigravityAgentConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.AntigravityAgentConfig?(AgentConfig2 @this) => @this.AntigravityConfig;

        /// <summary>
        ///
        /// </summary>
        public AgentConfig2(global::Google.Gemini.NextGen.AntigravityAgentConfig? value)
        {
            AntigravityConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentConfig2 FromAntigravityConfig(global::Google.Gemini.NextGen.AntigravityAgentConfig? value) => new AgentConfig2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentConfig2(global::Google.Gemini.NextGen.CodeMenderAgentConfig value) => new AgentConfig2((global::Google.Gemini.NextGen.CodeMenderAgentConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.CodeMenderAgentConfig?(AgentConfig2 @this) => @this.CodeMenderConfig;

        /// <summary>
        ///
        /// </summary>
        public AgentConfig2(global::Google.Gemini.NextGen.CodeMenderAgentConfig? value)
        {
            CodeMenderConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentConfig2 FromCodeMenderConfig(global::Google.Gemini.NextGen.CodeMenderAgentConfig? value) => new AgentConfig2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentConfig2(global::Google.Gemini.NextGen.DeepResearchAgentConfig value) => new AgentConfig2((global::Google.Gemini.NextGen.DeepResearchAgentConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.DeepResearchAgentConfig?(AgentConfig2 @this) => @this.DeepResearchConfig;

        /// <summary>
        ///
        /// </summary>
        public AgentConfig2(global::Google.Gemini.NextGen.DeepResearchAgentConfig? value)
        {
            DeepResearchConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentConfig2 FromDeepResearchConfig(global::Google.Gemini.NextGen.DeepResearchAgentConfig? value) => new AgentConfig2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentConfig2(global::Google.Gemini.NextGen.DynamicAgentConfig value) => new AgentConfig2((global::Google.Gemini.NextGen.DynamicAgentConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Google.Gemini.NextGen.DynamicAgentConfig?(AgentConfig2 @this) => @this.DynamicConfig;

        /// <summary>
        ///
        /// </summary>
        public AgentConfig2(global::Google.Gemini.NextGen.DynamicAgentConfig? value)
        {
            DynamicConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentConfig2 FromDynamicConfig(global::Google.Gemini.NextGen.DynamicAgentConfig? value) => new AgentConfig2(value);

        /// <summary>
        ///
        /// </summary>
        public AgentConfig2(
            global::Google.Gemini.NextGen.AntigravityAgentConfig? antigravityConfig,
            global::Google.Gemini.NextGen.CodeMenderAgentConfig? codeMenderConfig,
            global::Google.Gemini.NextGen.DeepResearchAgentConfig? deepResearchConfig,
            global::Google.Gemini.NextGen.DynamicAgentConfig? dynamicConfig
            )
        {
            AntigravityConfig = antigravityConfig;
            CodeMenderConfig = codeMenderConfig;
            DeepResearchConfig = deepResearchConfig;
            DynamicConfig = dynamicConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DynamicConfig as object ??
            DeepResearchConfig as object ??
            CodeMenderConfig as object ??
            AntigravityConfig as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AntigravityConfig?.ToString() ??
            CodeMenderConfig?.ToString() ??
            DeepResearchConfig?.ToString() ??
            DynamicConfig?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAntigravityConfig && !IsCodeMenderConfig && !IsDeepResearchConfig && !IsDynamicConfig || !IsAntigravityConfig && IsCodeMenderConfig && !IsDeepResearchConfig && !IsDynamicConfig || !IsAntigravityConfig && !IsCodeMenderConfig && IsDeepResearchConfig && !IsDynamicConfig || !IsAntigravityConfig && !IsCodeMenderConfig && !IsDeepResearchConfig && IsDynamicConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Google.Gemini.NextGen.AntigravityAgentConfig, TResult>? antigravityConfig = null,
            global::System.Func<global::Google.Gemini.NextGen.CodeMenderAgentConfig, TResult>? codeMenderConfig = null,
            global::System.Func<global::Google.Gemini.NextGen.DeepResearchAgentConfig, TResult>? deepResearchConfig = null,
            global::System.Func<global::Google.Gemini.NextGen.DynamicAgentConfig, TResult>? dynamicConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAntigravityConfig && antigravityConfig != null)
            {
                return antigravityConfig(AntigravityConfig!);
            }
            else if (IsCodeMenderConfig && codeMenderConfig != null)
            {
                return codeMenderConfig(CodeMenderConfig!);
            }
            else if (IsDeepResearchConfig && deepResearchConfig != null)
            {
                return deepResearchConfig(DeepResearchConfig!);
            }
            else if (IsDynamicConfig && dynamicConfig != null)
            {
                return dynamicConfig(DynamicConfig!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Google.Gemini.NextGen.AntigravityAgentConfig>? antigravityConfig = null,

            global::System.Action<global::Google.Gemini.NextGen.CodeMenderAgentConfig>? codeMenderConfig = null,

            global::System.Action<global::Google.Gemini.NextGen.DeepResearchAgentConfig>? deepResearchConfig = null,

            global::System.Action<global::Google.Gemini.NextGen.DynamicAgentConfig>? dynamicConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAntigravityConfig)
            {
                antigravityConfig?.Invoke(AntigravityConfig!);
            }
            else if (IsCodeMenderConfig)
            {
                codeMenderConfig?.Invoke(CodeMenderConfig!);
            }
            else if (IsDeepResearchConfig)
            {
                deepResearchConfig?.Invoke(DeepResearchConfig!);
            }
            else if (IsDynamicConfig)
            {
                dynamicConfig?.Invoke(DynamicConfig!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Google.Gemini.NextGen.AntigravityAgentConfig>? antigravityConfig = null,
            global::System.Action<global::Google.Gemini.NextGen.CodeMenderAgentConfig>? codeMenderConfig = null,
            global::System.Action<global::Google.Gemini.NextGen.DeepResearchAgentConfig>? deepResearchConfig = null,
            global::System.Action<global::Google.Gemini.NextGen.DynamicAgentConfig>? dynamicConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAntigravityConfig)
            {
                antigravityConfig?.Invoke(AntigravityConfig!);
            }
            else if (IsCodeMenderConfig)
            {
                codeMenderConfig?.Invoke(CodeMenderConfig!);
            }
            else if (IsDeepResearchConfig)
            {
                deepResearchConfig?.Invoke(DeepResearchConfig!);
            }
            else if (IsDynamicConfig)
            {
                dynamicConfig?.Invoke(DynamicConfig!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AntigravityConfig,
                typeof(global::Google.Gemini.NextGen.AntigravityAgentConfig),
                CodeMenderConfig,
                typeof(global::Google.Gemini.NextGen.CodeMenderAgentConfig),
                DeepResearchConfig,
                typeof(global::Google.Gemini.NextGen.DeepResearchAgentConfig),
                DynamicConfig,
                typeof(global::Google.Gemini.NextGen.DynamicAgentConfig),
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
        public bool Equals(AgentConfig2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.AntigravityAgentConfig?>.Default.Equals(AntigravityConfig, other.AntigravityConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.CodeMenderAgentConfig?>.Default.Equals(CodeMenderConfig, other.CodeMenderConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.DeepResearchAgentConfig?>.Default.Equals(DeepResearchConfig, other.DeepResearchConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Google.Gemini.NextGen.DynamicAgentConfig?>.Default.Equals(DynamicConfig, other.DynamicConfig)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AgentConfig2 obj1, AgentConfig2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentConfig2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AgentConfig2 obj1, AgentConfig2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentConfig2 o && Equals(o);
        }
    }
}
