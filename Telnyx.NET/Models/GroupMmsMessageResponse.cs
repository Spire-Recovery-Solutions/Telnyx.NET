﻿using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response returned after sending a group MMS message.
    /// </summary>
    public class GroupMmsMessageResponse : ITelnyxResponse
    {
        /// <summary>
        /// Contains the detailed data of the group MMS message response.
        /// </summary>
        [JsonPropertyName("data")]
        public GroupMmsMessageData? Data { get; set; }

        /// <summary>
        /// Gets or sets any errors that occurred during the API request.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Contains the detailed message data for a group MMS message response.
    /// Inherits common response properties from <see cref="MessageBaseResponse"/>.
    /// </summary>
    public class GroupMmsMessageData : MessageBaseResponse
    {
    }
}