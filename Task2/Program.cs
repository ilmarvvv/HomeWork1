using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Потрібно: Створити клас із ім'ям Rectangle.

//У тілі класу створити два поля,
//що описують довжини сторін double side1, side2.

//Створити власний конструктор Rectangle(double side1, double side2),
//у тілі якого поля side1 і side2 ініціалізуються значеннями аргументів.

//Створити два методи, що обчислюють площу прямокутника - double AreaCalculator()
//та периметр прямокутника - double PerimeterCalculator().

//Створити дві властивості double Area та double Perimeter з одним методом доступу get.

//Написати програму, яка приймає від користувача довжини двох сторін прямокутника
//і виводить на екран периметр та площу. 

namespace Task2
{
    internal class Program
    {
        class Rectangle // Класи треба робити в окремій файли!
        {
            private double side1, side2;

            public Rectangle(double side1, double side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }

            private double AreaCalculator(double side1, double side2)
            {
                return side1 * side2;
            }

            private double PerimeterCalculator(double side1, double side2)
            {
                return 2 * (side1 + side2);
            }

            public double Area
            {
                get { return AreaCalculator(side1, side2); }
            }
            public double Perimeter
            {
                get { return PerimeterCalculator(side1, side2); }
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            // Enter side1 and side2
            Rectangle rectangle1 = new Rectangle(2, 4);
            
            Console.WriteLine("Площа прямокутника:    " + rectangle1.Area);
            Console.WriteLine("Периметр прямокутника: " + rectangle1.Perimeter);


            Console.ReadKey();
        }
    }
}
