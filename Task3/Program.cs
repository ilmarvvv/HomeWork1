using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Потрібно: Створити клас Book.

//Створити класи Title, Author та Content,
//кожен з яких повинен містити одне рядкове поле та метод void Show().

//Реалізуйте можливість додавання до книги назви книги, імені автора та змісту.

//Виведіть на екран різними кольорами за допомогою методу Show() назву книги, ім'я автора та зміст.

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Book book = new Book("Вітра зими");
            book.Content = "Джон має колись воскреснути...";
            book.Footer = "Джордж Мартін";

            book.Show();

            Console.ReadKey();
        }
    }
}
