using Hotel.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

    }
}
