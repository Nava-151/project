using Microsoft.AspNetCore.Mvc;
using rentDresses.Entities;

namespace rentDresses.services
{
    public class DressService
    {
        readonly IdataContext _dataContext;

        public DressService()
        {
            
        }
        public DressService(IdataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Dress> GetList()
        {
            var data = _dataContext.Load();
            if (data == null)
                return new List<Dress>();
            return data.ToList();
        }
        public Dress GetDressById(int id)
        {
            // return DataContextManager.DataContext.DressList.Find(d => d.Id == id);
            var data = _dataContext.Load();
            if (data == null)
                return null;
            return data.Where(c=>c.Id==id).FirstOrDefault();

        }

        public bool Add(Dress dress)
        {
            //    if (DataContextManager.DataContext.DressList.Find(d => dress.Id == d.Id) == null)
            //        return false;
            //    DataContextManager.DataContext.DressList.Add(dress);
            //    return true;
            var data = _dataContext.Load();
            if (data == null)
                return false;
            data.Add(dress);
            return _dataContext.Save(data);
        }

        public bool DeleteDress(int id)
        {
            //Dress d = DataContextManager.DataContext.DressList.Find(l => l.Id == id);
            //if (d != null)
            //{
            //    DataContextManager.DataContext.DressList.Remove(d);
            //    return true;
            //}
            //return false;
            List<Dress> data = _dataContext.Load();
            if (data == null)
                return false;
            data.Remove(data.Find(c => c.Id == id));
            return _dataContext.Save(data);
        }

        public bool Update(int id, Dress dress)
        {
            //Dress d = DataContextManager.DataContext.DressList.Find(d => d.Id == id);
            //if (d != null)
            //{
            //    DataContextManager.DataContext.DressList.Remove(d);
            //    DataContextManager.DataContext.DressList.Add(dress);
            //}
            //return false;
            List<Dress> data = _dataContext.Load();
            if (data == null)
                return false;
            data.Remove(data.Find(c => c.Id == id));
            data.Add(dress);
            return _dataContext.Save(data);

        }
    }
}

