using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly string fileExtention = ".xml";
        private readonly string storageFolder = "Storage";

        public UserRepository()
        {
            if (!Directory.Exists(GetStorageFolderFullPath()))
            {
                Directory.CreateDirectory(GetStorageFolderFullPath());
            }
        }

        public User Find(int userId)
        {
            var serializer = new XmlSerializer(typeof(User));
            using (FileStream fileStream = File.OpenRead(GetFilePath(GetFileNameForUserId(userId))))
            {
                return serializer.Deserialize(fileStream) as User;
            }
        }

        public List<User> GetAll()
        {
            var serializer = new XmlSerializer(typeof(User));
            List<User> users = new List<User>();
            IEnumerable<string> files = GetAllFileNames();
            foreach (string file in files)
            {
                using (FileStream fileStream = File.OpenRead(file))
                {
                    users.Add(serializer.Deserialize(fileStream) as User);
                }
            }
            return users;
        }

        public void Save(User user)
        {
            var serializer = new XmlSerializer(typeof(User));
            using (FileStream fileStream = File.Open(GetFilePath(GetFileNameForUserId(user.Id)), FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.Serialize(fileStream, user);
            }
        }

        private IEnumerable<string> GetAllFileNames()
        {
            return Directory.GetFiles(GetStorageFolderFullPath());
        }

        private string GetFileNameForUserId(int userId)
        {
            return userId + fileExtention;
        }

        private string GetFilePath(string fileName)
        {
            return GetStorageFolderFullPath() + fileName;
        }

        private string GetStorageFolderFullPath()
        {
            return Environment.CurrentDirectory + Path.DirectorySeparatorChar + storageFolder + Path.DirectorySeparatorChar;
        }
    }
}
