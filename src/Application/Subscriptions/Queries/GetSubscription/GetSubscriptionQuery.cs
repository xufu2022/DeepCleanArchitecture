using Domain.Subscriptions;
using ErrorOr;
using MediatR;

namespace Application.Subscriptions.Queries.GetSubscription;

public record GetSubscriptionQuery(Guid SubscriptionId)
    : IRequest<ErrorOr<Subscription>>;