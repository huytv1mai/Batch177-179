using DemoDatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDatabaseFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyStoreContext context = new MyStoreContext();
            //Show list of Category
            var list_category = context.Categories.ToList();
            Console.WriteLine("List of Category: ");
            foreach (var category in list_category)
            {
                Console.WriteLine($"CategoryId: {category.CategoryId} - CategoryName: {category.CategoryName}");
            }
            //Show list of Product
            var list_product = context.Products.ToList();
            Console.WriteLine("List of Product: ");
            foreach (var product in list_product)
            {
                Console.WriteLine($"ProductId: {product.ProductId} - ProductName: {product.ProductName} - Price: {product.UnitPrice} - UnitsinStock: {product.UnitsInStock} - CategoryName: {product.Category.CategoryName}");
            }

            var list_productByPrice = context.Products.Where(p => p.UnitPrice < 100000).OrderByDescending(p => p.ProductName).ToList();
            Console.WriteLine("List of Product by Price: ");
            foreach (var product in list_productByPrice)
            {
                Console.WriteLine($"ProductId: {product.ProductId} - ProductName: {product.ProductName} - Price: {product.UnitPrice} - UnitsinStock: {product.UnitsInStock} - CategoryName: {product.Category.CategoryName}");
            }
        }
    }
}
