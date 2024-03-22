using Hotel.Data.Entities;
using Hotel.Models.Room;

namespace Hotel.Repositories.Interfaces
{
    public interface IRoomRepository
    {
        void Add(Room room);

        IEnumerable<Room> GetAll();

        void Delete(int id);

        void Edit(Room room);

        Room Get(int id);
    }
}
