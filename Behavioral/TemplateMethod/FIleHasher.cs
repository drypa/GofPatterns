using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TemplateMethod
{
    public class FileHasher : FileUpdater
    {
        protected sealed override string ReadFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        protected sealed override string Convert(string fileContent)
        {
            MD5 md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(fileContent));
            return Encoding.UTF8.GetString(hash);
        }

        protected sealed override void WriteFile(string filePath, string fileContent)
        {
            File.WriteAllText(filePath, fileContent);
        }
    }
}