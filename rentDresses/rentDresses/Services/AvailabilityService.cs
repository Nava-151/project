using rentDresses.Entities;

namespace rentDresses.services
{
    public class AvailabilityService
    {
        public AvailabilityService()
        {
            DataContextManager d=new DataContextManager();
        }
        public List<Availability> GetList()
        {
            if (DataContextManager.DataContext.AvailabilityList == null)
                return new List<Availability>();
            return DataContextManager.DataContext.AvailabilityList;
        }
        public bool Add(Availability Availability)
        {
            if(DataContextManager.DataContext.AvailabilityList == null) {
                DataContextManager.DataContext.AvailabilityList = new List<Availability>();
            }
            DataContextManager.DataContext.AvailabilityList.Add(Availability);
            return true;
        }
        public bool DeleteAvailability(int id)
        {
            Availability a = DataContextManager.DataContext.AvailabilityList.Find(l => l.Id == id);
            if (a != null)
            {
                DataContextManager.DataContext.AvailabilityList.Remove(a);
                return true;
            }
            return false;
        }
        public bool Update(int id, Availability Availability)
        {
            Availability a = DataContextManager.DataContext.AvailabilityList.Find(d => d.Id == id);
            if (a != null)
            {
                DataContextManager.DataContext.AvailabilityList.Remove(a);
                DataContextManager.DataContext.AvailabilityList.Add(Availability);
            }
            return false;
        }
        public Availability GetAvailabilityById(int id)
        {
            return DataContextManager.DataContext.AvailabilityList.Find(d => d.Id == id);
        }
    }

}

