using rentDresses.Entities;

namespace rentDresses.services
{
    public class RentDetailsService
    {

        
        public List<RentDetails> GetList()
        {
            if(DataContextManager.DataContext.RentDetailsList== null)
                DataContextManager.DataContext.RentDetailsList = new List<RentDetails>();

            return DataContextManager.DataContext.RentDetailsList;
        }

        public bool Add(RentDetails RentDetails)
        {
            DataContextManager.DataContext.RentDetailsList.Add(RentDetails);
            return true;
        }

        public bool DeleteRentDetails(int id)
        {
            RentDetails u = DataContextManager.DataContext.RentDetailsList.Find(l => l.Id == id);
            if (u != null)
            {
                DataContextManager.DataContext.RentDetailsList.Remove(u);
                return true;
            }
            return false;
        }

        public bool Update(int id, RentDetails RentDetails)
        {
            RentDetails d = DataContextManager.DataContext.RentDetailsList.Find(d => d.Id == id);
            if (d != null)
            {
                DataContextManager.DataContext.RentDetailsList.Remove(d);
                DataContextManager.DataContext.RentDetailsList.Add(RentDetails);
            }
            return false;
        }

        public RentDetails GetRentDetailsById(int id)
        {
            return DataContextManager.DataContext.RentDetailsList.Find(d => d.Id == id);
        }
    }

}

