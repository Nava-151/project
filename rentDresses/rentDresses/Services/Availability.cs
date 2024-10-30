namespace rentDresses.services
{
    public class Availability
    {
        public int Id { get; set; }
        public int DressCode { get; set; }
        public int RentCOde { get; set; }
        public DateOnly From { get; set; }
        public DateOnly To { get; set; }
        public int AmountTaken { get; set; }
    }
}
