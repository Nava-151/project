using Microsoft.AspNetCore.Mvc;

namespace rentDresses.services
{
    public class DressService
    {
        public List<Dress> DressList { get; set; }
        public DressService()
        {
            DressList = new List<Dress>();
            DateTime d=new DateTime(2000,10,1);
            Dress dre=new Dress(1, 1, "red", Seazon.Fall, 3, "saten", d);
            DressList.Add(dre);
        }
        public List<Dress> GetList()
        {
            return DressList;
        }
        public bool PostDress(Dress dress)
        {
            DressList.Add(dress);
            return true;
        }
        public bool DeleteDress(int id)
        {
            Dress d = DressList.Find(l => l.Id == id);
            if (d != null)
            {
                DressList.Remove(d);
                return true;
            }
            return false;
        }
        public bool PutDress(int id,Dress dress)
        {
            Dress d = DressList.Find(d => d.Id == id);
            if (d != null)
            {
                DressList.Remove(d);
                DressList.Add(dress);
            }
            return false;
        }
        public Dress GetDressById(int id)
        {
            return DressList.Find(d => d.Id == id);
        }
    }
}