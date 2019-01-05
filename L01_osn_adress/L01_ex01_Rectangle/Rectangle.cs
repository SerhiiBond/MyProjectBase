using System;
using System.Collections.Generic;
using System.Text;

namespace L01_ex01_Rectangle
{
    class Rectangle
    {
        double side1;
        double side2;
        double area;
        double perimetr;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            PerimetrCalculator();
            AreaCalculator();
        }
        public double Area
        {
            get { return area; }
        }

        public double Perimetr
        {
            get { return perimetr; }
        }

        double AreaCalculator()
        {
            return area = side1 * side2;
        }
        double PerimetrCalculator()
        {
            return perimetr = 2 * (side1 + side2);
        }
    }
}
