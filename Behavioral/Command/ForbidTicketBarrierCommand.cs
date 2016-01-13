using System;

namespace Command
{
    internal class ForbidTicketBarrierCommand : TicketBarrierCommand
    {
        public ForbidTicketBarrierCommand(TicketBarrier barrier)
        {
            Barrier = barrier;
        }

        public override void Execute()
        {
            Barrier.TurnBack();
        }
    }
}
