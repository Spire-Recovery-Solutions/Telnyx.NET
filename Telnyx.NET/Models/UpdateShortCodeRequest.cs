﻿using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class UpdateShortCodeRequest : ITelnyxRequest
    {
        /// <summary>
        /// Unique identifier for a messaging profile. To unbind a short code, set to null or an empty string.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public required string MessagingProfileId { get; set; }
    }
}