using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarmer alarmer = new Alarmer();
            using (BreakCalculator calculator = new BreakCalculator(5))
            {
                BreakMediator mediator = new BreakMediator(alarmer, calculator);
                Console.WriteLine("press <enter> to exit");
                Console.ReadLine();
            }
        }
    }
}
