
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Optional. The state of the webhook.
    /// </summary>
    public enum WebhookUpdateState
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        DisabledDueToFailedDeliveries,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookUpdateStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookUpdateState value)
        {
            return value switch
            {
                WebhookUpdateState.Disabled => "disabled",
                WebhookUpdateState.DisabledDueToFailedDeliveries => "disabled_due_to_failed_deliveries",
                WebhookUpdateState.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookUpdateState? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => WebhookUpdateState.Disabled,
                "disabled_due_to_failed_deliveries" => WebhookUpdateState.DisabledDueToFailedDeliveries,
                "enabled" => WebhookUpdateState.Enabled,
                _ => null,
            };
        }
    }
}