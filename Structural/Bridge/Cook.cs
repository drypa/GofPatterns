using System;

namespace Bridge
{
    public abstract class Cook
    {
        protected Cook(ICooker cooker)
        {
            Implementor = cooker;
        }
        protected ICooker Implementor { get; set; }
        public abstract Pie CreatePie();
    }
}
