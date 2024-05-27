using Domain.Gyms;
using ErrorOr;
using MediatR;

namespace Application.Gyms.Queries.GetGym;

public record GetGymQuery(Guid SubscriptionId, Guid GymId) : IRequest<ErrorOr<Gym>>;