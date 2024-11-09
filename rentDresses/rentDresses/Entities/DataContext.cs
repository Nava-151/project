namespace rentDresses.Entities
{
    public class DataContext
    {
        public List<Availability> AvailabilityList { get; set; }
        public List<Dress> DressList { get; set; }
        public List<Rent> RentList { get; set; }
        public List<RentDetails> RentDetailsList { get; set; }
        public List<User> UserList { get; set; }
        public DataContext()
        {
            AvailabilityList = new List<Availability>();
            DressList = new List<Dress>();
            RentList = new List<Rent>();
            UserList = new List<User>();
            RentDetailsList = new List<RentDetails>();
        }

    }
}
