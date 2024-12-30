﻿using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BrandIdentityStatus
    {
        [JsonPropertyName("VERIFIED")]
        Verified,

        [JsonPropertyName("UNVERIFIED")]
        Unverified,

        [JsonPropertyName("SELF_DECLARED")]
        SelfDeclared,

        [JsonPropertyName("VETTED_VERIFIED")]
        VettedVerified
    }
}