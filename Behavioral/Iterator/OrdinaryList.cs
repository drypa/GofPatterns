namespace Iterator
{
    internal class OrdinaryList : IIterable
    {
        private readonly int[] items;

        public OrdinaryList(int itemsCount)
        {
            items = new int[itemsCount];
            for (int i = 0; i < itemsCount; i++)
            {
                items[i] = itemsCount - i;
            }
        }

        public IIterator<int> GetIterator()
        {
            return new Iterator(this);
        }

        private class Iterator : IIterator<int>
        {
            private readonly OrdinaryList list;
            private int currentPos = 0;

            public Iterator(OrdinaryList list)
            {
                this.list = list;
            }


            public bool IsDone
            {
                get { return currentPos == list.items.Length-1; }
            }
            public int Current
            {
                get { return list.items[currentPos]; }
            }
            public void Next()
            {
                ++currentPos;
            }
        }
    }
}