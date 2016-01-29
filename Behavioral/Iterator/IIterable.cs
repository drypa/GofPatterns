namespace Iterator
{
    internal interface IIterable
    {
        IIterator<int> GetIterator();
    }
}