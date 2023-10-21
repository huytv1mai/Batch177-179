using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab4
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<string> Colors { get; set; }

        public override string ToString()
        {
            return $"{Name}-{Price}";
        }
    }
    internal class ProductDemo
    {
        public void Run()
        {
            // Tạo danh sách sản phẩm
            List<Product> products = new List<Product>
        {
            new Product { Name = "Product 1", Price=400, Colors = new List<string> { "Red", "Blue", "Black" } },
            new Product { Name = "Product 2", Price=200, Colors = new List<string> { "Green", "Yellow", "Purple" } },
            new Product { Name = "Product 3", Price=440, Colors = new List<string> { "Yellow", "Orange", "Black" } }
        };
            List<Product> priceProducts = products.Where(p => p.Price==400).ToList();//filter
            Console.WriteLine("Price=400:");
            foreach (Product product in priceProducts)
            {
                Console.WriteLine(product);
            }
            // Lọc ra những sản phẩm chứa màu vàng
            List<Product> yellowProducts = products.Where(p => p.Colors.Contains("Yellow")).ToList();//filter
            Console.WriteLine("Yellow Products:");
            // In ra tên các sản phẩm chứa màu vàng
            foreach (Product product in yellowProducts)
            {
                Console.WriteLine(product);
            }
            List<Product> orderDesProducts = products.OrderByDescending(p=>p.Price).ToList();
            Console.WriteLine("Price Descending:");
            foreach (Product product in orderDesProducts)
            {
                Console.WriteLine(product);
            }
        }
    }
}
