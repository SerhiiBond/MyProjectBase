using System;

namespace _01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            Timetable timetable = new Timetable();
            timetable.AddTrain("Киев", 923, "21:00");
            timetable.AddTrain("Чернигов", 817, "21:00");
            timetable.ShowTimeTable();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
