using System;

namespace Composite
{
    internal static class NodesFactory<T>
    {
        public static INode<T> Create(T val)
        {
            return new Node<T>(val);
        }

        public static INode<T> Create(T val, params INode<T>[] children)
        {
            if (children.Length == 0)
            {
                return Create(val);
            }
            return new CompositeNode<T>(val, children);
        }
    }
}
