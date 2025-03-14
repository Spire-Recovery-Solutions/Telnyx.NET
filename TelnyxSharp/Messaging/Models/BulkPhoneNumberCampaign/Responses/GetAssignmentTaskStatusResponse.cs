﻿using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.BulkPhoneNumberCampaign.Responses
{
    /// <summary>
    /// Represents the response for retrieving the status of an assignment task.
    /// </summary>
    public class GetAssignmentTaskStatusResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the task ID associated with the assignment task.
        /// </summary>
        [JsonPropertyName("taskId")]
        public string TaskId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the status of the assignment task.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the creation timestamp of the assignment task.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last updated timestamp of the assignment task.
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}