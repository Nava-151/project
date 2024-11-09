using Microsoft.AspNetCore.Mvc;
using rentDresses.Entities;

namespace rentDresses.services
{
    public class DressService
    {

        public List<Dress> GetList()
        {
            if (DataContextManager.DataContext.DressList == null)
                DataContextManager.DataContext.DressList = new List<Dress>();
            return DataContextManager.DataContext.DressList;
        }
        public Dress GetDressById(int id)
        {
            return DataContextManager.DataContext.DressList.Find(d => d.Id == id);
        }

        public bool Add(Dress dress)
        {
            if (DataContextManager.DataContext.DressList.Find(d => dress.Id == d.Id) == null)
                return false;
            DataContextManager.DataContext.DressList.Add(dress);
            return true;
        }

        public bool DeleteDress(int id)
        {
            Dress d = DataContextManager.DataContext.DressList.Find(l => l.Id == id);
            if (d != null)
            {
                DataContextManager.DataContext.DressList.Remove(d);
                return true;
            }
            return false;
        }

        public bool Update(int id, Dress dress)
        {
            Dress d = DataContextManager.DataContext.DressList.Find(d => d.Id == id);
            if (d != null)
            {
                DataContextManager.DataContext.DressList.Remove(d);
                DataContextManager.DataContext.DressList.Add(dress);
            }
            return false;


        }






    }
}

