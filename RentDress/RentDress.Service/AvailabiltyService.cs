using RentDress.Core.Entities;
using RentDress.Core.IRepository;
using RentDress.Core.IService;
using RentDress.Data;

namespace RentDress.Service
{
    public class AvailabilityService : IAvailabilityService
    {
        readonly IRepository<AvailabilityEntity> _AvailabilityRepository;

        public AvailabilityService(IRepository<AvailabilityEntity> availabilityRepository)
        {
            _AvailabilityRepository = availabilityRepository;
        }

        public List<AvailabilityEntity> GetAvailabilityList()
        {
            if(_AvailabilityRepository.GetAllData()==null)
                return new List<AvailabilityEntity>();
            return _AvailabilityRepository.GetAllData();
        }
      

        public AvailabilityEntity GetById(int id)
        {
            return _AvailabilityRepository.GetDataById(id);
        }

        public bool Add(AvailabilityEntity Availability)
        {
            if (_AvailabilityRepository.GetIndex(Availability.Id)== -1&&_AvailabilityRepository.Add(Availability))
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            if (id > -1&&_AvailabilityRepository.Delete(id))
                return true;
            return false;
        }

        public bool Update(AvailabilityEntity Availability)
        {
            if (_AvailabilityRepository.GetIndex(Availability.Id) >-1&&_AvailabilityRepository.Update(Availability))
                return true;
            return false;
        }

    }
}