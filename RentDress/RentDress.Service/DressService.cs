using RentDress.Core.Entities;
using RentDress.Core.IRepository;
using RentDress.Core.IService;

namespace RentDress.Service
{
    public class DressService : IDressService
    {
        readonly IRepository<DressEntity> _dressRepository;

        //check
        public DressService(IRepository<DressEntity> DressRepository)
        {
            _dressRepository = DressRepository;
        }
        public DressService()
        {
            
        }
        public List<DressEntity> GetDressList()
        {
            
            return _dressRepository.GetAllData();
        }

        public DressEntity GetById(int id)
        {
            return _dressRepository.GetDataById(id);
        }

        public bool Add(DressEntity dress)
        {
            if(_dressRepository.GetIndex(dress.Id)==-1&& _dressRepository.Add(dress))
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            if(_dressRepository.GetIndex(id) > -1 && _dressRepository.Delete(id))
                return true;
            return false;
        }

        public bool Update(DressEntity dress)
        {
            if(_dressRepository.GetIndex(dress.Id) > -1 && _dressRepository.Update(dress))
                return true;
            return false;
        }

    }
}