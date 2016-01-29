namespace Iterator
{
    internal interface IIterator<out T>
    {
        bool IsDone { get; }
        T Current { get; }
        void Next();
    }
}