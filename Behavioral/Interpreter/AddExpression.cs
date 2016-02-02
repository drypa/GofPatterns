using System;

namespace Interpreter
{
    internal class AddExpression : IExpression
    {
        private readonly string addition;

        public AddExpression(string addition)
        {
            this.addition = addition;
        }

        public void Interpret(Context context)
        {
            context.Content += addition;
        }
    }
}