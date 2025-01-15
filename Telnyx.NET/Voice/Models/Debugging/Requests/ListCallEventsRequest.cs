﻿using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Voice.Models.Debugging.Requests
{
    /// <summary>
    /// Represents a request for listing call events with various filters and pagination options.
    /// </summary>
    public class ListCallEventsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the leg ID to filter the call events by.
        /// </summary>
        [JsonPropertyName("filter[leg_id]")]
        public string? LegId { get; set; }

        /// <summary>
        /// Gets or sets the application session ID to filter the call events by.
        /// </summary>
        [JsonPropertyName("filter[application_session_id]")]
        public string? ApplicationSessionId { get; set; }

        /// <summary>
        /// Gets or sets the connection ID to filter the call events by.
        /// </summary>
        [JsonPropertyName("filter[connection_id]")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the product type to filter the call events by.
        /// </summary>
        [JsonPropertyName("filter[product]")]
        public ProductType? Product { get; set; }

        /// <summary>
        /// Gets or sets the start date and time to filter the call events by.
        /// </summary>
        [JsonPropertyName("filter[from]")]
        public string? From { get; set; }

        /// <summary>
        /// Gets or sets the end date and time to filter the call events by.
        /// </summary>
        [JsonPropertyName("filter[to]")]
        public string? To { get; set; }

        /// <summary>
        /// Gets or sets a flag to filter the call events by failed status.
        /// </summary>
        [JsonPropertyName("filter[failed]")]
        public bool? Failed { get; set; }

        /// <summary>
        /// Gets or sets the event type to filter the call events by.
        /// </summary>
        [JsonPropertyName("filter[type]")]
        public EventType? Type { get; set; }

        /// <summary>
        /// Gets or sets the name to filter the call events by.
        /// </summary>
        [JsonPropertyName("filter[name]")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the filter for call events that occurred after the specified date and time.
        /// </summary>
        [JsonPropertyName("filter[occurred_at][gt]")]
        public string? OccurredAtGt { get; set; }

        /// <summary>
        /// Gets or sets the filter for call events that occurred after or at the specified date and time.
        /// </summary>
        [JsonPropertyName("filter[occurred_at][gte]")]
        public string? OccurredAtGte { get; set; }

        /// <summary>
        /// Gets or sets the filter for call events that occurred before the specified date and time.
        /// </summary>
        [JsonPropertyName("filter[occurred_at][lt]")]
        public string? OccurredAtLt { get; set; }

        /// <summary>
        /// Gets or sets the filter for call events that occurred before or at the specified date and time.
        /// </summary>
        [JsonPropertyName("filter[occurred_at][lte]")]
        public string? OccurredAtLte { get; set; }

        /// <summary>
        /// Gets or sets the filter for call events that occurred exactly at the specified date and time.
        /// </summary>
        [JsonPropertyName("filter[occurred_at][eq]")]
        public string? OccurredAtEq { get; set; }

        /// <summary>
        /// Gets or sets the number of call events to retrieve per page (pagination).
        /// Default value is 20.
        /// </summary>
        [JsonPropertyName("page[size]")]
        public int? PageSize { get; set; } = 20;
    }
}