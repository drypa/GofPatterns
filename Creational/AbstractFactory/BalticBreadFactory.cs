using System;

namespace AbstractFactory
{
    public class BalticBreadFactory : IBreadFactory
    {
        public WhiteBread CreateWhiteBread()
        {
            return new WhiteRifledBread();
        }

        public BlackBread CreateBlackBread()
        {
            return new BlackRyeBread();
        }
    }
}