using System;

namespace lab_1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Testing Increment Function
            Console.WriteLine(Increment(-43));
            Console.WriteLine(Increment(75));
            Console.WriteLine(Increment(63));
            
            Console.WriteLine();
            
            // Testing Equality Function
            Console.WriteLine(Equality(48, 48));
            Console.WriteLine(Equality(69, 78));
            Console.WriteLine(Equality(24, 25));
        }

        private static int Increment(int a)
        {
            return -~a;
        }

        private static bool Equality(int a, int b)
        {
            return !((a ^ b) != 0);
        }
    }
}
