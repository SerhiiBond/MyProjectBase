using System;

namespace L01_ex04_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure0 = new Figure(new Point("A", 1, 1), new Point("B", 1, 4), new Point("C", 4, 4));
            Console.WriteLine("Name of figure - {0}", figure0.Type);
            Console.WriteLine("Perimetr = {0}", figure0.CalculatePerimetr());

            Figure figure1 = new Figure(new Point("A", 1, 1), new Point("B", 1, 4), new Point("C", 4, 4), new Point("D", 4, 1));
            Console.WriteLine("Name of figure - {0}", figure1.Type);
            Console.WriteLine("Perimetr = {0}", figure1.CalculatePerimetr());

            Figure figure2 = new Figure(new Point("A", 1, 1), new Point("B", 1, 4), new Point("C", 4, 4), new Point("D", 4, 1), new Point("E", 5, 3));
            Console.WriteLine("Name of figure - {0}", figure2.Type);
            Console.WriteLine("Perimetr = {0}", figure2.CalculatePerimetr());

            Console.ReadKey();
        }
    }
}
