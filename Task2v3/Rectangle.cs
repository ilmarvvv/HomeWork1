using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2v3
{
    internal class Rectangle
    {
        private double side1, side2;

        // Property for Area
        public double Area
        {
            get { return AreaCalculator(); }
        }

        // Property for Perimeter
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

        // Constructor to initialize sides
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            Show();
        }

        // Method to calculate area
        private double AreaCalculator()
        {
            return side1 * side2;
        }

        // Method to calculate perimeter
        private double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

        // Method to display rectangle details
        public void Show()
        {
            Console.WriteLine($"Side1: {side1}");
            Console.WriteLine($"Side2: {side2}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Perimeter: {Perimeter}");
        }
    }
}
