using System;

namespace TemplateMethod
{
    public abstract class FileUpdater
    {
        public void Update(string filePath)
        {
            var content = ReadFile(filePath);
            var updatedContent = Convert(content);
            WriteFile(filePath, updatedContent);
        }

        protected abstract string ReadFile(string filePath);
        protected abstract string Convert(string fileContent);
        protected abstract void WriteFile(string filePath, string fileContent);
    }
}
