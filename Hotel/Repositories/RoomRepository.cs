using Hotel.Data;
using Hotel.Data.Entities;
using Hotel.Repositories.Interfaces;

namespace Hotel.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationContext context;

        public RoomRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public void Add(Room room)
        {
            context.Rooms.Add(room);
            context.SaveChanges();
        }
    }
}
