using RentDress.Core.Entities;
using RentDress.Core.IRepository;
using RentDress.Core.IService;

namespace RentDress.Service
{
    public class RentService : IRentService
    {
        readonly IRepository<RentEntity> _RentRepository;
        


        public RentService(IRepository<RentEntity> rentRepository)
        {
            _RentRepository = rentRepository;
        }

        public List<RentEntity> GetRentList()
        {
            return _RentRepository.GetAllData();
        }


        public RentEntity GetById(int id)
        {
            return _RentRepository.GetDataById(id);
        }

        public bool Add(RentEntity Rent)
        {
            if (_RentRepository.GetIndex(Rent.Id) == -1 && _RentRepository.Add(Rent))
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            if (_RentRepository.GetIndex(id)>-1&&_RentRepository.Delete(id))
                return true;
            return false;
        }

        public bool Update(RentEntity Rent)
        {
            if (_RentRepository.GetIndex(Rent.Id) > -1 && _RentRepository.Update(Rent))
                return true;
            return false;
        }
    }
}