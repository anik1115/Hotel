using System.ComponentModel.DataAnnotations;

namespace Hotel.Data.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int RoomNumber { get; set; }

        [Required]
        public string RoomType { get; set; }

        [Required]
        public string TakenRoom { get; set; }

        [Required]
        public int Price { get; set; }

        public Room(int roomNumber, string roomType, string takenRoom, int price)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            TakenRoom = takenRoom;
            Price = price;
        }
    }
}
