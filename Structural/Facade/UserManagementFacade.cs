using System;

namespace Facade
{
    internal class UserManagementFacade
    {
        private readonly UserRepository userRepository = new UserRepository();
        private readonly UserRightsManager userRightsManager = new UserRightsManager();
        public void AddUser(string name, bool readPermission, bool writePermission)
        {
            userRepository.AddUser(name);
            if (readPermission)
            {
                userRightsManager.AddReadPermission(name);
            }
            if (writePermission)
            {
                userRightsManager.AddWritePermission(name);
            }
        }

        public void ShowUsers()
        {
            userRepository.ShowUsers();
        }

        public void DeleteUser(string name)
        {
            userRepository.DeleteUser(name);
        }
        public void ChangeUser(string oldName, string newName, bool readPermission, bool writePermission)
        {
            userRepository.ChangeUser(oldName, newName);
            if (readPermission)
            {
                userRightsManager.AddReadPermission(newName);
            }
            if (writePermission)
            {
                userRightsManager.AddWritePermission(newName);
            }
        }

    }
}