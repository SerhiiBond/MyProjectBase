using System;

namespace L02_osn_anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(DateTime.Now);

            Console.Write("Input name: ");
            user1.Name = Console.ReadLine();

            Console.Write("Input secondname: ");
            user1.SecondName = Console.ReadLine();

            Console.Write("Input age: ");
            user1.Age =Convert.ToInt16(Console.ReadLine());

            user1.ShowUser();
            Console.ReadLine();
        }
    }
}
