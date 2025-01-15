﻿using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    public class UpdateVerificationRequestResponse : BaseVerificationRequestResponse
    {
         /// <summary>
        /// Gets or sets the unique identifier for the verification request.
        /// This ID is returned after submitting a verification request.
        /// </summary>
        [JsonPropertyName("verificationRequestId")]
        public string VerificationRequestId { get; set; } = string.Empty;
    }
}