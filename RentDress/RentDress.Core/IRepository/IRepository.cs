using RentDress.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDress.Core.IRepository
{
    public interface IRepository<T>
    {
         List<T> GetAllData();
         T GetDataById(int id);
        int GetIndex(int id);
         bool Add(T entity);
         bool Update(T entity);
         bool Delete(int id);

    }
}
