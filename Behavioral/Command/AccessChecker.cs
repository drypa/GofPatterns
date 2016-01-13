using System;

namespace Command
{
    internal class AccessChecker
    {
        private readonly TicketBarrierCommand AllowCommand;
        private readonly TicketBarrierCommand DenyCommand;

        public AccessChecker(TicketBarrierCommand allow, TicketBarrierCommand deny)
        {
            AllowCommand = allow;
            DenyCommand = deny;
        }

        public void TryEnter(int userIdCard)
        {
            if (userIdCard % 2 == 0) //access allowed
            {
                AllowCommand.Execute();
            }
            else
            {
                DenyCommand.Execute();
            }
        }
    }
}
