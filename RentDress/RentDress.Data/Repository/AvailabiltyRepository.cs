using RentDress.Core.Entities;
using RentDress.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDress.Data.Repository
{
   
        public class AvailabilityRepository : IRepository<AvailabilityEntity>
        {
            readonly DataContext _dataContext;

            public AvailabilityRepository(DataContext dataContext)
            {
                _dataContext = dataContext;
            }

            public List<AvailabilityEntity> GetAllData()
            {
                return _dataContext.AvailabilityList;
            }

            public AvailabilityEntity? GetDataById(int id)
            {
                return _dataContext.AvailabilityList.Find(d => d.Id == id);
            }
            public bool Add(AvailabilityEntity entity)
            {
                try
                {
                    _dataContext.AvailabilityList.Add(entity);
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
                AvailabilityEntity entity = _dataContext.AvailabilityList.Find(d => d.Id == id);
                    _dataContext.AvailabilityList.Remove(entity);
                    _dataContext.SaveData();
                    return true;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }



            public bool Update(AvailabilityEntity entity)
            {
                try
                {
                    AvailabilityEntity availability = _dataContext.AvailabilityList.Find(d => d.Id == entity.Id);
                    if (availability == null)
                        return false;
                    _dataContext.AvailabilityList.Remove(availability);
                    _dataContext.AvailabilityList.Add(entity);
                    _dataContext.SaveData();
                    return true;
                }
                catch (Exception ex) { return false; }

            }

        }
    
}
