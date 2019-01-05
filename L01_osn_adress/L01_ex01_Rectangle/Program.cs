using System;

namespace L01_ex01_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2, 5);
            Console.WriteLine("Perimetr = {0}", rectangle.Perimetr);
            Console.WriteLine("Area = {0}", rectangle.Area);
            Console.ReadKey();
        }
    }
}
