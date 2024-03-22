using Hotel.Data.Entities;
using Hotel.Models.Room;

namespace Hotel.Services.Interfaces
{
    public interface IRoomService
    {
        void Add(CreateRoomViewModel room);
        IEnumerable<RoomViewModel> GetAll();

        void Delete(int id);

        void Edit(EditRoomViewModel room);

        RoomViewModel Get(int id);
    }
}
