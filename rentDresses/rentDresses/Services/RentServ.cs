using Microsoft.AspNetCore.Mvc;
using rentDresses.Entities;

namespace rentDresses.services
{
    public class RentServ
    {
        
        public List<Rent> GetList()
        {
            if(DataContextManager.DataContext.RentList == null)
                DataContextManager.DataContext.RentList = new List<Rent>();

            return DataContextManager.DataContext.RentList;
        }

        public bool Add(Rent Rent)
        {
            DataContextManager.DataContext.RentList.Add(Rent);
            return true;
        }

        public bool DeleteRent(int id)
        {
            Rent r = DataContextManager.DataContext.RentList.Find(l => l.Id == id);
            if (r != null)
            {
                DataContextManager.DataContext.RentList.Remove(r);
                return true;
            }
            return false;
        }

        public bool Update(int id,Rent Rent)
        {
            Rent rent = DataContextManager.DataContext.RentList.Find(r => r.Id == id);
            if (rent != null)
            {
                DataContextManager.DataContext.RentList.Remove(rent);
                DataContextManager.DataContext.RentList.Add(Rent);
            }
            return false;
        }
        public Rent GetRentById(int id)
        {
            return DataContextManager.DataContext.RentList.Find(r => r.Id == id);
        }
    }
}