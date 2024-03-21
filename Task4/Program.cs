using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Потрібно: Створити класи Point та Figure.

//Клас Point повинен містити два цілих поля і одне рядкове поле.

//Створити три властивості одним методом доступу get.

//Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями аргументів.

//Клас Figure повинен містити конструктори, які приймають від 3 до 5 аргументів типу Point.

//Створити два методи:
//double LengthSide(Point A, Point B), що розраховує довжину сторони багатокутника;
//void PerimeterCalculator(), що розраховує периметр багатокутника.

//Написати програму, яка виводить на екран назву та периметр багатокутника.

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            #region Tringle

            Point A1 = new Point(0, 0, "A");
            Point B1 = new Point(3, 0, "B");
            Point C1 = new Point(0, 4, "C");

            Figure figure1 = new Figure(A1, B1, C1);
            figure1.PerimeterCalculator();

            #endregion

            #region Rectangle

            Point A2 = new Point(0, 0, "A");
            Point B2 = new Point(5, 0, "B");
            Point C2 = new Point(5, 4, "C");
            Point D2 = new Point(0, 4, "D");

            Figure figure2 = new Figure(A2, B2, C2, D2);
            figure2.PerimeterCalculator();

            #endregion

            #region Pentagon

            Point A3 = new Point(1, 2, "A");
            Point B3 = new Point(4, 4, "B");
            Point C3 = new Point(5, 3, "C");
            Point D3 = new Point(4, 1, "D");
            Point E3 = new Point(2, 1, "E");

            Figure figure3 = new Figure(A3, B3, C3, D3, E3);
            figure3.PerimeterCalculator();

            #endregion

            Console.ReadKey();
        }
    }
}
