﻿using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for listing conferences.
    /// This model allows filtering the conferences by name and status, 
    /// and it supports pagination to manage the number of conferences returned.
    /// </summary>
    public class ListConferencesRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the name filter for the conferences.
        /// If provided, only conferences with names that match this filter will be returned.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the status filter for the conferences.
        /// If provided, only conferences with the specified status will be returned.
        /// The status can be one of the values from the <see cref="ConferenceStatus"/> enum.
        /// </summary>
        public ConferenceStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets the number of conferences to be returned per page.
        /// The default page size is 20.
        /// </summary>
        public int? PageSize { get; set; } = 20;
    }
}