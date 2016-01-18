using System;

namespace Bridge
{
    public class Oven : ICooker
    {
        public void Cook(Pie pie)
        {
            pie.State = "Baked";
        }
    }
}