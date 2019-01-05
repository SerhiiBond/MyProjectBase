using System;
using System.Collections.Generic;
using System.Text;

namespace L01_ex02_Book
{
    class Author
    {
       private string author;
        public Author(string author)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(author);
        }
    }
}
