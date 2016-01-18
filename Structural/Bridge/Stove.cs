using System;

namespace Bridge
{
    public class Stove : ICooker
    {
        public void Cook(Pie pie)
        {
            pie.State = "fried";
        }
    }
}