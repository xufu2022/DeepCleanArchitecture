using ErrorOr;
using MediatR;

namespace Application.Profiles.Commands.CreateAdminProfile;

public record CreateAdminProfileCommand(Guid UserId)
    : IRequest<ErrorOr<Guid>>;
