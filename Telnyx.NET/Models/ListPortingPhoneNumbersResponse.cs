﻿using Telnyx.NET.Interfaces;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Response object for retrieving a list of porting phone numbers.
    /// </summary>
    public class ListPortingPhoneNumbersResponse : ITelnyxResponse
    {
        /// <summary>
        /// A list containing the data of each porting phone number.
        /// </summary>
        [JsonPropertyName("data")]
        public List<ListPortingPhoneNumbersDatum> Data { get; set; } = new();

        /// <summary>
        /// Metadata for pagination, including page size, number, total pages, and results.
        /// </summary>
        [JsonPropertyName("meta")]
        public ListPortingPhoneNumbersMeta Meta { get; set; } = new();
    }

    /// <summary>
    /// Represents the details of an individual porting phone number.
    /// </summary>
    public class ListPortingPhoneNumbersDatum
    {
        /// <summary>
        /// Unique identifier for the phone number porting record.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Indicates if the phone number is activated.
        /// </summary>
        [JsonPropertyName("activate")]
        public string? Activate { get; set; }

        /// <summary>
        /// The type of record (usually phone number).
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// The phone number being ported.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Support key for tracking the porting process.
        /// </summary>
        [JsonPropertyName("support_key")]
        public string SupportKey { get; set; } = string.Empty;

        /// <summary>
        /// ID of the associated porting order.
        /// </summary>
        [JsonPropertyName("porting_order_id")]
        public string PortingOrderId { get; set; } = string.Empty;

        /// <summary>
        /// The status of the phone number's portability.
        /// </summary>
        [JsonPropertyName("portability_status")]
        public string PortabilityStatus { get; set; } = string.Empty;

        /// <summary>
        /// Type of the phone number (e.g., landline, mobile).
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string PhoneNumberType { get; set; } = string.Empty;

        /// <summary>
        /// The status of messaging porting, if applicable.
        /// </summary>
        [JsonPropertyName("messaging_port_status")]
        public string? MessagingPortStatus { get; set; }

        /// <summary>
        /// Reference to the block (if part of a block of numbers).
        /// </summary>
        [JsonPropertyName("block_reference_id")]
        public string? BlockReferenceId { get; set; }

        /// <summary>
        /// Current activation status of the phone number.
        /// </summary>
        [JsonPropertyName("activation_status")]
        public string? ActivationStatus { get; set; }

        /// <summary>
        /// Status of the requirements for porting the phone number.
        /// </summary>
        [JsonPropertyName("requirements_status")]
        public string RequirementsStatus { get; set; } = string.Empty;

        /// <summary>
        /// The current status of the porting order for the phone number.
        /// </summary>
        [JsonPropertyName("porting_order_status")]
        public string PortingOrderStatus { get; set; } = string.Empty;
    }

    /// <summary>
    /// Metadata for pagination details.
    /// </summary>
    public class ListPortingPhoneNumbersMeta
    {
        /// <summary>
        /// The number of records per page.
        /// </summary>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// The current page number.
        /// </summary>
        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// The total number of results available.
        /// </summary>
        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
    }
}