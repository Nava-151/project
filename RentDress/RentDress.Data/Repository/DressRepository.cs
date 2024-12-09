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
    public class DressRepository : IRepository<DressEntity>
    {
        readonly DataContext _dataContext;

        public DressRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<DressEntity> GetAllData()
        {
            return _dataContext.DressList.ToList();
        }

        public DressEntity? GetDataById(int id)
        {
            return _dataContext.DressList.ToList().Find(d => d.Id == id);
        }
        public bool Add(DressEntity entity)
        {
            try
            {
                _dataContext.DressList.Add(entity);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("catch");
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                DressEntity entity = _dataContext.DressList.ToList().Find(d => d.Id == id);

                _dataContext.DressList.Remove(entity);
                _dataContext.SaveChanges();
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
                int i = _dataContext.DressList.ToList().FindIndex(d => d.Id == entity.Id);
                if (i < 0)
                    return false;
                if (_dataContext.DressList.ToList()[i].Size > -1)
                    _dataContext.DressList.ToList()[i].Size = entity.Size;

                if (_dataContext.DressList.ToList()[i].Seazons != entity.Seazons)
                    _dataContext.DressList.ToList()[i].Seazons = entity.Seazons;

                if (_dataContext.DressList.ToList()[i].Color != "")
                    _dataContext.DressList.ToList()[i].Color = entity.Color;

                if (_dataContext.DressList.ToList()[i].Amount > -1)
                    _dataContext.DressList.ToList()[i].Amount = entity.Amount;

                if (_dataContext.DressList.ToList()[i].FabricType != "")
                    _dataContext.DressList.ToList()[i].FabricType = entity.FabricType;

                if (_dataContext.DressList.ToList()[i].YearOfManufacture != entity.YearOfManufacture
                    && _dataContext.DressList.ToList()[i].YearOfManufacture != new DateTime())
                    _dataContext.DressList.ToList()[i].YearOfManufacture = entity.YearOfManufacture;

                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }

        }
        
        public int GetIndex(int id)
        {
            return _dataContext.DressList.ToList().FindIndex(a => a.Id == id);
        }

    }
}
