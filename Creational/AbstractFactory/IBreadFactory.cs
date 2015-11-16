namespace AbstractFactory
{
    public interface IBreadFactory
    {
        WhiteBread CreateWhiteBread();
        BlackBread CreateBlackBread();
    }

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

    public class FazerFactory : IBreadFactory
    {
        public WhiteBread CreateWhiteBread()
        {
            return new WhiteUkrainianBread();
        }

        public BlackBread CreateBlackBread()
        {
            return new BlackСapitalBread();
        }
    }
}
