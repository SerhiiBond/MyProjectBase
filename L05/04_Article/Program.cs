using System;

namespace _04_Article
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(6);

            store.AddProduct("Карандаш", "Полис", 14, 0);
            store.AddProduct("Ручка", "Полис", 12, 1);
            store.AddProduct("Стол", "Эпицентр", 120, 2);
            store.AddProduct("Стул", "Эпицентр", 50, 3);
            store.AddProduct("Обои", "Ашан", 10, 4);
            store.AddProduct("Haribo", "Ашан", 1, 5);

            Console.WriteLine(new String('-', 70));
            store.ShowAll();
            Console.WriteLine(new String('-',70));
            Console.WriteLine("store[1] = " + store[1]);
            Console.WriteLine("store[0] = " + store[0]);
            Console.WriteLine("store[3] = " + store[3]);
            Console.WriteLine("store[5] = " + store[5]);
            Console.WriteLine(new String('-', 70));

            Console.WriteLine(store["Стул"]);
            Console.WriteLine(store["Сfvjktn"]);
            Console.WriteLine(new String('-', 70));

            store.SortMinToMax();
            store.ShowAll();

            Console.ReadKey();
                      
        }
    }
}
