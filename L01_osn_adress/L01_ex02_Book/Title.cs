using System;
using System.Collections.Generic;
using System.Text;

namespace L01_ex02_Book
{
    class Title
    {
        readonly string title;
        public Title(string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(title);
        }
    }
}
