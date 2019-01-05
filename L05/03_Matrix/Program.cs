using System;

namespace _03_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int NLine = 10;
            int NColume = 25;
            MyMatrix matrix = new MyMatrix(NLine, NColume);
            matrix.ShowLength();

            Console.WriteLine(new String('-',100));
            matrix.showPartMatrix(0, 0, NLine, NColume);
            Console.WriteLine(new String('-', 100));
            matrix.ChangeMatrix(3, 4);
            matrix.showPartMatrix(0, 0, 3, 4);
            Console.WriteLine(new String('-', 100));
            matrix.ChangeMatrix(12, 27);
            matrix.showPartMatrix(0, 0, 12, 27);
            Console.WriteLine(new String('-', 100));
            Console.ReadKey();
        }
    }
}
