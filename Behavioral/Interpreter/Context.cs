using System;

namespace Interpreter
{
    internal class Context
    {
        public Context(string content)
        {
            Content = content;
        }

        public string Content { get; set; }
    }
}