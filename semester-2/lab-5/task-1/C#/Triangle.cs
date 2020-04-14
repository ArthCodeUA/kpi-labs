using System;

namespace lab_5
{
    public class Triangle : Shape
    {

        public Triangle(params int[] coords) : base(coords)
        {
            if (coords.Length != 6)
            {
                throw new Exception("Triangle must have 3 and only 3 points.");
            }
        }

        public void TriangleData()
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Console.WriteLine("Point #" + i);
                Console.WriteLine("X: " + Points[i].X + " Y: " + Points[i].Y);
            }
        }
        
        public float TrianglePerimeter()
        {
            float perimeter = 0;
            for (int i = 0; i < Points.Length; i++)
            {
                perimeter += SideLength(i);
            }

            return perimeter;
        }
        
        public float TriangleArea()
        {
            float s = TrianglePerimeter() / 2;
            float a = SideLength(0);
            float b = SideLength(1);
            float c = SideLength(2);
            return (float) Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        
    }
} 