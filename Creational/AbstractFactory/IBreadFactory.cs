namespace AbstractFactory
{
    public interface IBreadFactory
    {
        WhiteBread CreateWhiteBread();
        BlackBread CreateBlackBread();
    }
}
