namespace rentDresses.Entities
{
    public enum Seazon { Winter, Fall, Spring, Summer }
    public class Dress
    {

        public int Id { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }

        public Seazon Seazons { get; set; }
        public int Amount { get; set; }
        public string FabricType { get; set; }
        public DateTime YearOfManufacture { get; set; }

        public Dress(int id, int size, string color, Seazon seazons, int amount, string fabricType, DateTime yearOfManufacture)
        {
            Id = id;
            Size = size;
            Color = color;
            Seazons = seazons;
            Amount = amount;
            FabricType = fabricType;
            YearOfManufacture = yearOfManufacture;
        }
    }
}
