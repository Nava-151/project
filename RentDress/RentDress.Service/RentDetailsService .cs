using RentDress.Core.Entities;
using RentDress.Core.IRepository;
using RentDress.Core.IService;

namespace RentDress.Service
{
    public class RentDetailsService : IRentDetailsService
    {
        readonly IRepository<RentDetailsEntity> _RentDetailsRepository;
    


        public RentDetailsService(IRepository<RentDetailsEntity> RentDetailsRepository)
        {
            _RentDetailsRepository = RentDetailsRepository;
        }
        public List<RentDetailsEntity> GetRentDetailsList()
        {
            return _RentDetailsRepository.GetAllData();
        }

       
        public RentDetailsEntity GetById(int id)
        {
            return _RentDetailsRepository.GetDataById(id);
        }

        public bool Add(RentDetailsEntity RentDetails)
        {
            if (_RentDetailsRepository.GetIndex(RentDetails.Id) == -1 && _RentDetailsRepository.Add(RentDetails))
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            if (_RentDetailsRepository.GetIndex(id)>-1&&_RentDetailsRepository.Delete(id))
                return true;
            return false;
        }

        public bool Update(RentDetailsEntity RentDetails)
        {
            if (_RentDetailsRepository.GetIndex(RentDetails.Id) > -1 && _RentDetailsRepository.Update(RentDetails))
                return true;
            return false;
        }

       
    }
}