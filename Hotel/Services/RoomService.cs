using Hotel.Services.Interfaces;
using Hotel.Models;
using Hotel.Data.Entities;
using Hotel.Repositories.Interfaces;
namespace Hotel.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            this.roomRepository = roomRepository;
        }
        public void Add(CreateRoomViewModel room)
        {
            var roomEntity = new Room(room.RoomNumber, room.RoomType, room.TakenRoom, room.Price);

            roomRepository.Add(roomEntity);
        }
    }
}
