using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class CreateRoomViewModel
    {

        public int RoomNumber { get; set; }

        public string RoomType { get; set; }

        public string TakenRoom { get; set; }

        public int Price { get; set; }
    }
}
