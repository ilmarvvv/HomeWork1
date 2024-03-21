using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Author
    {
        private string text;

        public string Text
        {
            private get
            {
                if (text != null)
                    return text;
                else
                    return "Тіло документа відсутнє.";
            }
            set
            {
                text = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
