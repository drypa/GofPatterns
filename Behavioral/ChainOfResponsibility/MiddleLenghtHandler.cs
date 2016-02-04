using System;

namespace ChainOfResponsibility
{
    internal class MiddleLenghtHandler : IHandler
    {
        private readonly IHandler next;

        public MiddleLenghtHandler(IHandler next = null)
        {
            this.next = next;
        }

        private bool СanHandle(string message)
        {
            return message.Length <= 100 && message.Length > 0;
        }

        public void Handle(ref string message)
        {
            if (СanHandle(message))
            {
                message = new string('+', message.Length);
                return;
            }
            next?.Handle(ref message);
        }
    }
}