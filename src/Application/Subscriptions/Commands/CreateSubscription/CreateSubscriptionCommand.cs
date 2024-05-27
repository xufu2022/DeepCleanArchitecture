using Domain.Subscriptions;
using ErrorOr;
using MediatR;

namespace Application.Subscriptions.Commands.CreateSubscription;

public record CreateSubscriptionCommand(
    SubscriptionType SubscriptionType,
    Guid AdminId) : IRequest<ErrorOr<Subscription>>;