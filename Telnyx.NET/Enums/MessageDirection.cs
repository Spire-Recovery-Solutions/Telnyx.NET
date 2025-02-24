﻿using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the direction of a message.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MessageDirection
    {
        /// <summary>
        /// The direction of the message is unknown or unspecified.
        /// </summary>
        [JsonPropertyName("Unknown")]
        Unknown,

        /// <summary>
        /// The message is sent from the sender to the recipient.
        /// </summary>
        [JsonPropertyName("outbound")]
        Outbound,

        /// <summary>
        /// The message is received by the recipient.
        /// </summary>
        [JsonPropertyName("inbound")]
        Inbound
    }
}