using RentDress.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDress.Core.IService
{
    public interface IAvailabilityService
    {
        List<AvailabilityEntity> GetAvailabilityList();
        AvailabilityEntity GetById(int id);
        bool Add(AvailabilityEntity availability);
        bool Update(AvailabilityEntity availability);
        bool Delete(int id);
    }
}
