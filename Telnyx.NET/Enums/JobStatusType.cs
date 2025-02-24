﻿using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the status of a job or process, indicating its current state in the workflow.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum JobStatusType
    {
        /// <summary>
        /// The job is pending and has not started yet.
        /// </summary>
        [JsonPropertyName("pending")]
        Pending,

        /// <summary>
        /// The job is currently in progress.
        /// </summary>
        [JsonPropertyName("in_progress")]
        InProgress,

        /// <summary>
        /// The job has been completed successfully.
        /// </summary>
        [JsonPropertyName("completed")]
        Completed,

        /// <summary>
        /// The job has failed and was not successfully completed.
        /// </summary>
        [JsonPropertyName("failed")]
        Failed
    }
}