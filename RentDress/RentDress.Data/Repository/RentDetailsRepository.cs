using RentDress.Core.Entities;
using RentDress.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDress.Data.Repository
{
    public class RentDetailsRepository : IRepository<RentDetailsEntity>
    {
        readonly DataContext _dataContext;

        public RentDetailsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<RentDetailsEntity> GetAllData()
        {
            return _dataContext.RentDetailsList;
        }

        public RentDetailsEntity GetDataById(int id)
        {
            return _dataContext.RentDetailsList.Find(d => d.Id == id);
        }
        public bool Add(RentDetailsEntity entity)
        {
            try
            {
                _dataContext.RentDetailsList.Add(entity);
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
                RentDetailsEntity entity = _dataContext.RentDetailsList.Find(d => d.Id == id);

                _dataContext.RentDetailsList.Remove(entity);
                _dataContext.SaveData();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public bool Update(RentDetailsEntity entity)
        {
            try
            {
                RentDetailsEntity rentDetails = _dataContext.RentDetailsList.Find(d => d.Id == entity.Id);
                if (rentDetails == null)
                    return false;
                _dataContext.RentDetailsList.Remove(rentDetails);
                _dataContext.RentDetailsList.Add(entity);
                _dataContext.SaveData();
                return true;
            }
            catch (Exception ex) { return false; }

        }

    }
}
