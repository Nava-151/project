using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
            return _dataContext.RentDetailsList.ToList();
        }

        public RentDetailsEntity GetDataById(int id)
        {
            return _dataContext.RentDetailsList.ToList().Find(d => d.Id == id);
        }
        public bool Add(RentDetailsEntity entity)
        {
            try
            {
                _dataContext.RentDetailsList.Add(entity);
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
                RentDetailsEntity entity = _dataContext.RentDetailsList.ToList().Find(d => d.Id == id);

                _dataContext.RentDetailsList.Remove(entity);
                _dataContext.SaveChanges();
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

                int index = _dataContext.RentDetailsList.ToList().FindIndex(d => d.Id == entity.Id);
                if (index < 0)
                    return false;
                if (_dataContext.RentDetailsList.ToList()[index].UserCode > 0)
                    _dataContext.RentDetailsList.ToList()[index].UserCode = entity.UserCode;

                if (_dataContext.RentDetailsList.ToList()[index].RentCode > 0)
                    _dataContext.RentDetailsList.ToList()[index].RentCode = entity.RentCode;

                if (_dataContext.RentDetailsList.ToList()[index].DressCode > 0)
                    _dataContext.RentDetailsList.ToList()[index].DressCode = entity.DressCode;


                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }

        }
        public int GetIndex(int id)
        {
            return _dataContext.RentDetailsList.ToList().FindIndex(a => a.Id == id);
        }


    }
}
