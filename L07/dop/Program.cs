using System;

namespace dop
{
    struct Notebook
    {
        string model;
        string producer;
        double price;

        public Notebook(string model, string producer, double price)
        {
            this.model = model;
            this.producer = producer;
            this.price = price;
        }
        public void Show()
        {
            Console.WriteLine("Модель: {0}; Производитель: {1}; Цена: {2}", model, producer, price);
        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        public string Producer
        {
            set { producer = value; }
            get { return producer; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook("Шкода", "Украина", 24000);
            notebook1.Show();

            Notebook notebook2 = new Notebook();
            notebook2.Model = "Шкода";
            notebook2.Producer = "Украина";
            notebook2.Price = 24000;
            notebook2.Show();
            Console.ReadKey();
        }
    }
}
