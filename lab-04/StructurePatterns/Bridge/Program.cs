
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Bridge.Figures;
using Bridge.Implementation;

namespace Bridges
{
    class TestClass
    {
        static void Main(string[] args)
        {

            RasterDrawer raster = new RasterDrawer();
            VectorDrawer vector = new VectorDrawer();
            Circle circle = new Circle(raster,10,10,1,"Red");
            circle.Draw();
            circle.SetDrawType(vector);
            circle.Draw();
        }
    }
}