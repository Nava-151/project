using RentDress.Core.Entities;
using RentDress.Core.IRepository;
using RentDress.Core.IService;

namespace RentDress.Service
{
    public class AvailabilityService : IAvailabilityService
    {
        readonly IRepository<AvailabilityEntity> _AvailabilityRepository;
        //check
        public AvailabilityService()
        {
        }
        public List<AvailabilityEntity> GetAvailabilityList()
        {
            return _AvailabilityRepository.GetAllData();
        }


        public AvailabilityEntity GetById(int id)
        {
            return _AvailabilityRepository.GetDataById(id);
        }

        public bool Add(AvailabilityEntity Availability)
        {
            if (_AvailabilityRepository.Add(Availability))
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            if (_AvailabilityRepository.Delete(id))
                return true;
            return false;
        }

        public bool Update(AvailabilityEntity Availability)
        {
            if (_AvailabilityRepository.Update(Availability))
                return true;
            return false;
        }

    }
}