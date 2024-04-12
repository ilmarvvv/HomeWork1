using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2, 3);
            Console.WriteLine(rectangle.AreaCalculator());
            Console.WriteLine(rectangle.PerimeterCalculator());

            Console.WriteLine(rectangle.Area);
            Console.WriteLine(rectangle.Perimeter);

            Console.ReadKey();
        }
    }
}
