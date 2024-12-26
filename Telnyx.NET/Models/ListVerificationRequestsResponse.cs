﻿using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for a list of verification requests.
    /// </summary>
    public class ListVerificationRequestsResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the collection of verification request records.
        /// </summary>
        [JsonPropertyName("records")]
        public List<VerificationRequestRecord>? Records { get; set; }

        /// <summary>
        /// Gets or sets the total number of verification request records available.
        /// </summary>
        [JsonPropertyName("total_records")]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// Represents any errors encountered during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents a single verification request record.
    /// </summary>
    public class VerificationRequestRecord : BaseVerificationRequestResponse
    {
    }
}