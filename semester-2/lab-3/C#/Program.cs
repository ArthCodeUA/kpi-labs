using System;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            BoolArray boolArray = new BoolArray(10);
            try
            {
                Console.WriteLine(boolArray[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}