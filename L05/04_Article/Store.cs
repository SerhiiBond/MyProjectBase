using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Article
{
    class Store
    {
        Article[] article;

        public Store(int n)
        {
            article = new Article[n];
        }
        public string this[int index]
        {
            get { return article[index].Info(); }
            //set { article[index] = value; }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < article.Length; i++)
                {
                    if (index == article[i].NameOfProduct)
                    {
                        return article[i].Info();
                    }
                }
                return "товар не найден";
            }
        }

        public void AddProduct(string nameOfProduct, string nameOfShop, int priceOfProduct, int n)
        {
            article[n] = new Article(nameOfProduct, nameOfShop, priceOfProduct);
        }
        public void ShowAll()
        {
            for (int i = 0; i < article.Length; i++)
            {
                Console.WriteLine(i+1+". "+ article[i].Info());
            }
        }
        public void SortMinToMax()
        {
            Article tmp;
            int numberOfCiclesFOR1 = 1;
            int numberOfCiclesFOR2 = 1;
            for (int i = 1; i < article.Length; i++)
            {
                tmp = article[i-1];
                numberOfCiclesFOR1++;
                for (int j = i; j < article.Length; j++)
                {
                    numberOfCiclesFOR2++;
                    if (tmp.PriceOfProduct > article[j].PriceOfProduct)
                    {
                        tmp = article[j];
                        article[j] = article[i-1];
                        article[i-1] = tmp;
                    }
                }               
                
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("numberOfCiclesFOR1 = {0}\nnumberOfCiclesFOR2 = {1}",numberOfCiclesFOR1, numberOfCiclesFOR2);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
