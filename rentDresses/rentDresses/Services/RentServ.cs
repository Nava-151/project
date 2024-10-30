using Microsoft.AspNetCore.Mvc;

namespace rentDresses.services
{
    public class RentServ
    {
        public List<Rent> RentList { get; set; }
        public RentServ()
        {
            RentList = new List<Rent>();
        }
        public List<Rent> GetList()
        {
            return RentList;
        }
        public bool PostRent(Rent Rent)
        {
            RentList.Add(Rent);
            return true;
        }
        public bool DeleteRent(int id)
        {
            Rent r = RentList.Find(l => l.Id == id);
            if (r != null)
            {
                RentList.Remove(r);
                return true;
            }
            return false;
        }
        public bool PutRent(int id,Rent Rent)
        {
            Rent rent = RentList.Find(r => r.Id == id);
            if (rent != null)
            {
                RentList.Remove(rent);
                RentList.Add(Rent);
            }
            return false;
        }
        public Rent GetRentById(int id)
        {
            return RentList.Find(r => r.Id == id);
        }
    }
}