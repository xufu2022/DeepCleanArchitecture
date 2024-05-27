using Application.Common.Interfaces;
using Domain.Admins.Events;
using MediatR;

namespace Application.Gyms.Events;

public class SubscriptionDeletedEventHandler(
    IGymsRepository gymsRepository,
    IUnitOfWork unitOfWork)
        : INotificationHandler<SubscriptionDeletedEvent>
{
    public async Task Handle(SubscriptionDeletedEvent notification, CancellationToken cancellationToken)
    {
        var gyms = await gymsRepository.ListBySubscriptionIdAsync(notification.SubscriptionId);

        await gymsRepository.RemoveRangeAsync(gyms);
        await unitOfWork.CommitChangesAsync();
    }
}
