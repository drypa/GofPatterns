using System;

namespace Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IObservable observable = new Observable();
            observable.AddObserver(new Observer("Something happend"));
            var observer = new Observer("Wow!!!");
            observable.AddObserver(observer);

            observable.NotifyAllObservers();

            observable.AddObserver(new Observer("Great"));
            observable.NotifyAllObservers();

            observable.RemoveObserver(observer);
            observable.NotifyAllObservers();

            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }
    }
}
