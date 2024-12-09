using RentDress.Core.Entities;
using RentDress.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDress.Data.Repository
{
    public class UserRepository : IRepository<UserEntity>
    {
        readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<UserEntity> GetAllData()
        {
            return _dataContext.UserList.ToList();
        }

        public UserEntity? GetDataById(int id)
        {
            return _dataContext.UserList.ToList().Find(d => d.Id == id);
        }
        public bool Add(UserEntity entity)
        {
            try
            {
                _dataContext.UserList.Add(entity);
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
                UserEntity entity = _dataContext.UserList.ToList().Find(d => d.Id == id);

                _dataContext.UserList.Remove(entity);
                _dataContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public bool Update(UserEntity entity)
        {
            try
            {
                int index = _dataContext.UserList.ToList().FindIndex(d => d.Id == entity.Id);
                if (index <0)
                    return false;
                if (_dataContext.UserList.ToList()[index].Tz!="")
                    _dataContext.UserList.ToList()[index].Tz = entity.Tz;

                if (_dataContext.UserList.ToList()[index].TellNum != "")
                    _dataContext.UserList.ToList()[index].TellNum = entity.TellNum;

                if (_dataContext.UserList.ToList()[index].Name != "")
                    _dataContext.UserList.ToList()[index].Name = entity.Name;

                if (_dataContext.UserList.ToList()[index].Email != "")
                    _dataContext.UserList.ToList()[index].Email = entity.Email;

                if (_dataContext.UserList.ToList()[index].Addres != "")
                    _dataContext.UserList.ToList()[index].Addres = entity.Addres;

                if (_dataContext.UserList.ToList()[index].ZipCode >0)
                    _dataContext.UserList.ToList()[index].ZipCode = entity.ZipCode;

                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }

        }
        
        public int GetIndex(int id)
        {
            return _dataContext.UserList.ToList().FindIndex(a => a.Id == id);
        }

    }
}
