using RentDress.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDress.Core.IService
{
    public interface IRentService
    {
        List<RentEntity> GetRentList();
        RentEntity GetById(int id);
        bool Add(RentEntity rent);
        bool Update(RentEntity rent);
        bool Delete(int id);
    }
}
