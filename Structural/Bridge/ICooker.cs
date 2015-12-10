using System;

namespace Bridge
{
    public interface ICooker
    {
        void Cook(Pie pie);
    }

    public class Stove : ICooker
    {
        public void Cook(Pie pie)
        {
            pie.State = "fried";
        }
    }
    public class Oven : ICooker
    {
        public void Cook(Pie pie)
        {
            pie.State = "Baked";
        }
    }
}
