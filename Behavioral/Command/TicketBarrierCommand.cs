using System;

namespace Command
{
    internal abstract class TicketBarrierCommand
    {
        protected TicketBarrier Barrier { get; set; }
        public abstract void Execute();
    }
}
