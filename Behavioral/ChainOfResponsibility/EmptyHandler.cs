using System;

namespace ChainOfResponsibility
{
    internal class EmptyHandler : IHandler
    {
        private readonly IHandler next;

        public EmptyHandler(IHandler next = null)
        {
            this.next = next;
        }

        private bool СanHandle(string message)
        {
            return string.IsNullOrEmpty(message);
        }

        public void Handle(ref string message)
        {
            if (СanHandle(message))
            {
                message = "it was empty string";
                return;
            }
            next?.Handle(ref message);
        }
    }
}