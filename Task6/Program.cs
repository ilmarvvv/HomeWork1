using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Потрібно: Створити клас із ім'ям Address.

//У тілі класу потрібно створити поля: index, country, city, street, house, apartment.

//Для кожного поля створити властивість з двома методами доступу.

//Створити екземпляр класу Address.

//У поля екземпляра записати інформацію про поштову адресу.
//Виведіть на екран значення полів, що описують адресу.

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Address address = new Address
            {
                Name = "ILLIA SHEVIAKOV",
                Apartment = "1",
                House = "150",
                Street = "Flora Dr.",
                City = "Scarborough",
                Country = "Canada",
                Index = "M1P 1A7"
            };

            address.Show();
            Console.ReadKey();
        }
    }
}
