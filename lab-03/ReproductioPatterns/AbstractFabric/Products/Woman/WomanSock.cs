using AbstractFabric.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Products.Children
{
    internal class WomanSock : ISock
    {
        public string Color { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }

        public WomanSock() { }

        public WomanSock(string color, double price, int size)
        {
            Color = color;
            Price = price;
            Size = size;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nWoman - sock:\n" + $"Color: {this.Color}\n" + $"Size: {this.Size}" + $"Price: {this.Price}");
        }
    }
}
