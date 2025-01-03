﻿using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for retrieving enumeration values.
    /// </summary>
    public class GetEnumResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the list of enumeration values.
        /// </summary>
        [JsonPropertyName("enum")]
        public List<string>? EnumValues { get; set; }
    }
}