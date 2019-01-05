using System;

namespace Dop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" a + b = {0}", Calculator.Add(3.3, 0.7));
            Console.WriteLine(" a - b = {0}", Calculator.Subtract(3.3, 0.7));
            Console.WriteLine(" a - b = {0}", Calculator.Subtract(3.3, 4));
            Console.WriteLine(" a * b = {0}", Calculator.Mult(3.3, 0));
            Console.WriteLine(" a * b = {0}", Calculator.Mult(3.5, 5));
            if(Calculator.Division(15, 5) != 0)
            {
                Console.WriteLine(" a / b = {0}", Calculator.Division(3.5, 5));
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя");
            }

            Console.ReadKey();
        }
    }
}
