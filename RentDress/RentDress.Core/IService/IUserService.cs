using RentDress.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDress.Core.IService
{
    public interface IUserService
    {
        List<UserEntity> GetUserList();
        UserEntity GetById(int id);
        bool Add(UserEntity User);
        bool Update(UserEntity user);
        bool Delete(int id);
    }
}
