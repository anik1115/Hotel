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

        public IEnumerable<Room> GetAll()
            => context.Rooms.ToList();

        
        public void Delete(int id)
        {
            var room = Get(id);

            context.Rooms.Remove(room);
            context.SaveChanges();
        }

        public void Edit(Room room)
        {
            var entity = Get(room.Id);

            entity.Number = room.Number;
            entity.Type = room.Type;
            entity.Rentability = room.Rentability;
            entity.Price = room.Price;

            context.SaveChanges();
        }

        public Room Get(int id)
            => context.Rooms.FirstOrDefault(room => room.Id == id);

    }
}
