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
            return _dataContext.UserList;
        }

        public UserEntity? GetDataById(int id)
        {
            return _dataContext.UserList.Find(d => d.Id == id);
        }
        public bool Add(UserEntity entity)
        {
            try
            {
                _dataContext.UserList.Add(entity);
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
                UserEntity entity = _dataContext.UserList.Find(d => d.Id == id);

                _dataContext.UserList.Remove(entity);
                _dataContext.SaveData();
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
                UserEntity user = _dataContext.UserList.Find(d => d.Id == entity.Id);
                if (user == null)
                    return false;
                _dataContext.UserList.Remove(user);
                _dataContext.UserList.Add(entity);
                _dataContext.SaveData();
                return true;
            }
            catch (Exception ex) { return false; }

        }

    }
}
