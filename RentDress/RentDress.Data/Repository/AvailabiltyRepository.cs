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
            return _dataContext.AvailabilityList.ToList();
        }

        public AvailabilityEntity? GetDataById(int id)
        {
            return _dataContext.AvailabilityList.ToList().Find(d => d.Id == id);
        }
        public bool Add(AvailabilityEntity entity)
        {
            try
            {
                _dataContext.AvailabilityList.Add(entity);
                _dataContext.SaveChanges();
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
                AvailabilityEntity entity = _dataContext.AvailabilityList.ToList().Find(d => d.Id == id);
                _dataContext.AvailabilityList.Remove(entity);
                _dataContext.SaveChanges();
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
                int index = _dataContext.AvailabilityList.ToList().FindIndex(d => d.Id == entity.Id);
                if (index < 0)
                    return false;
                if (_dataContext.AvailabilityList.ToList()[index].RentCode > 0)
                    _dataContext.AvailabilityList.ToList()[index].RentCode = entity.RentCode;

                if (_dataContext.AvailabilityList.ToList()[index].DressCode > 0)
                    _dataContext.AvailabilityList.ToList()[index].DressCode = entity.DressCode;

                if (_dataContext.AvailabilityList.ToList()[index].From != new DateTime())
                    _dataContext.AvailabilityList.ToList()[index].From = entity.From;

                if (_dataContext.AvailabilityList.ToList()[index].To != entity.To)
                    _dataContext.AvailabilityList.ToList()[index].To = entity.To;

                if (_dataContext.AvailabilityList.ToList()[index].AmountTaken > 0)
                    _dataContext.AvailabilityList.ToList()[index].AmountTaken = entity.AmountTaken;

                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }

        }

        public int GetIndex(int id)
        {
            return _dataContext.AvailabilityList.ToList().FindIndex(a=>a.Id== id); 
        }

        
    }

}
