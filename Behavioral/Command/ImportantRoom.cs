using System;

namespace Command
{
    internal class ImportantRoom
    {
        private readonly TicketBarrier barrier;

        public ImportantRoom()
        {
            barrier = new TicketBarrier();
        }

        public TicketBarrier Barrier
        {
            get { return barrier; }
        }
    }
}
