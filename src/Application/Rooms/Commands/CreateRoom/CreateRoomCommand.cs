using Domain.Rooms;
using ErrorOr;
using MediatR;

namespace Application.Rooms.Commands.CreateRoom;

public record CreateRoomCommand(
    Guid GymId,
    string RoomName) : IRequest<ErrorOr<Room>>;