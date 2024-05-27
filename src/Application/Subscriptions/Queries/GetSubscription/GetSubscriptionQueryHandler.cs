using Application.Common.Interfaces;
using Domain.Subscriptions;
using ErrorOr;
using MediatR;

namespace Application.Subscriptions.Queries.GetSubscription;

public class GetSubscriptionQueryHandler(ISubscriptionsRepository subscriptionsRepository)
    : IRequestHandler<GetSubscriptionQuery, ErrorOr<Subscription>>
{
    private readonly ISubscriptionsRepository _subscriptionsRepository = subscriptionsRepository;

    public async Task<ErrorOr<Subscription>> Handle(GetSubscriptionQuery query, CancellationToken cancellationToken)
    {
        var subscription = await _subscriptionsRepository.GetByIdAsync(query.SubscriptionId);

        return subscription is null
            ? Error.NotFound(description: "Subscription not found")
            : subscription;
    }
}
