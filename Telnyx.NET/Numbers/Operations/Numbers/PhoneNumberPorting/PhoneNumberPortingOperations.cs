﻿using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Interfaces;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberPorting;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberPorting;

namespace Telnyx.NET.Numbers.Operations.Numbers.PhoneNumberPorting
{
    public class PhoneNumberPortingOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IPhoneNumberPortingOperations
    {
        /// <inheritdoc />
        public async Task<PortabilityCheckResponse> RunPortabilityCheck(PortabilityCheckRequest request, 
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("portability_checks", Method.Post);
            
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<PortabilityCheckResponse>(req, cancellationToken);
        }
    }
}