namespace rentDresses.services
{
    public class RentDetailsService
    {
        public List<RentDetails> RentDetailsList { get; set; }
        public RentDetailsService()
        {
            RentDetailsList = new List<RentDetails>();
        }
        public List<RentDetails> GetList()
        {
            return RentDetailsList;
        }
        public bool PostRentDetails(RentDetails RentDetails)
        {
            RentDetailsList.Add(RentDetails);
            return true;
        }
        public bool DeleteRentDetails(int id)
        {
            RentDetails u = RentDetailsList.Find(l => l.Id == id);
            if (u != null)
            {
                RentDetailsList.Remove(u);
                return true;
            }
            return false;
        }
        public bool PutRentDetails(int id, RentDetails RentDetails)
        {
            RentDetails d = RentDetailsList.Find(d => d.Id == id);
            if (d != null)
            {
                RentDetailsList.Remove(d);
                RentDetailsList.Add(RentDetails);
            }
            return false;
        }
        public RentDetails GetRentDetailsById(int id)
        {
            return RentDetailsList.Find(d => d.Id == id);
        }
    }

}

