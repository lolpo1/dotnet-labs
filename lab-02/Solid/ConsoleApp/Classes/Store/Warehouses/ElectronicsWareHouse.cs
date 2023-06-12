using ConsoleApp.Interfaces;
using ConsoleApp.ProductPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes.Store
{
    public class ElectronicsWareHouse : Warehouse
    {
        //Open/Closed (Можливість розширення батьківського класу без його зміни.)
        public override string Title { set; get; } = "Electronic";

        public ElectronicsWareHouse(IMoney money) : base(money) { }
    }
}
