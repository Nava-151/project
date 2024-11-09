using Microsoft.AspNetCore.Mvc;
using rentDresses.Entities;
using System;

namespace rentDresses.services
{
    public class UserService
    {

        public List<User> GetList()
        {
            if (DataContextManager.DataContext.UserList == null)
                DataContextManager.DataContext.UserList = new List<User>();
            return DataContextManager.DataContext.UserList;
        }
        public User GetUserById(int id)
        {
            return DataContextManager.DataContext.UserList.Find(d => d.Id == id);
        }


        public bool Add(User User)
        {
            if (!IsValidIdNumber(User.Tz))
                return false;
            DataContextManager.DataContext.UserList.Add(User);
            return true;
        }

        public bool DeleteUser(int id)
        {
            User u = DataContextManager.DataContext.UserList.Find(l => l.Id == id);
            if (u != null)
            {
                DataContextManager.DataContext.UserList.Remove(u);
                return true;
            }
            return false;
        }

        public bool Update(int id, User User)
        {

            User d = DataContextManager.DataContext.UserList.Find(d => d.Id == id);
            if (d != null)
            {
                DataContextManager.DataContext.UserList.Remove(d);
                DataContextManager.DataContext.UserList.Add(User);
            }
            return false;
        }
        public bool IsValidIdNumber(string idNumber)
        {
            if (idNumber.Length != 9 || !IsAllDigits(idNumber))
            {
                return false;
            }

            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int digit = int.Parse(idNumber[i].ToString());
                if (i % 2 == 0)
                {
                    sum += digit;
                }
                else
                {
                    sum += digit < 5 ? digit * 2 : digit * 2 - 9;
                }
            }

            return sum % 10 == 0;
        }

        public bool IsAllDigits(string input)
        {
            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }

  
}

