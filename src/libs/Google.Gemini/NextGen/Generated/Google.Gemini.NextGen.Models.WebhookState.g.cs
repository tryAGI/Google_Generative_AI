
#nullable enable

namespace Google.Gemini.NextGen
{
    /// <summary>
    /// Output only. The state of the webhook.<br/>
    /// Included only in responses
    /// </summary>
    public enum WebhookState
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
    public static class WebhookStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookState value)
        {
            return value switch
            {
                WebhookState.Disabled => "disabled",
                WebhookState.DisabledDueToFailedDeliveries => "disabled_due_to_failed_deliveries",
                WebhookState.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookState? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => WebhookState.Disabled,
                "disabled_due_to_failed_deliveries" => WebhookState.DisabledDueToFailedDeliveries,
                "enabled" => WebhookState.Enabled,
                _ => null,
            };
        }
    }
}