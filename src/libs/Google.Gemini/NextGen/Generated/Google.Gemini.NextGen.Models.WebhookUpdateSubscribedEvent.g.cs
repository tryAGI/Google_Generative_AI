
#nullable enable

namespace Google.Gemini.NextGen
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct WebhookUpdateSubscribedEvent : global::System.IEquatable<WebhookUpdateSubscribedEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public WebhookUpdateSubscribedEvent(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// Batch has not been processed within the 48h timeframe.
        /// </summary>
        public static WebhookUpdateSubscribedEvent BatchExpired { get; } = new("batch.expired");

        /// <summary>
        /// Batch job failed.
        /// </summary>
        public static WebhookUpdateSubscribedEvent BatchFailed { get; } = new("batch.failed");

        /// <summary>
        /// Batch processing finished successfully.
        /// </summary>
        public static WebhookUpdateSubscribedEvent BatchSucceeded { get; } = new("batch.succeeded");

        /// <summary>
        /// Interaction completed successfully.
        /// </summary>
        public static WebhookUpdateSubscribedEvent InteractionCompleted { get; } = new("interaction.completed");

        /// <summary>
        /// Interaction failed.
        /// </summary>
        public static WebhookUpdateSubscribedEvent InteractionFailed { get; } = new("interaction.failed");

        /// <summary>
        /// Interaction requires action (e.g., function calling).
        /// </summary>
        public static WebhookUpdateSubscribedEvent InteractionRequiresAction { get; } = new("interaction.requires_action");

        /// <summary>
        /// Video generation completed.
        /// </summary>
        public static WebhookUpdateSubscribedEvent VideoGenerated { get; } = new("video.generated");
        /// <summary>
        ///
        /// </summary>
        public static WebhookUpdateSubscribedEvent FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "batch.expired" => BatchExpired,
                "batch.failed" => BatchFailed,
                "batch.succeeded" => BatchSucceeded,
                "interaction.completed" => InteractionCompleted,
                "interaction.failed" => InteractionFailed,
                "interaction.requires_action" => InteractionRequiresAction,
                "video.generated" => VideoGenerated,
                _ => new WebhookUpdateSubscribedEvent(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "batch.expired" => true,
            "batch.failed" => true,
            "batch.succeeded" => true,
            "interaction.completed" => true,
            "interaction.failed" => true,
            "interaction.requires_action" => true,
            "video.generated" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(WebhookUpdateSubscribedEvent other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookUpdateSubscribedEvent other && Equals(other);
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
        public static bool operator ==(WebhookUpdateSubscribedEvent left, WebhookUpdateSubscribedEvent right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebhookUpdateSubscribedEvent left, WebhookUpdateSubscribedEvent right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookUpdateSubscribedEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookUpdateSubscribedEvent value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookUpdateSubscribedEvent? ToEnum(string value)
        {
            return WebhookUpdateSubscribedEvent.FromValue(value);
        }
    }
}