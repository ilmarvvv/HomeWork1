using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Figure
    {
        //Тут краще робити через массив
        Point a = null;
        Point b = null;
        Point c = null;
        Point d = null;
        Point e = null;

        public Figure(Point A, Point B, Point C) //Додавання елементів до массива
        {
            this.a = A; 
            this.b = B; 
            this.c = C;
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            this.a = A;
            this.b = B;
            this.c = C;
            this.d = D;
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.a = A;
            this.b = B;
            this.c = C;
            this.d = D;
            this.e = E;
        }
        private double LengthSide(Point Point1, Point Point2)
        {
            double LengthSide = Math.Sqrt(Math.Pow(Point2.PointA - Point1.PointA, 2) + Math.Pow(Point2.PointB - Point1.PointB, 2));
            Console.WriteLine($"Відрізок {Point1.Text}{Point2.Text} = {LengthSide}");
            return LengthSide;
        }
        public void PerimeterCalculator() //Якщо у Вас буде массив, обробку данних можно зробити на багато краще і легше. І універсальніше 
        {
            double perimeter = 0;

            if (d == null & d == null) 
            {
                Console.WriteLine("Периметр трикутника:");
                perimeter += LengthSide(a, b);
                perimeter += LengthSide(b, c);
                perimeter += LengthSide(a, c);
            }
            else if(e == null)
            {
                Console.WriteLine("Периметр чотирикутника:");
                perimeter += LengthSide(a, b);
                perimeter += LengthSide(b, c);
                perimeter += LengthSide(c, d);
                perimeter += LengthSide(a, d);
            }
            else
            {
                Console.WriteLine("Периметр п'ятикутника:");
                perimeter += LengthSide(a, b);
                perimeter += LengthSide(b, c);
                perimeter += LengthSide(c, d);
                perimeter += LengthSide(d, e);
                perimeter += LengthSide(a, e);
            }


            
            Console.WriteLine("Периметр = " + perimeter);
            Console.WriteLine();// space
        }

    }
}
