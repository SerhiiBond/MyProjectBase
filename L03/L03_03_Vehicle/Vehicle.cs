using System;
using System.Collections.Generic;
using System.Text;

namespace L03_03_Vehicle
{
    class Vehicle
    {
        public int coordinateX;
        public int coordinateY;
        public int price;
        public int year;
        public int speed;
        public Vehicle(int coordinateX, int coordinateY, int price, int year, int speed)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.price = price;
            this.year = year;
            this.speed = speed;
        }

        public virtual void show()
        {
            Console.WriteLine("Координата Х: {0}; Координата Y:{1}", coordinateX, coordinateY);
            Console.WriteLine("Цена: {0}; Год выпуска:{1}; Скорость: {2}", price, year, speed);
        }
    }
    class Plane : Vehicle
    {
        public int altitude;
        public int passanger;
        public Plane(int coordinateX, int coordinateY, int price, int year, int speed, int altitude, int passanger)
            : base(coordinateX, coordinateY, price, year, speed)
        {
            this.altitude = altitude;
            this.passanger = passanger;
        }

        public override void show()
        {
            Console.WriteLine("транспортное средство Plane:");
            base.show();
            Console.WriteLine("Altitude: {0}, Passanger: {1}", altitude, passanger);
        }
    }
}
