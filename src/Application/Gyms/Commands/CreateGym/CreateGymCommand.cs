using Application.Common.Authorization;
using Domain.Gyms;
using ErrorOr;
using MediatR;

namespace Application.Gyms.Commands.CreateGym;

[Authorize(Roles = "Admin")]
public record CreateGymCommand(string Name, Guid SubscriptionId) : IRequest<ErrorOr<Gym>>;