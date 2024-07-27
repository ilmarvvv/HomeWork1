using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4v2
{
    internal class Figure
    {
        private Point[] points;

        private string name;

        public Figure(string name, params Point[] point)
        {
            if (point.Length < 3 || point.Length > 5)
                throw new ArgumentException("A figure must have berween 3 and 5 points.");

            this.name = name;
            this.points = point;
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;

            for(int i = 0; i < points.Length; i++)
            {
                perimeter += LengthSide(points[i], points[(i + 1) % points.Length]);
            }

            Console.WriteLine($"The perimeter of the {name} is {perimeter}");
        }
    }
}
