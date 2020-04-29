using System;

namespace lab_6
{
    public class Expression
    {
        private double a;
        private double c;
        private double d;

        public Expression(double a, double c, double d)
        {
            this.a = a;
            this.c = c;
            this.d = d;
        }

        public double Solve()
        {
            double denominator = a * a - 1;
            double logres = d / 4;
            if (Math.Abs(denominator) < Double.Epsilon)
            {
                throw new DivideByZeroException("Division by zero is prohibited");
            }

            if (logres <= 0)
            {
                throw new ArithmeticException("Logarithm expression must be more than 0");
            }

            return (2 * c - Math.Log(logres)) / denominator;
        }
    }
}