using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Shop_Management
{
    public class Shop
    {
        private List<Product> products = new List<Product>();
        public double TotalIncome { get; private set; } = 0;

        public void AddProduct(string name, double price, int count, char productType)
        {
            if (products.Exists(p => p.Name == name))
            {
                Console.WriteLine("This product already exists.");
                return;
            }

            Product product;
            if (productType == 'c')
            {
                product = new Coffee { Name = name, Price = price, Count = count };
            }
            else if (productType == 't')
            {
                product = new Tea { Name = name, Price = price, Count = count };
            }
            else
            {
                Console.WriteLine("Invalid product type.");
                return;
            }

            products.Add(product);
            Console.WriteLine($"{name} added to shop.");
        }

        public void SellProduct(string name, int count)
        {
            var product = products.FirstOrDefault(p => p.Name == name);
            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            if (product.Count < count)
            {
                Console.WriteLine("Not enough stock.");
                return;
            }

            product.Count -= count;
            TotalIncome += product.Price * count;
            Console.WriteLine($"{count} {name}(s) sold for {product.Price * count}.");
        }

        public void ListProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}, Price: {product.Price}, Stock: {product.Count}");
            }
        }
    }
}
