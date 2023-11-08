using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN.CollectionAndGenegle
{
    public class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }
        public Product(string name, double cost, int quantity)
        {
            Name = name;
            Cost = cost;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Product: {Name}, Cost: {Cost}, Quantity: {Quantity}";
        }
    }
}
