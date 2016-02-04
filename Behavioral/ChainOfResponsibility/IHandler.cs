using System;

namespace ChainOfResponsibility
{
    internal interface IHandler
    {
        void Handle(ref string message);
    }
}