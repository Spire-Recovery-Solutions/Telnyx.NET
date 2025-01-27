﻿using Polly.Retry;
using RestSharp;
using System.Text.Json;
using Telnyx.NET.Base;
using Telnyx.NET.PhoneNumber.Interfaces;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Requests;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Responses;

namespace Telnyx.NET.PhoneNumber.Operations.PhoneNumber
{
    public class PhoneNumberOrdersOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IPhoneNumberOrdersOperations
    {
        /// <inheritdoc />
        public async Task<ListNumberOrdersResponse> List(ListNumberOrdersRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("number_orders")
                .AddFilter("filter[status]", request.Status)
                .AddFilter("filter[created_at][gt]", request.CreatedAfter)
                .AddFilter("filter[created_at][lt]", request.CreatedBefore)
                .AddFilter("filter[customer_reference]", request.CustomerReference)
                .AddFilter("filter[phone_numbers_count]", request.PhoneNumberCount?.ToString())
                .AddFilter("filter[requirements_met]", request.RequirementsMet?.ToString().ToLowerInvariant())
                .AddPagination(request.PageSize);

            return await ExecuteAsync<ListNumberOrdersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetNumberOrderResponse> Get(string numberOrderId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"number_orders/{numberOrderId}");
            return await ExecuteAsync<GetNumberOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateNumberOrderResponse> Create(CreateNumberOrderRequest request,
        CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("number_orders", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CreateNumberOrderResponse>(req, cancellationToken);
        }
    }
}
