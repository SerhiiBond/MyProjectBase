using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Article
{
    class Article
    {
        private string nameOfProduct;
        private string nameOfShop;
        private int priceOfProduct;

        public string NameOfProduct
        {
            get { return nameOfProduct; }
        }

        public int PriceOfProduct
        {
            get { return priceOfProduct; }
        }
        public Article(string nameOfProduct, string nameOfShop, int priceOfProduct)
        {
            this.nameOfProduct = nameOfProduct;
            this.nameOfShop = nameOfShop;
            this.priceOfProduct = priceOfProduct;
        }

        public string Info()
        {
            return String.Format("{0} из магазина {1} по цене {2} грн.", nameOfProduct, nameOfShop, priceOfProduct);
        }
    }
}
