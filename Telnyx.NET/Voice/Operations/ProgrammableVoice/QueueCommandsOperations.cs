﻿using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Voice.Interfaces;
using Telnyx.NET.Voice.Models.QueueCommands.Requests;
using Telnyx.NET.Voice.Models.QueueCommands.Responses;

namespace Telnyx.NET.Voice.Operations.ProgrammableVoice
{
    public class QueueCommandsOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IQueueCommandsOperations
    {

        /// <inheritdoc />
        public async Task<RetrieveQueueResponse?> Retrieve(string queueName, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"queues/{queueName}");
            return await ExecuteAsync<RetrieveQueueResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrieveCallQueueResponse?> RetrieveQueueCall(string queueName, string callControlId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"queues/{queueName}/calls/{callControlId}");
            return await ExecuteAsync<RetrieveCallQueueResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrieveCallsQueueResponse?> RetrieveQueueCalls(string queueName, RetrieveCallsQueueRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"queues/{queueName}/calls")
                            .AddPagination(request.PageSize);

            return await ExecuteAsync<RetrieveCallsQueueResponse>(req, cancellationToken);
        }
    }
}