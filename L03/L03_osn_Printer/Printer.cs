using System;
using System.Collections.Generic;
using System.Text;

namespace L03_osn_Printer
{
    class Printer
    {
        ConsoleColor color;
        public Printer(ConsoleColor color)
        {
            this.color = color;
        }

        public void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
