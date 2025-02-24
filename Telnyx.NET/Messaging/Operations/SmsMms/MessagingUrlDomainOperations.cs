using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.Messaging.Interfaces;
using Telnyx.NET.Messaging.Models.MessagingUrlDomain.Requests;
using Telnyx.NET.Messaging.Models.MessagingUrlDomain.Responses;

namespace Telnyx.NET.Messaging.Operations.SmsMms;

public class MessagingUrlDomainOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IMessagingUrlDomainOperations
{
    /// <inheritdoc />
    public async Task<ListMessagingUrlDomainsResponse?> List(ListMessagingUrlDomainsRequest request, CancellationToken cancellationToken = default)
    {
        var req = new RestRequest("messaging_url_domains")
            .AddPagination(request.PageSize);

        return await ExecuteAsync<ListMessagingUrlDomainsResponse>(req, cancellationToken);
    }
}