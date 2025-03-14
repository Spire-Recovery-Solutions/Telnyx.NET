﻿using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberConfigurations;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberConfigurations
{
    /// <summary>
    /// Request model for updating the voice settings of a phone number.
    /// This model is used to modify the voice-related settings of a phone number such as call forwarding, CNAM listing, and call recording.
    /// </summary>
    public class UpdateNumberVoiceSettingsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets a value indicating whether the tech prefix feature is enabled for the phone number.
        /// If enabled, the phone number will be prefixed with the specified technology prefix.
        /// </summary>
        [JsonPropertyName("tech_prefix_enabled")]
        public bool? TechPrefixEnabled { get; set; }

        /// <summary>
        /// Gets or sets the translated number to be used for the phone number. This is typically used for number translation services.
        /// </summary>
        [JsonPropertyName("translated_number")]
        public string? TranslatedNumber { get; set; }

        /// <summary>
        /// Gets or sets the call forwarding settings for the phone number.
        /// This allows the phone number to forward incoming calls to another number, with configurable forwarding rules.
        /// </summary>
        [JsonPropertyName("call_forwarding")]
        public CallForwardingSettings? CallForwarding { get; set; }

        /// <summary>
        /// Gets or sets the CNAM (Caller ID Name) listing settings for the phone number.
        /// This allows for the customization or enabling/disabling of caller ID name information for outgoing calls.
        /// </summary>
        [JsonPropertyName("cnam_listing")]
        public CnamListingSettings? CnamListing { get; set; }

        /// <summary>
        /// Gets or sets the usage payment method for the phone number. This specifies how the phone number's usage costs will be billed.
        /// </summary>
        [JsonPropertyName("usage_payment_method")]
        public string? UsagePaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets the media features related to the voice settings of the phone number.
        /// This includes features like voicemail, messaging, and other media-related services.
        /// </summary>
        [JsonPropertyName("media_features")]
        public MediaFeatures? MediaFeatures { get; set; }

        /// <summary>
        /// Gets or sets the call recording settings for the phone number.
        /// This allows the configuration of automatic call recording features for the phone number.
        /// </summary>
        [JsonPropertyName("call_recording")]
        public CallRecordingSettings? CallRecording { get; set; }
    }
}