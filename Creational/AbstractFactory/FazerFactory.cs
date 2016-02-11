using System;

namespace AbstractFactory
{
    public class FazerFactory : IBreadFactory
    {
        public BlackBread CreateBlackBread()
        {
            return new BlackСapitalBread();
        }

        public WhiteBread CreateWhiteBread()
        {
            return new WhiteUkrainianBread();
        }
    }
}
