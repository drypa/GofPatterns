using System;

namespace Composite
{
    internal class Node<T> : INode<T>
    {
        internal Node(T val)
        {
            Content = val;
        }

        public T Content { get; set; }

        public void Process(Action<T> action)
        {
            action(Content);
        }
    }
}
