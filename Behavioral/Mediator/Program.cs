using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarmer alarmer = new Alarmer();
            using (BreakCalculator calculator = new BreakCalculator(60*60))
            {
                BreakMediator mediator = new BreakMediator(alarmer, calculator);
                mediator.Start();
                Console.WriteLine("press <enter> to exit");
                Console.ReadLine();
            }
        }
    }
}
