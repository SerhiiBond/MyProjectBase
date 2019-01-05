using System;

namespace L02_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(28, 31.5, 0.4);
            converter.UahToUsd(42000);
            converter.UsdToUah(200);
            converter.UahToEur(42000);
            converter.EurToUah(200);
            converter.UahToRub(2000);
            converter.RubToUah(20000);
            Console.ReadLine();
        }
    }
}
