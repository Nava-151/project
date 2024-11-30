using RentDress.Core.Entities;
using RentDress.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDress.Data.Repository
{
    public class RentRepository : IRepository<RentEntity>
    {
        readonly DataContext _dataContext;

        public RentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<RentEntity> GetAllData()
        {
            return _dataContext.RentList;
        }

        public RentEntity? GetDataById(int id)
        {
            return _dataContext.RentList.Find(d => d.Id == id);
        }
        public bool Add(RentEntity entity)
        {
            try
            {
                _dataContext.RentList.Add(entity);
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
                RentEntity entity = _dataContext.RentList.Find(d => d.Id == id);

                _dataContext.RentList.Remove(entity);
                _dataContext.SaveData();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public bool Update(RentEntity entity)
        {
            try
            {
                RentEntity rent = _dataContext.RentList.Find(d => d.Id == entity.Id);
                if (rent == null)
                    return false;
                _dataContext.RentList.Remove(rent);
                _dataContext.RentList.Add(entity);
                _dataContext.SaveData();
                return true;
            }
            catch (Exception ex) { return false; }

        }

        
    }
}
