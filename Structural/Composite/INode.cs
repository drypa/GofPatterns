using System;

namespace Composite
{
    internal interface INode<T>
    {
        T Content { get; set; }
        void Process(Action<T> action);
    }
}
