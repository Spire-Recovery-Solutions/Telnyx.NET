﻿using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents a delivery update event.
    /// </summary>
    public class DeliveryUpdateMessageProfile  : TelnyxEvent
    {
        /// <summary>
        /// Gets or sets the data associated with the delivery update event.
        /// </summary>
        [JsonPropertyName("data")]
        public DeliveryUpdateMessageProfileData Data { get; set; }
    }

    /// <summary>
    /// Represents the data details of a delivery update event.
    /// </summary>
    public class DeliveryUpdateMessageProfileData : BaseEvent
    {

        /// <summary>
        /// Gets or sets the payload containing delivery update details.
        /// </summary>
        [JsonPropertyName("payload")]
        public DeliveryUpdateMessageProfilePayload Payload { get; set; }
    }

    /// <summary>
    /// Represents the payload of a delivery update.
    /// </summary>
    public class DeliveryUpdateMessageProfilePayload : MessageBaseResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryUpdateMessageProfilePayload"/> class
        /// with default values for direction and record type.
        /// </summary>
        public DeliveryUpdateMessageProfilePayload()
        {
            Direction = MessageDirection.Outbound;
            RecordType = MessageRecordType.Message;
        }
    }
}