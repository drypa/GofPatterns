using System;

namespace Interpreter
{
    internal interface IExpression
    {
        void Interpret(Context context);
    }
}