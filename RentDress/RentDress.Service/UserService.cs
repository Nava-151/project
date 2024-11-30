using RentDress.Core.Entities;
using RentDress.Core.IService;
using RentDress.Core.Entities;
using RentDress.Core.IRepository;

namespace RentDress.Service
{
    public class UserService : IUserService
    {
        readonly IRepository<UserEntity> _UserRepository;
        //check
        public UserService()
        {

        }

        public UserService(IRepository<UserEntity> userRepository)
        {
            _UserRepository = userRepository;
        }

        public List<UserEntity> GetUserList()
        {
            return _UserRepository.GetAllData();
        }


        public UserEntity GetById(int id)
        {
            return _UserRepository.GetDataById(id);
        }

        public bool Add(UserEntity User)
        {
            if (_UserRepository.Add(User))
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            if (_UserRepository.Delete(id))
                return true;
            return false;
        }

        public bool Update(UserEntity User)
        {
            if (_UserRepository.Update(User))
                return true;
            return false;
        }

      
    }
}
