namespace rentDresses.Entities
{
    public enum Pay { credit, cash, check }
    public class Rent
    {
        //link to customers
        public int Id { get; set; }
        public DateOnly CollectionDate { get; set; }
        public DateOnly ReturnDate { get; set; }
        public double TotalPrice { get; set; }
        public DateOnly CreateDate { get; set; }
        public string Name { get; set; }
        public Pay Payment { get; set; }

    }
}
