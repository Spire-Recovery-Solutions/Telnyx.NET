﻿using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.SharedCampaign.Responses
{
    /// <summary>
    /// Represents the response for listing shared campaigns.
    /// </summary>
    public class ListSharedCampaignsResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the list of shared campaign records.
        /// </summary>
        [JsonPropertyName("records")]
        public List<SharedCampaignRecord>? Records { get; set; }

        /// <summary>
        /// Gets or sets the current page number in the paginated response.
        /// </summary>
        [JsonPropertyName("page")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the total number of records available.
        /// </summary>
        [JsonPropertyName("totalRecords")]
        public int TotalRecords { get; set; }

        /// <summary>
        /// Represents any errors encountered during the retrieval of the auto-response setting.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }

    /// <summary>
    /// Represents a shared campaign record in the response.
    /// </summary>
    public class SharedCampaignRecord : BaseSharedCampaigns
    {
    }
}