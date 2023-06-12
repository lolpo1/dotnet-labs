using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.interfaces
{
    internal interface IClothesFactory
    {
        public IShoe CreateShoe(string color, int size, double price);
        public ICap CreateCap(string color, int size, double price);
        public ISock CreateSock(string color, int size, double price);
        public ITShirt CreateTShirt(string color, int size, double price);
    }
}
