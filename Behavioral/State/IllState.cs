using System;

namespace State
{
    internal class IllState : IHumanState
    {
        public void SayHello()
        {
            Console.WriteLine("Shut Up. I'm ill");
        }
    }
}