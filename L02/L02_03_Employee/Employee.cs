using System;
using System.Collections.Generic;
using System.Text;

namespace L02_03_Employee
{
    class Employee
    {
        private string secondName;
        private string name;
        private string post;
        private int experience;
        private double selary;

        public string SecondName
        {
            get { return secondName; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Post
        {
            get { return post; }
        }
        public int Experience
        {
            get { return experience; }
        }

        public Employee(string secondName, string name)
        {
            this.secondName = secondName;
            this.name = name;
        }

        public double CountSelary (string post, int experience)
        {
            this.post = post;
            this.experience = experience;

            switch (post.ToLower())
            {
                case "director": selary = 200;
                    break;
                case "manager":
                    selary = 100;
                    break;
                case "cleaner":
                    selary = 60;
                    break;
            }
            if (experience > 0 && experience <= 3) selary *= 1;
            if (experience > 3 && experience <= 6) selary *= 1.5;
            if (experience > 6 && experience <= 10) selary *= 2;
            if (experience > 10) selary *= 3;
            return selary;
        }

        public void ShowSelary()
        {
            Console.WriteLine("selary = {0}, tax = {1}", selary, selary*0.13);
        }
    }
}
