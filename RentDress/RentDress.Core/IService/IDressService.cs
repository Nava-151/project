using RentDress.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDress.Core.IService
{
    public interface IDressService
    {
        List<DressEntity> GetDressList();
        DressEntity GetById(int id);
        bool Add(DressEntity dress);
        bool Update(DressEntity dress);
        bool Delete(int id);

    }
}
