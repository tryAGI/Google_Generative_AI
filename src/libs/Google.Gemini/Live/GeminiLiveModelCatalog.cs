namespace Google.Gemini;

/// <summary>
/// Model-specific Gemini Live protocol rules shared by SDK consumers.
/// </summary>
public static class GeminiLiveModelCatalog
{
    /// <summary>Gemini 3.8 Live without configurable thinking.</summary>
    public const string Gemini38Live = "gemini-3.8-live";

    /// <summary>Gemini 3.8 Live with low, medium, or high thinking.</summary>
    public const string Gemini38LiveExtendedThinking = "gemini-3.8-live-extended-thinking";

    /// <summary>Gemini 3.1 Flash Live preview.</summary>
    public const string Gemini31FlashLive = "gemini-3.1-flash-live-preview";

    /// <summary>Returns the WebSocket API version required by a model.</summary>
    public static string GetApiVersion(string? model) =>
        IsExtendedThinking(model) ? "v1alpha" : "v1beta";

    /// <summary>Returns whether the model uses the extended-thinking Live protocol.</summary>
    public static bool IsExtendedThinking(string? model) =>
        Normalize(model).Equals(Gemini38LiveExtendedThinking, StringComparison.OrdinalIgnoreCase);

    /// <summary>
    /// Applies a user-facing thinking effort to the setup configuration and
    /// rejects combinations the provider does not support.
    /// </summary>
    public static void ApplyThinkingEffort(LiveSetupConfig config, string? effort)
    {
        ArgumentNullException.ThrowIfNull(config);
        var model = Normalize(config.Model);

        if (string.IsNullOrWhiteSpace(effort))
        {
            if (IsExtendedThinking(model))
            {
                throw new ArgumentException(
                    $"Model '{Gemini38LiveExtendedThinking}' requires a thinking effort (low, medium, or high).",
                    nameof(effort));
            }

            return;
        }

        if (model.Equals(Gemini38Live, StringComparison.OrdinalIgnoreCase))
        {
            throw new ArgumentException(
                $"Model '{Gemini38Live}' does not accept thinking configuration.",
                nameof(effort));
        }

        var level = effort.Trim().ToUpperInvariant() switch
        {
            "MINIMAL" => ThinkingConfigThinkingLevel.Minimal,
            "LOW" => ThinkingConfigThinkingLevel.Low,
            "MEDIUM" => ThinkingConfigThinkingLevel.Medium,
            "HIGH" => ThinkingConfigThinkingLevel.High,
            _ => throw new ArgumentOutOfRangeException(
                nameof(effort),
                effort,
                "Thinking effort must be minimal, low, medium, or high."),
        };

        if (IsExtendedThinking(model) && level == ThinkingConfigThinkingLevel.Minimal)
        {
            throw new ArgumentException(
                $"Model '{Gemini38LiveExtendedThinking}' supports low, medium, or high thinking, but not minimal.",
                nameof(effort));
        }

        config.GenerationConfig ??= new GenerationConfig();
        config.GenerationConfig.ThinkingConfig = new ThinkingConfig
        {
            ThinkingLevel = level,
        };
    }

    /// <summary>
    /// Validates model-specific configuration and applies the required
    /// non-blocking function behavior for extended-thinking sessions.
    /// </summary>
    public static void PrepareForConnection(LiveSetupConfig config)
    {
        ArgumentNullException.ThrowIfNull(config);
        var model = Normalize(config.Model);
        var thinking = config.GenerationConfig?.ThinkingConfig;

        if (model.Equals(Gemini38Live, StringComparison.OrdinalIgnoreCase) && thinking is not null)
        {
            throw new InvalidOperationException(
                $"Model '{Gemini38Live}' does not accept thinkingConfig. Use '{Gemini38LiveExtendedThinking}' for configurable thinking.");
        }

        if (IsExtendedThinking(model))
        {
            if (thinking?.ThinkingLevel is null)
            {
                throw new InvalidOperationException(
                    $"Model '{Gemini38LiveExtendedThinking}' requires generationConfig.thinkingConfig.thinkingLevel.");
            }

            if (thinking.ThinkingLevel == ThinkingConfigThinkingLevel.Minimal)
            {
                throw new InvalidOperationException(
                    $"Model '{Gemini38LiveExtendedThinking}' does not support minimal thinking.");
            }

            if (config.Tools is null)
            {
                return;
            }

            foreach (var declaration in config.Tools
                         .Where(static tool => tool.FunctionDeclarations is not null)
                         .SelectMany(static tool => tool.FunctionDeclarations!))
            {
                declaration.Behavior = FunctionDeclarationBehavior.NonBlocking;
            }
        }
    }

    private static string Normalize(string? model) =>
        model?.Trim().StartsWith("models/", StringComparison.OrdinalIgnoreCase) == true
            ? model.Trim()["models/".Length..]
            : model?.Trim() ?? string.Empty;
}
