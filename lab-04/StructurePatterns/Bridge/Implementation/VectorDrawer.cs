using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bridge.Implementation
{
    public class VectorDrawer : IRendering
    {
        public void GraphicDraw(string name) 
        {
            Console.WriteLine($"Drawing {name} as a vector.");

        }
    }
}
