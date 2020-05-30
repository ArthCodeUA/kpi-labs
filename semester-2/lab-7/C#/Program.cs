using System;

namespace lab_7
{
    static class Program
    {
        static void Main(string[] args)
        {
            ShortList shortList = new ShortList();
            shortList.Add(1);
            shortList.Add(5);
            shortList.Add(2);
            shortList.Add(6);
            shortList.Add(3);
            shortList.Add(7);
            shortList.Display();;
            Console.WriteLine(shortList.MultiplesOfThree());
            shortList.RemoveAboveAverage();
            shortList.Display();
            shortList.Remove(2);
            shortList.Display();
        }
    }
}