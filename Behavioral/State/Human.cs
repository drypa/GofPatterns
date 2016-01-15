using System;

namespace State
{
    internal class Human
    {
        private IHumanState state = new HealthyState();

        public void GetIll()
        {
            state = new IllState();
        }

        public void GetWell()
        {
            state = new HealthyState();
        }

        public void Salute()
        {
            state.SayHello();
        }
    }
}