using AbstractFabric.interfaces;
using AbstractFabric.Products.Children;
using AbstractFabric.Products.Man;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Factories
{
    internal class ManClothesFactory : IClothesFactory
    {
        public ICap CreateCap(string color, int size, double price)
        {
            return new ManCap(color, price, size);
        }

        public IShoe CreateShoe(string color, int size, double price)
        {
            return new ManShoe(color, price, size);
        }

        public ISock CreateSock(string color, int size, double price)
        {
            return new ManSock(color, price, size);
        }

        public ITShirt CreateTShirt(string color, int size, double price)
        {
            return new ManTShirt(color, price, size);
        }
    }
}
