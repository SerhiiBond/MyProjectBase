using System;
using System.Collections.Generic;
using System.Text;

namespace L02_osn_anketa
{
    class User
    {
        readonly DateTime date;
        private string login;
        private string name;
        private string secondName;
        private int age;

        public string Login
        {
            set { login = value; }
            get { return login; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string SecondName
        {
            set { secondName = value; }
            get { return secondName; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        public User(DateTime date)
        {
            this.date = date;
        }

        public void ShowUser()
        {
            Console.WriteLine("Date: {0}; Time: {1}; Name: {2}; Secondname: {3}; Age: {4}", date.ToShortDateString(), date.ToShortTimeString(), name, secondName,age);
        }
    }
}
