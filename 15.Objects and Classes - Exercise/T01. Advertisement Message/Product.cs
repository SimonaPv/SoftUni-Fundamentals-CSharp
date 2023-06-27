
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Advertisement_Message
{
    internal class Product
    {
        private double price;

        public Product(string code, string name, double price, double quantity)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
        public string Code { get; set; }
      
        public string Name { get; set; }

        public double Price
        {
            get { return Math.Round(price, 2); }
            set { price = value; }
        }

        public double Quantity { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} {this.Code}");
            return sb.ToString().TrimEnd();
        }
    }
}
