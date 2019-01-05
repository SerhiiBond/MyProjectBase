using System;

namespace L03_03_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(0, 0, 10000, 1975, 30, 4000, 30);
            plane.show();

            Console.ReadKey();
        }
    }
}
