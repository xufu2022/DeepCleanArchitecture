using ErrorOr;
using MediatR;

namespace Application.Profiles.Queries.ListProfiles;

public record ListProfilesQuery(Guid UserId) : IRequest<ErrorOr<ListProfilesResult>>;