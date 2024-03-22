using System.ComponentModel.DataAnnotations;

namespace Hotel.Data.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Rentability { get; set; }

        [Required]
        public int Price { get; set; }

        public Room() 
        { }
        public Room(int number, string type, string rentability, int price)
        {
            Number = number;
            Type = type;
            Rentability = rentability;
            Price = price;
        }

        public Room(int id, int number, string type, string rentability, int price)
            : this(number, type, rentability, price)
        {
            Id = id;
        }
    }
}
