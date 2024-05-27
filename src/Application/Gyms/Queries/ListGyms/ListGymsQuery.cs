using Domain.Gyms;
using ErrorOr;
using MediatR;

namespace Application.Gyms.Queries.ListGyms;

public record ListGymsQuery(Guid SubscriptionId) : IRequest<ErrorOr<List<Gym>>>;