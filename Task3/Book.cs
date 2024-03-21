using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Book
    {
        Title title = null;
        Content content = null;
        Author athor = null;

        private void InitializeBook()
        {
            this.title = new Title();
            this.content = new Content();
            this.athor = new Author();
        }
        public Book(string titleText)
        {
            InitializeBook();
            this.title.Text = titleText;
        }

        public void Show()
        {
            this.title.Show();
            this.content.Show();
            this.athor.Show();
        }

        public string Content
        {
            set { this.content.Text = value; }
        }
        public string Footer
        {
            set { this.athor.Text = value; }
        }
    }
}
