using System;
using System.Collections.Generic;
using System.Linq;

namespace testelitest
{
    public class Methods
    {
        public bool Login(string username, string password, Account account)
        {
            if (account?.Username == username && account?.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AdminLogin(string username, string password, Admin admin)
        {
            if (username == "admin1" && password == "admin1234")
            {
                return admin.IsAdmin = true;
            }

            return false;
        }

        public int ShowSalary(User user)
        {
            return user.Salary;
        }

        public string ShowCompanyRole(User user)
        {
            return user.CompanyRole;
        }

        public User CreateUserAccount(string username, string password, int salary, string role) //List to add the user to and return the list?
        {
            if (username.Any(char.IsLetter) && username.Any(char.IsDigit))
            {
                if (password.Any(char.IsLetter) && password.Any(char.IsDigit))
                {
                    User user = new User();
                    user.Username = username;
                    user.Password = password;
                    user.Salary = salary;
                    user.CompanyRole = role;

                    return user;
                }
            }

            return null;
            //Add the created user to a a list of users, I need to save them somewhere when i dont use a database
        }

        public User CreateUserAccount(string username, string password)
        {
            if (username.Any(char.IsLetter) && username.Any(char.IsDigit))
            {
                if (password.Any(char.IsLetter) && password.Any(char.IsDigit))
                {
                    User user = new User();
                    user.Username = username;
                    user.Password = password;

                    return user;
                }
            }

            return null;
        }

        public User RemoveYourAccount(string username, string password, User user)
        {
            if (user.Username == username && user.Password == password)
            {
                user = null;
                Console.WriteLine("Your account has been removed.");
                return user;
            }
            else
            {
                Console.WriteLine("Either your username or password is incorrect.");
                return user;
            }
        }

        public void AdminShowUsersInfo(List<User> userList)
        {
            foreach (var user in userList)
            {
                Console.Write($"Username: {user.Username} ");
                Console.WriteLine($"Password: {user.Password}");
            }
        }

        public void AdminCreateUsers(string username, string password)
        {
            CreateUserAccount(username, password);
        }

        public void AdminRemoveUser(string username, string password)
        {
            //RemoveYourAccount()
        }


    }
}