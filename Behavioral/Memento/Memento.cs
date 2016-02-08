using System.Collections.Generic;

namespace Memento
{
    internal class Memento
    {
        public Memento(IEnumerable<string> state)
        {
            StateContent = new List<string>(state);
        }

        public List<string> StateContent { get;}
    }
}