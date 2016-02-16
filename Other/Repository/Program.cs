using System;
using System.Collections.Generic;

namespace Repository
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IUserRepository users = new UserRepository();
            users.Save(new User { Id = 0, Name = "first" });
            users.Save(new User { Id = 1, Name = "second" });
            User secondUser = users.Find(1);
            Console.WriteLine(secondUser.Name);
            List<User> allUsers = users.GetAll();
            foreach (User user in allUsers)
            {
                Console.WriteLine(user.Name);
            }
            Console.ReadLine();
        }
    }
}
