using System;

namespace L02_03_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Bond", "Serg");
            employee.CountSelary("Director", 11);
            Console.WriteLine("Employee: {0} {1} - {2} Experience: {3}", employee.SecondName, employee.Name, employee.Post, employee.Experience);
            employee.ShowSelary();


            Console.ReadLine();
        }
    }
}
