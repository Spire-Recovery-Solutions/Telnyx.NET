﻿using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    

    public partial class GetNumberOrderResponse : TelnyxResponse
    {
        [JsonPropertyName("data")]
        public NumberOrder Data { get; set; }
    }

}
