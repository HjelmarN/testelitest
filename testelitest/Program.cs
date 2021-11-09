using System.Collections.Generic;
using System;

namespace testelitest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Methods methods = new Methods();

            List<User> userList = new List<User>();
            userList.Add(methods.CreateUserAccount("Elias", "hjelm123", 25000, "CEO"));
            userList.Add(methods.CreateUserAccount("Eli", "hjelm1", 18000, "IT-support"));






            Console.WriteLine(methods.ShowSalary(userList[0]));
            Console.WriteLine(methods.ShowCompanyRole(userList[0]));
            var deletedMe = methods.RemoveYourAccount("Elias", "hjelm123", userList[0]);

            Console.WriteLine(methods.Login("Elias", "hjelm123", deletedMe));

            methods.AdminShowUsersInfo(userList);


        }
    }
}