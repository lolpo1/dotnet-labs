using AbstractFabric.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Products.Man
{
    internal class ManSock : ISock
    {
        public string Color { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }

        public ManSock() { }

        public ManSock(string color, double price, int size)
        {
            Color = color;
            Price = price;
            Size = size;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nMan - sock:\n" + $"Color: {this.Color}\n" + $"Size: {this.Size}" + $"Price: {this.Price}");
        }
    }
}
