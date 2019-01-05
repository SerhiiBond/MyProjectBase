using System;
using System.Collections.Generic;
using System.Text;

namespace L01_osn_adress
{
    class Adress
    {
        private string index = null;
        private string country = null;
        private string city = null;
        private string street = null;
        private string house = null;
        private string apartment = null;
        public string Index
        {
            set { index = value; }
            get { return index; }
        }

        public string Country
        {
            set { country = value; }
            get { return country; }
        }

        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public string Street
        {
            set { street = value; }
            get { return street; }
        }
        public string House
        {
            set { house = value; }
            get { return house; }
        }
        public string Apartment
        {
            set { apartment = value; }
            get { return apartment; }
        }
    }
}
