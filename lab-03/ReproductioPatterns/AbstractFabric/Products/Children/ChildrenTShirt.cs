using AbstractFabric.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Products.Children
{
    internal class ChildrenTShirt : ITShirt
    {
        public string Color { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }

        public ChildrenTShirt() { }

        public ChildrenTShirt(string color, double price, int size)
        {
            Color = color;
            Price = price;
            Size = size;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nChildren - T-shirt:\n" + $"Color: {this.Color}\n" + $"Size: {this.Size}" + $"Price: {this.Price}");
        }
    }
}
