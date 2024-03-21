using Hotel.Data.Entities;

namespace Hotel.Repositories.Interfaces
{
    public interface IRoomRepository
    {
        void Add(Room room);

        IEnumerable<Room> GetAll();

    }
}
