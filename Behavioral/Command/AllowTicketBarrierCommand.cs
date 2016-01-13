using System;

namespace Command
{
    internal class AllowTicketBarrierCommand : TicketBarrierCommand
    {
        public AllowTicketBarrierCommand(TicketBarrier barrier)
        {
            Barrier = barrier;
        }

        public override void Execute()
        {
            Barrier.LetIn();
        }
    }
}
