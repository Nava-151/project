using RentDress.Core.Entities;
using RentDress.Core.IRepository;
using RentDress.Core.IService;

namespace RentDress.Service
{
    public class RentDetailsService : IRentDetailsService
    {
        readonly IRepository<RentDetailsEntity> _RentDetailsRepository;
        //check
        public RentDetailsService()
        {

        }

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
            if (_RentDetailsRepository.Add(RentDetails))
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            if (_RentDetailsRepository.Delete(id))
                return true;
            return false;
        }

        public bool Update(RentDetailsEntity RentDetails)
        {
            if (_RentDetailsRepository.Update(RentDetails))
                return true;
            return false;
        }

       
    }
}