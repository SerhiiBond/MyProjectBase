using System;
using System.Collections.Generic;
using System.Text;

namespace L01_ex02_Book
{
    class Content
    {
        readonly string content;
        public Content(string content)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(content);
        }

    }
}
