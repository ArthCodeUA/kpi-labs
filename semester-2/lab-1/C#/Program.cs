using System;
using static lab_1.Functions;

namespace lab_1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Testing Increment Function
            Increment(-43, out int r);
            Console.WriteLine(r);
            Increment(75, out r);
            Console.WriteLine(r);
            Increment(63, out r);
            Console.WriteLine(r);

            Console.WriteLine();
            
            // Testing Equality Function
            Console.WriteLine(Equality(48, 48));
            Console.WriteLine(Equality(69, 78));
            Console.WriteLine(Equality(24, 25));
        }
    }
}
