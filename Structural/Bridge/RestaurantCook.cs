using System;

namespace Bridge
{
    public class RestaurantCook : Cook
    {
        public RestaurantCook(ICooker cooker) : base(cooker)
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