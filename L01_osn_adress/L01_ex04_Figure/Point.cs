using System;
using System.Collections.Generic;
using System.Text;

namespace L01_ex04_Figure
{
    class Point
    {
        private string nameOfPoint;
        private int pointX;
        private int pointY;
        public Point(string nameOfPoint, int pointX, int pointY)
        {
            this.nameOfPoint = nameOfPoint;
            this.pointX = pointX;
            this.pointY = pointY;
        }
        public string NameOfPoint
        {
            get { return nameOfPoint; }
        }
        public int PointX
        {
            get { return pointX; }
        }
        public int PointY
        {
            get {return pointY; }
        }

    }
}
