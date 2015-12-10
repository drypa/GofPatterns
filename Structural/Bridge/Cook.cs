using System;
using System.Configuration;

namespace Bridge
{
    public class Cook
    {
        public ICooker Implementor { get; set; }

        public Pie CreatePie()
        {
            if (Implementor == null)
            {
                throw new ConfigurationErrorsException("Cooker is not defined");
            }
            var pie = new Pie();
            Implementor.Cook(pie);
            return pie;
        }
    }
}
