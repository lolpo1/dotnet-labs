using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementation
{
    public class RasterDrawer : IRendering
    {
        public void GraphicDraw(string name)
        {
            Console.WriteLine($"Drawing {name} as a raster.");
        }
    }
}
