using System;

namespace Bridge
{
    public class HomeCook : Cook
    {
        public HomeCook(ICooker cooker) : base(cooker)
        {
        }

        public override Pie CreatePie()
        {
            var pie = new Pie();
            Implementor.Cook(pie);
            return pie;
        }
    }
}