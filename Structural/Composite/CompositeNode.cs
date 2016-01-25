using System;
using System.Collections.Generic;

namespace Composite
{
    internal class CompositeNode<T> : INode<T>
    {
        internal CompositeNode(T val, IEnumerable<INode<T>> children)
        {
            Content = val;
            Children = new List<INode<T>>(children);
        }

        public T Content { get; set; }
        private List<INode<T>> Children { get; set; }

        public void Process(Action<T> action)
        {
            action(Content);
            foreach (Node<T> node in Children)
            {
                node.Process(action);
            }
        }
    }
}
