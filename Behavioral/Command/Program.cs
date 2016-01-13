using System;

namespace Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var room = new ImportantRoom();
            var accessChecker = new AccessChecker(new AllowTicketBarrierCommand(room.Barrier), new ForbidTicketBarrierCommand(room.Barrier));

            for (int userIdCard = 0; userIdCard < 10; userIdCard++)
            {
                accessChecker.TryEnter(userIdCard);
            }

            Console.ReadLine();
        }
    }
}
