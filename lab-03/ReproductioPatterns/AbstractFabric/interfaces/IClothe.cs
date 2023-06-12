using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric.interfaces
{
    internal interface IClothe
    {
        string Color { set; get; }
        double Price { set; get; }
        int Size { set; get; }

        void ShowInfo();
    }
}
