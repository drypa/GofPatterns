using System;
using System.Collections.Generic;

namespace Facade
{
    internal class UserRepository
    {
        private readonly List<string> users = new List<string>();

        public void AddUser(string name)
        {
            users.Add(name);
        }

        public void ChangeUser(string oldName, string newName)
        {
            users.Remove(oldName);
            users.Add(newName);
        }

        public void DeleteUser(string name)
        {
            users.Remove(name);
        }

        public void ShowUsers()
        {
            foreach (string user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}