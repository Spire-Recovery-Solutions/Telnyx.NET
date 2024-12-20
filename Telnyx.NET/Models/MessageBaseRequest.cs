﻿using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    public abstract class MessageBaseRequest
    {
        /// <summary>
        /// The phone number the message will be sent to.
        /// </summary>
        [JsonPropertyName("to")]
        public string To { get; set; } = string.Empty;

        /// <summary>
        /// The text content of the message.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The subject of the message, primarily used for MMS messages.
        /// </summary>
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// A list of media URLs to include in the message.
        /// </summary>
        [JsonPropertyName("media_urls")]
        public List<string>? MediaUrls { get; set; }

        /// <summary>
        /// The URL where webhook events will be sent.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// A failover URL for webhook events if the primary webhook fails.
        /// </summary>
        [JsonPropertyName("webhook_failover_url")]
        public string? WebhookFailoverUrl { get; set; }

        /// <summary>
        /// Indicates whether to use the profile's default webhooks.
        /// </summary>
        [JsonPropertyName("use_profile_webhooks")]
        public bool? UseProfileWebhooks { get; set; } = true;

        /// <summary>
        /// The type of message being sent (e.g., "sms", "mms").
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Indicates whether to automatically detect the message type.
        /// </summary>
        [JsonPropertyName("auto_detect")]
        public bool? AutoDetect { get; set; }
    }
}
