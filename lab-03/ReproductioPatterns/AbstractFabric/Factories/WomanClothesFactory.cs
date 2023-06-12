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
    internal class WomanClothesFactory : IClothesFactory
    {
        public ICap CreateCap(string color, int size, double price)
        {
            return new WomanCap(color, price, size);
        }

        public IShoe CreateShoe(string color, int size, double price)
        {
            return new WomanShoe(color, price, size);
        }

        public ISock CreateSock(string color, int size, double price)
        {
            return new WomanSock(color, price, size);

        }

        public ITShirt CreateTShirt(string color, int size, double price)
        {
            return new WomanTShirt(color, price, size);

        }
    }
}
