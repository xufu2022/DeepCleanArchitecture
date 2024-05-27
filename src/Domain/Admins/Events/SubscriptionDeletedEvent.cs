using Domain.Common;

namespace Domain.Admins.Events;

public record SubscriptionDeletedEvent(Guid SubscriptionId) : IDomainEvent;