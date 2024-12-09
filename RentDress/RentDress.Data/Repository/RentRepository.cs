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
            return _dataContext.RentList.ToList();
        }

        public RentEntity? GetDataById(int id)
        {
            return _dataContext.RentList.ToList().Find(d => d.Id == id);
        }
        public bool Add(RentEntity entity)
        {
            try
            {
                _dataContext.RentList.Add(entity);
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
                RentEntity entity = _dataContext.RentList.ToList().Find(d => d.Id == id);

                _dataContext.RentList.Remove(entity);
                _dataContext.SaveChanges();
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
                int index = _dataContext.RentList.ToList().FindIndex(d => d.Id == entity.Id);
                if (index <0)
                    return false;

                if (_dataContext.RentList.ToList()[index].RentCode > 0)
                    _dataContext.RentList.ToList()[index].RentCode = entity.RentCode;


                if (_dataContext.RentList.ToList()[index].TotalPrice > 0)
                    _dataContext.RentList.ToList()[index].TotalPrice = entity.TotalPrice;

                if (_dataContext.RentList.ToList()[index].Name != "")
                    _dataContext.RentList.ToList()[index].Name = entity.Name;

                if (_dataContext.RentList.ToList()[index].Payment != entity.Payment)
                    _dataContext.RentList.ToList()[index].Payment = entity.Payment;

                if (_dataContext.RentList.ToList()[index].ReturnDate!=new DateTime())
                    _dataContext.RentList.ToList()[index].ReturnDate = entity.ReturnDate;

                if (_dataContext.RentList.ToList()[index].CollectionDate != new DateTime())
                    _dataContext.RentList.ToList()[index].CollectionDate = entity.CollectionDate;

                if (_dataContext.RentList.ToList()[index].TotalPrice >-1)
                    _dataContext.RentList.ToList()[index].TotalPrice = entity.TotalPrice;

                if (_dataContext.RentList.ToList()[index].CreateDate != new DateTime())
                    _dataContext.RentList.ToList()[index].CreateDate = entity.CreateDate;



                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }

        }
       
        public int GetIndex(int id)
        {
            return _dataContext.RentList.ToList().FindIndex(a => a.Id == id);
        }

    }
}
