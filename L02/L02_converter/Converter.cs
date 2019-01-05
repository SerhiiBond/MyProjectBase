using System;
using System.Collections.Generic;
using System.Text;

namespace L02_converter
{
    class Converter
    {
        double usd, eur, rub;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public void UahToUsd (float uah)
        {
            Console.WriteLine("UAH = {0} --> USD = {1}", uah, uah / usd );
        }
        public void UsdToUah(float usd)
        {
            Console.WriteLine("USD = {0} --> UAH = {1}", usd, usd * this.usd);
        }

        public void UahToEur(float uah)
        {
            Console.WriteLine("UAH = {0} --> EUR = {1}", uah, uah / eur);
        }
        public void EurToUah(float eur)
        {
            Console.WriteLine("EUR = {0} --> UAH = {1}",eur, eur * this.eur);
        }
        public void UahToRub(float uah)
        {
            Console.WriteLine("UAH = {0} --> RUB = {1}", uah, uah / rub);
        }
        public void RubToUah(float rub)
        {
            Console.WriteLine("RUB = {0} --> UAH = {1}",rub, rub * this.rub);
        }
    }
}
