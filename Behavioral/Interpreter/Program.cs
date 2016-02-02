using System;
using System.Collections.Generic;

namespace Interpreter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var context = new Context("[{0},{1}] ");
            List<IExpression> expressionList = new List<IExpression>
            {
                new AddExpression("some text"),
                new AddExpression(" {0}"),
                new ReplaceExpression("{0}", "value0"),
                new AddExpression(" another text"),
                new AddExpression(" {1}"),
                new ReplaceExpression("{1}", "value1")
            };
            foreach (IExpression expr in expressionList)
            {
                expr.Interpret(context);
            }
            Console.WriteLine(context.Content);

            Console.WriteLine("press <enter> to exit");
            Console.ReadLine();
        }
    }
}
