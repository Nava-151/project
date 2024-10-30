namespace rentDresses.services
{
    public class AvailabilityService
    {
        public List<Availability> AvailabilityList { get; set; }
        public AvailabilityService()
        {
            AvailabilityList = new List<Availability>();
        }
        public List<Availability> GetList()
        {
            return AvailabilityList;
        }
        public bool PostAvailability(Availability Availability)
        {
            AvailabilityList.Add(Availability);
            return true;
        }
        public bool DeleteAvailability(int id)
        {
            Availability a = AvailabilityList.Find(l => l.Id == id);
            if (a != null)
            {
                AvailabilityList.Remove(a);
                return true;
            }
            return false;
        }
        public bool PutAvailability(int id, Availability Availability)
        {
            Availability a = AvailabilityList.Find(d => d.Id == id);
            if (a != null)
            {
                AvailabilityList.Remove(a);
                AvailabilityList.Add(Availability);
            }
            return false;
        }
        public Availability GetAvailabilityById(int id)
        {
            return AvailabilityList.Find(d => d.Id == id);
        }
    }

}

