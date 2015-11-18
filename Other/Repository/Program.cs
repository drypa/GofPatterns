using System;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserRepository users = new UserRepository();
            users.Save(new User{Id = 0,Name = "first"});
            users.Save(new User{Id = 1,Name = "second"});
            var secondUser = users.Find(1);
            Console.WriteLine(secondUser.Name);
            var allUsers = users.GetAll();
            foreach (User user in allUsers)
            {
                Console.WriteLine(user.Name);
            }
            Console.ReadLine();
        }
    }
}
