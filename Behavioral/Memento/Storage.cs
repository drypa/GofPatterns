using System;
using System.Collections.Generic;

namespace Memento
{
    /// <summary>
    /// Ordinator.
    /// </summary>
    internal class Storage
    {
        private List<string> State { get; set; } = new List<string>();

        public void AddItemToStorage(string item)
        {
            State.Add(item);
        }

        public void RestoreState(Memento memento)
        {
            State = memento.StateContent;
        }

        public Memento SaveState()
        {
            return new Memento(State);
        }

        public void Show()
        {
            Console.WriteLine(new string('-', 10));
            foreach (string s in State)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(new string('=', 10));
        }
    }
}
