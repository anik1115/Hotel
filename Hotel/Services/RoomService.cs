using Hotel.Services.Interfaces;
using Hotel.Data.Entities;
using Hotel.Repositories.Interfaces;
using Hotel.Models.Room;

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
            var roomEntity = new Room(room.Number, room.Type, room.Rentability, room.Price);

            roomRepository.Add(roomEntity);
        }

        public IEnumerable<RoomViewModel> GetAll()
        {
            var roomEntities = roomRepository.GetAll();

            var rooms = roomEntities.Select(room => new RoomViewModel(room.Id, room.Number, room.Type, room.Rentability, room.Price));

            return rooms;
        }

        public RoomViewModel Get(int id)
                {
            var room = roomRepository.Get(id);

            return new RoomViewModel(room.Id, room.Number, room.Type, room.Rentability, room.Price);
        }
        public void Edit(EditRoomViewModel room)
        {
            var roomEntity = new Room(room.Id, room.Number, room.Type, room.Rentability, room.Price);

            roomRepository.Edit(roomEntity);
        }

        public void Delete(int id)
                => roomRepository.Delete(id);
    }
}
