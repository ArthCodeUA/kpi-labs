using System;

namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(-1, 4, -1, 2, -7, 3);
            triangle.TriangleData();
            Console.WriteLine("Area is " + triangle.TriangleArea());
            Console.WriteLine("Perimeter is " + triangle.TrianglePerimeter());
        }
    }
}