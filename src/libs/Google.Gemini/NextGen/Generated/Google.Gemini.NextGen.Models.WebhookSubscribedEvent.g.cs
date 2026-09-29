
#nullable enable

namespace Google.Gemini.NextGen
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct WebhookSubscribedEvent : global::System.IEquatable<WebhookSubscribedEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public WebhookSubscribedEvent(string value)
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
        public static WebhookSubscribedEvent BatchExpired { get; } = new("batch.expired");

        /// <summary>
        /// Batch job failed.
        /// </summary>
        public static WebhookSubscribedEvent BatchFailed { get; } = new("batch.failed");

        /// <summary>
        /// Batch processing finished successfully.
        /// </summary>
        public static WebhookSubscribedEvent BatchSucceeded { get; } = new("batch.succeeded");

        /// <summary>
        /// Interaction completed successfully.
        /// </summary>
        public static WebhookSubscribedEvent InteractionCompleted { get; } = new("interaction.completed");

        /// <summary>
        /// Interaction failed.
        /// </summary>
        public static WebhookSubscribedEvent InteractionFailed { get; } = new("interaction.failed");

        /// <summary>
        /// Interaction requires action (e.g., function calling).
        /// </summary>
        public static WebhookSubscribedEvent InteractionRequiresAction { get; } = new("interaction.requires_action");

        /// <summary>
        /// Video generation completed.
        /// </summary>
        public static WebhookSubscribedEvent VideoGenerated { get; } = new("video.generated");
        /// <summary>
        ///
        /// </summary>
        public static WebhookSubscribedEvent FromValue(string value)
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
                _ => new WebhookSubscribedEvent(value),
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
        public bool Equals(WebhookSubscribedEvent other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookSubscribedEvent other && Equals(other);
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
        public static bool operator ==(WebhookSubscribedEvent left, WebhookSubscribedEvent right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WebhookSubscribedEvent left, WebhookSubscribedEvent right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSubscribedEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSubscribedEvent value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSubscribedEvent? ToEnum(string value)
        {
            return WebhookSubscribedEvent.FromValue(value);
        }
    }
}