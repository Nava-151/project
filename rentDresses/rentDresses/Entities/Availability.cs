namespace rentDresses.Entities
{
    public class Availability
    {
        public int Id { get; set; }
        public int DressCode { get; set; }
        public int RentCOde { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public int AmountTaken { get; set; }
    }
}
