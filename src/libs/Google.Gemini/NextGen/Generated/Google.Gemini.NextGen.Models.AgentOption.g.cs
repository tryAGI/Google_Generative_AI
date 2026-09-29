
#nullable enable

namespace Google.Gemini.NextGen
{

    /// <summary>
    /// The agent to interact with.
    /// </summary>
    public readonly partial struct AgentOption : global::System.IEquatable<AgentOption>
    {
        /// <summary>
        ///
        /// </summary>
        public AgentOption(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// Use the Antigravity managed agent to perform multi-step tasks that require reasoning, file operations, and tool use.
        /// </summary>
        public static AgentOption AntigravityPreview052026 { get; } = new("antigravity-preview-05-2026");

        /// <summary>
        /// Gemini Deep Research Max Agent
        /// </summary>
        public static AgentOption DeepResearchMaxPreview042026 { get; } = new("deep-research-max-preview-04-2026");

        /// <summary>
        /// Gemini Deep Research Agent
        /// </summary>
        public static AgentOption DeepResearchPreview042026 { get; } = new("deep-research-preview-04-2026");

        /// <summary>
        /// Gemini Deep Research Agent
        /// </summary>
        public static AgentOption DeepResearchProPreview122025 { get; } = new("deep-research-pro-preview-12-2025");
        /// <summary>
        ///
        /// </summary>
        public static AgentOption FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "antigravity-preview-05-2026" => AntigravityPreview052026,
                "deep-research-max-preview-04-2026" => DeepResearchMaxPreview042026,
                "deep-research-preview-04-2026" => DeepResearchPreview042026,
                "deep-research-pro-preview-12-2025" => DeepResearchProPreview122025,
                _ => new AgentOption(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "antigravity-preview-05-2026" => true,
            "deep-research-max-preview-04-2026" => true,
            "deep-research-preview-04-2026" => true,
            "deep-research-pro-preview-12-2025" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AgentOption other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentOption other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AgentOption left, AgentOption right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AgentOption left, AgentOption right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentOption value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentOption? ToEnum(string value)
        {
            return AgentOption.FromValue(value);
        }
    }
}