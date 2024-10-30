namespace rentDresses.services
{
    public class UserService
    {
        public List<User> UserList { get; set; }
        public UserService()
        {
            UserList = new List<User>();
        }
        public List<User> GetList()
        {
            return UserList;
        }
        public bool PostUser(User User)
        {
            UserList.Add(User);
            return true;
        }
        public bool DeleteUser(int id)
        {
            User u = UserList.Find(l => l.Code == id);
            if (u != null)
            {
                UserList.Remove(u);
                return true;
            }
            return false;
        }
        public bool PutUser(int id, User User)
        {
            User d = UserList.Find(d => d.Code == id);
            if (d != null)
            {
                UserList.Remove(d);
                UserList.Add(User);
            }
            return false;
        }
        public User GetUserById(int id)
        {
            return UserList.Find(d => d.Code == id);
        }
    }

}

