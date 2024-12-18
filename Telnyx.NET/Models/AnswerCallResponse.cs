﻿using Telnyx.NET.Interfaces;
using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response from the Telnyx API for the Answer Call command.
    /// </summary>
    public class AnswerCallResponse : ITelnyxResponse
    {
        /// <summary>
        /// The data object containing the result of the API call.
        /// </summary>
        [JsonPropertyName("data")]
        public AnswerCallResponseData? Data { get; set; }

        /// <summary>
        /// List of errors, if any occurred during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }

    }

    /// <summary>
    /// Represents the data object in the Answer Call response.
    /// </summary>
    public class AnswerCallResponseData
    {
        /// <summary>
        /// The result of the Answer Call command.
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; } = "Unexpected error";
    }
}