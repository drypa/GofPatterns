using System;

namespace Interpreter
{
    internal class ReplaceExpression : IExpression
    {
        private readonly string replacement;
        private readonly string whatToReplace;

        public ReplaceExpression(string whatToReplace, string replacement)
        {
            this.whatToReplace = whatToReplace;
            this.replacement = replacement;
        }

        public void Interpret(Context context)
        {
            context.Content = context.Content.Replace(whatToReplace, replacement);
        }
    }
}