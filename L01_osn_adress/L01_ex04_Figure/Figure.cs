using System;
using System.Collections.Generic;
using System.Text;

namespace L01_ex04_Figure
{
    class Figure
    {
        Point[] point;
        String type;
        public string Type
        {
            get { return type; }
        }
        public Figure(Point A, Point B, Point C)
        {
            point = new Point[3];
            point[0] = A;
            point[1] = B;
            point[2] = C;
            type = "Triangle";
        }
        public Figure(Point A, Point B, Point C, Point D )
        {
            point = new Point[4];
            point[0] = A;
            point[1] = B;
            point[2] = C;
            point[3] = D;
            type = "Tetragon";
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            point = new Point[5];
            point[0] = A;
            point[1] = B;
            point[2] = C;
            point[3] = D;
            point[4] = E;
            type = "Pentagon";
        }
        private double CalculateSideLength(Point A, Point B)
        {
            double length = 0;
            if (A.PointX >= B.PointX && A.PointY >= B.PointY)
            {
                length = Math.Sqrt((A.PointX - B.PointX)^2 + (A.PointY - B.PointY)^2);
            }
            if (A.PointX >= B.PointX && A.PointY <= B.PointY)
            {
                length = Math.Sqrt((A.PointX - B.PointX) ^ 2 + (B.PointY - A.PointY) ^ 2);
            }
            if (A.PointX <= B.PointX && A.PointY >= B.PointY)
            {
                length = Math.Sqrt((B.PointX - A.PointX) ^ 2 + (A.PointY - B.PointY) ^ 2);
            }
            if (A.PointX <= B.PointX && A.PointY <= B.PointY)
            {
                length = Math.Sqrt((B.PointX - A.PointX) ^ 2 + (B.PointY - A.PointY) ^ 2);
            }
            return length;
        }

        public double CalculatePerimetr()
        {
            double sum = 0;
            for (int i = 0; i < point.Length-1; i++)
            {
                sum = sum + CalculateSideLength(point[i], point[i + 1]);
            }
            sum = sum + CalculateSideLength(point[0], point[point.Length - 1]);
            return sum;
        }
    }
}
