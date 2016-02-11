using System;
using System.Collections.Generic;

namespace Observer
{
    internal class Observable : IObservable
    {
        private readonly List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Handle();
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}