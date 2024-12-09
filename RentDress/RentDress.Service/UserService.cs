using RentDress.Core.Entities;
using RentDress.Core.IService;
using RentDress.Core.Entities;
using RentDress.Core.IRepository;

namespace RentDress.Service
{
    public class UserService : IUserService
    {
        readonly IRepository<UserEntity> _UserRepository;

       

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
          if(_UserRepository.GetIndex(User.Id) == -1 && IsValidIsraelId(User.Tz)&&IsValidEmail(User.Email)&&_UserRepository.Add(User))   
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            if (_UserRepository.GetIndex(id) > -1&& _UserRepository.Delete(id))
                return true;
            return false;
        }

        public bool Update(UserEntity User)
        {
            if (_UserRepository.GetIndex(User.Id) > -1 &&IsValidIsraelId(User.Tz) && IsValidEmail(User.Email) && _UserRepository.Update(User))
                return true;
            return false;
        }
        public bool IsValidIsraelId(string id)
        {
            id = id.Trim();
            if (id.Length > 9 || !int.TryParse(id, out _))
                return false;
            id = id.Length < 9 ? ("00000000" + id).Substring(id.Length) : id;
            return id.Select(c => int.Parse(c.ToString()))
                     .Select((digit, i) => digit * (i % 2 + 1))
                     .Sum(step => step > 9 ? step - 9 : step) % 10 == 0;
        }
        public bool IsValidEmail(string email)
        {
            int i = email.LastIndexOf('@');
            int j = email.LastIndexOf('.');
            return i != -1 && j != -1 && i < j;
        }


    }
}
