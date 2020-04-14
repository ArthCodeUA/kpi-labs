using System;

namespace lab_5
{
    public abstract class Shape
    {
        protected Point[] Points;
    
        protected Shape(params int[] coords)
        {
            if (coords.Length % 2 == 0)
            {
                Points = new Point[coords.Length / 2];
                int p = 0;
                for (int i = 0; i < coords.Length; i += 2)
                {
                    Points[p] = new Point(coords[i], coords[i + 1]);
                    p++;
                }
            }
            else
            {
                throw new Exception("Coords amount should be even.");
            }
        }

        protected readonly struct Point
        {
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; }
            public double Y { get; }
        }

        private Point[] this[int index]
        {
            get
            {
                if (index <= Points.Length - 1 && index >= 0)
                {
                    return index != Points.Length - 1
                        ? new Point[] {Points[index], Points[index + 1]}
                        : new Point[] {Points[0], Points[^1]};
                }
                throw new Exception("There are no side #" + index + " in this shape!");
            }
        }

        protected float SideLength(int sideIndex)
        {
            Point[] side = this[sideIndex];
            return (float) Math.Sqrt(Math.Pow(side[0].X - side[1].X, 2) + Math.Pow(side[0].Y - side[1].Y, 2));
        }
    }
}