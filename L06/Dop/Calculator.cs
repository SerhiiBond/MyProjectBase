using System;
using System.Collections.Generic;
using System.Text;

namespace Dop
{
    static class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Mult(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                return 0; 
            }
            
        }
    }
}
