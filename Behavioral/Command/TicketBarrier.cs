using System;

namespace Command
{
    internal class TicketBarrier
    {
        public void LetIn()
        {
            Console.Write("Green light:\t");
            Console.WriteLine("You can scroll ticket barrier forward!");
        }

        public void TurnBack()
        {
            Console.Write("Red light:\t");
            Console.WriteLine("Ticket barrier is blocked!");
        }
    }
}
