﻿using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Interfaces;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.NumbersFeatures;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.NumbersFeatures;

namespace Telnyx.NET.Numbers.Operations.Numbers.PhoneNumbers
{
    public class NumbersFeaturesOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), INumbersFeaturesOperations
    {
        /// <inheritdoc />
        public async Task<GetNumbersFeaturesResponse> Get(GetNumbersFeaturesRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("numbers_features", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<GetNumbersFeaturesResponse>(req, cancellationToken);
        }
    }
}