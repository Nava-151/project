using RentDress.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDress.Core.IService
{
    public interface IRentDetailsService
    {
        List<RentDetailsEntity> GetRentDetailsList();
        RentDetailsEntity GetById(int id);
        bool Add(RentDetailsEntity rentDetails);
        bool Update(RentDetailsEntity rentDetails);
        bool Delete(int id);
    }
}
