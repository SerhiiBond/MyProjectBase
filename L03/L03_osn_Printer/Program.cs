using System;

namespace L03_osn_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer print = new Printer(ConsoleColor.Gray);
            print.Print("Hello World!");
            PrinterGreen printcolor = new PrinterGreen(ConsoleColor.Yellow);
            printcolor.Print("Hello World!");
            print.Print("Hello World!");
            Console.ReadKey();
        }
    }
}
