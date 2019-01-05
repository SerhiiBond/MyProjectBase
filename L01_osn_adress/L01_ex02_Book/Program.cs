using System;

namespace L01_ex02_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            string author = "autor";
            string title = "title";
            string content = "content";

            Book book = new Book(author, title, content);

            book.Show();
            Console.ReadKey();
        }
        
    }
}
