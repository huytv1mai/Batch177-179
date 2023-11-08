using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN.CollectionAndGenegle
{
     class Products
    {
        private string Name;
        private double Cost;
        private int Quantity;
        private Products(string name, double cost, int quantity)
        {
            this.Name = name;
            this.Cost = cost;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Name: {Name}-{Cost}-{Quantity}";
        }
        internal class ArraylistDemo
        {
            public void Run()
            {
                ArrayList List = new ArrayList();
                {
                    new Products("Telephone", 3000, 300);
                    new Products("Screen", 2000, 100);
                    new Products("CPU", 5000, 200);

                };
                foreach(var p in List)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
