using Hotel.Data.Entities;
using Hotel.Models.Room;

namespace Hotel.Services.Interfaces
{
    public interface IRoomService
    {
        public void Add(CreateRoomViewModel room)
        {
             throw new NotImplementedException();
        }

        IEnumerable<RoomViewModel> GetAll();
    }
}
