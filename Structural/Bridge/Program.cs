using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook firstCook = new RestaurantCook(new Oven());
            var pie = firstCook.CreatePie();
            Console.WriteLine(pie.State);


            Cook secondCook = new HomeCook(new Stove());
            pie = secondCook.CreatePie();
            Console.WriteLine(pie.State);

            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }
    }
}
