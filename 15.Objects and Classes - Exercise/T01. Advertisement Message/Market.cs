using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Advertisement_Message
{
    internal static class Market
    {
        public static List<Product> Products = new List<Product>(); 

        private static Product FindProductByBarcode(string barcode)
        {
            foreach (var item in Market.Products)
            {
                if (item.Code == barcode)
                {
                    return item;
                }
            }
            return null;
        }

        public static void Sell(string code, double quantity)
        {
            Product product = FindProductByBarcode(code);

            if (product == null)
            {
                Console.WriteLine("Product not found");
                return;
            }

            double newQuantity = product.Quantity - quantity;
            if (newQuantity < 0)
            {
                Console.WriteLine("Not enough quantity");
                return;
            }

            product.Quantity = newQuantity; 
        }

        public static void Add(Product product)
        {
            Market.Products.Add(product);
        }

        public static void Update(string barcode, double quantity)
        {
            Product product = FindProductByBarcode(barcode);
            if (product == null)
            {
                Console.WriteLine("Please add your product first");
                return;
            }
            product.Quantity = quantity;
        }

        public static void PrintA()
        {
            Market.Products
                .OrderBy(x => x.Name)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }

        public static void PrintU()
        {
            Market.Products
                .Where(x => x.Quantity <= 0)
                .OrderBy(x => x.Name)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }

        public static void PrintD()
        {
            Market.Products
                .Where(x => x.Quantity <= 0)
                .OrderByDescending(x => x.Quantity)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }

        public static double Calculate()
        {
            return Market.Products
                .Sum(x => x.Price);
        }
    }
}
