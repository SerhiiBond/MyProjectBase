using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue, maxValue;
            int sum = 0;

            Array arr = new Array(10, 25, 32, 45, 5, 6, 34, 56, 77, 11, 15, 14, -4, 1);

            arr.PrintAllArray();

            minValue = arr[0];
            maxValue = arr[0];
            for (int i = 0; i < arr.Length(); i++)
            {
                if (minValue > arr[i]) minValue = arr[i];
                if (maxValue < arr[i]) maxValue = arr[i];
                sum = sum + arr[i];
            }

            Console.WriteLine("Min = {0}", minValue);
            Console.WriteLine("Max = {0}", maxValue);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", sum/arr.Length());

            Console.ReadKey();
        }
    }
}
