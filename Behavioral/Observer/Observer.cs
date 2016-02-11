using System;

namespace Observer
{
    internal class Observer : IObserver
    {
        private readonly string text;

        public Observer(string text)
        {
            this.text = text;
        }

        public void Handle()
        {
            Console.WriteLine(text);
        }
    }
}
