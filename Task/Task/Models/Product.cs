using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    internal class Product
    {
        private string _name;
        private float _price;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public float Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public Product(string name, float price)
        {
           Name = name;
           Price = price;
        }
        public void Login()
        {
            Username = Console.ReadLine;
            Password = Console.ReadLine
        }
    }
}
