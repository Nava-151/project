using RentDress.Core.Entities;
using RentDress.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDress.Data.Repository
{
    public class DressRepository:IRepository<DressEntity>
    {
        readonly DataContext _dataContext;

        public DressRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<DressEntity> GetAllData()
        {
            return _dataContext.DressList;
        }

        public DressEntity? GetDataById(int id)
        {
            return _dataContext.DressList.Find(d => d.Id == id);
        }
        public bool Add(DressEntity entity)
        {
            try
            {
                _dataContext.DressList.Add(entity);
                _dataContext.SaveData();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                DressEntity entity = _dataContext.DressList.Find(d => d.Id == id);

                _dataContext.DressList.Remove(entity);
                _dataContext.SaveData();
                return true;
                
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        

        public bool Update(DressEntity entity)
        {
            try
            {
                DressEntity dress = _dataContext.DressList.Find(d => d.Id == entity.Id);
                if (dress == null)
                    return false;
                _dataContext.DressList.Remove(dress);
                _dataContext.DressList.Add(entity);
                _dataContext.SaveData();
                return true;
            }
            catch (Exception ex) { return false; }
          
        }

    }
}
