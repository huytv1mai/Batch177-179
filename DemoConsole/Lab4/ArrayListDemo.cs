using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab4
{
    class Products
    {
        private string name;
        private double price;
        private int quantity;
        public Products(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public override string ToString()
        {
            return $"Name: {name}-{price}-{quantity}";
        }
    }
    internal class ArrayListDemo
    {
        public void Run()
        {
            ArrayList list = new ArrayList()
            {
                new Products("Telephone",3000,300),
                new Products("Screen",2000,100),
                new Products("CPU",5000,200),
            };
            foreach(var p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
