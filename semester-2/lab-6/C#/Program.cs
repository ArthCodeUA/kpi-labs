using System;

namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression[] expressions = {
                new Expression(1, 2, 0),
                new Expression(5, 2, 0),
                new Expression(512, 231, 12)
            };
            SolveExpressions(expressions);
        }

        private static void SolveExpressions(Expression[] expressions)
        {
            foreach (var expression in expressions)
            {
                try
                {
                    double result = expression.Solve();
                    Console.WriteLine(result);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine(e.Message);   
                }
            }
        }
    }
}