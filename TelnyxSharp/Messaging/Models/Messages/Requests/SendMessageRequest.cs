﻿
using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Messaging.Models.Messages.Requests
{
    public sealed class SendMessageRequest : MessageBaseRequest, ITelnyxRequest
    {
        /// <summary>
        /// The phone number the message will be sent from.
        /// </summary>
        [JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// Id of the messaging profile settings to use
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// The type of message being sent (e.g., "sms", "mms").
        /// </summary>
        [JsonPropertyName("type")]
        public MessageType? Type { get; set; }

        /// <summary>
        /// Indicates whether to automatically detect the message type.
        /// </summary>
        [JsonPropertyName("auto_detect")]
        public bool? AutoDetect { get; set; }
    }
}
