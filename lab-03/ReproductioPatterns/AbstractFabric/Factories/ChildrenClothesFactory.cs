using AbstractFabric.interfaces;
using AbstractFabric.Products.Children;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.Factories
{
    internal class ChildrenClothesFactory : IClothesFactory
    {
        public ICap CreateCap(string color, int size, double price)
        {
            return new ChildrenCap(color,price,size);
        }

        public IShoe CreateShoe(string color, int size, double price)
        {
            return new ChildrenShoe(color, price, size);

        }

        public ISock CreateSock(string color, int size, double price)
        {
            return new ChildrenSock(color, price, size);

        }

        public ITShirt CreateTShirt(string color, int size, double price)
        {
            return new ChildrenTShirt(color, price, size);

        }
    }
}
