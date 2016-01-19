using System;

namespace Facade
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            UserManagementFacade facade = new UserManagementFacade();
            facade.AddUser("first", true, true);
            facade.AddUser("second", true, false);
            facade.ShowUsers();
            facade.DeleteUser("first");
            facade.ShowUsers();
            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }
    }
}
