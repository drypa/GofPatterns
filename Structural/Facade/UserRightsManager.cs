using System;
using System.Collections.Generic;

namespace Facade
{
    internal class UserRightsManager
    {
        private readonly List<string> usersWithReadPermission = new List<string>();
        private readonly List<string> usersWithWritePermission = new List<string>();

        public void AddReadPermission(string userName)
        {
            usersWithWritePermission.Add(userName);
        }

        public void AddWritePermission(string userName)
        {
            usersWithReadPermission.Add(userName);
        }
    }
}