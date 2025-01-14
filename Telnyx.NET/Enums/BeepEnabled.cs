﻿using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enum representing the different settings for when a beep should be enabled in a conference call or communication system.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BeepEnabled
    {
        /// <summary>
        /// Beep will always be enabled during the call.
        /// </summary>
        [JsonPropertyName("always")]
        Always,

        /// <summary>
        /// Beep will never be enabled during the call.
        /// </summary>
        [JsonPropertyName("never")]
        Never,

        /// <summary>
        /// Beep will be enabled when participants enter the call.
        /// </summary>
        [JsonPropertyName("on_enter")]
        OnEnter,

        /// <summary>
        /// Beep will be enabled when participants exit the call.
        /// </summary>
        [JsonPropertyName("on_exit")]
        OnExit
    }
}