using System;

namespace Iterator
{
    internal class SuperList : IIterable
    {
        public IIterator<int> GetIterator()
        {
            return new Iterator();
        }

        private class Iterator : IIterator<int>
        {
            private readonly Random random = new Random(DateTime.Now.Millisecond);
            private int current;

            public Iterator()
            {
                current = random.Next();
            }

            public void Next()
            {
                current = random.Next();
            }

            public bool IsDone
            {
                get { return false; }
            }

            public int Current
            {
                get { return current; }
            }
        }
    }
}