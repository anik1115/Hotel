namespace Hotel.Models.Room
{
    public class RoomViewModel
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string Type { get; set; }

        public string Rentability { get; set; }

        public int Price { get; set; }

        public RoomViewModel(int id, int number, string type, string rentability, int price)
        {
            Id = id;
            Number = number;
            Type = type;
            Rentability = rentability;
            Price = price;
        }
    }
}
