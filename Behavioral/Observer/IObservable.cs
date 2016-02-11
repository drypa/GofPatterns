using System;

namespace Observer
{
    internal interface IObservable
    {
        void AddObserver(IObserver observer);
        void NotifyAllObservers();
        void RemoveObserver(IObserver observer);
    }
}