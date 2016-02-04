using System;

namespace ChainOfResponsibility
{
    internal class VeryLargeHandler : IHandler
    {
        private readonly IHandler next;

        public VeryLargeHandler(IHandler next = null)
        {
            this.next = next;
        }

        private bool СanHandle(string message)
        {
            return message.Length > 100;
        }

        public void Handle(ref string message)
        {
            if (СanHandle(message))
            {
                message = message.Substring(0, 10);
                return;
            }
            next?.Handle(ref message);
        }
    }
}