using System;

namespace L01_osn_adress
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();
            adress.Country = "Ukraine";
            adress.City = "Kiev";
            adress.Index = "123456";
            adress.Street = "Erevan";
            adress.House = "14";
            adress.Apartment = "61";

            Console.WriteLine(new string('*', 50));
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", adress.Country, adress.City, adress.Index, adress.Street, adress.House, adress.Apartment);
            Console.WriteLine(new string('*', 50));
            Console.ReadKey();
        }
    }
}
