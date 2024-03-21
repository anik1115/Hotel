using System.ComponentModel.DataAnnotations;

namespace Hotel.Models.Room
{
    public class CreateRoomViewModel
    {

        public int Number { get; set; }

        public string Type { get; set; }

        public string Rentability { get; set; }

        public int Price { get; set; }
    }
}
