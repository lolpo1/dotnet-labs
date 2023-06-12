using Bridge.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Figures
{
    public class Triangle : Shape
    {
        Triangle(IRendering drawtype,double x, double y, double widthABC, string color):base(drawtype)
        {
            this.Name = "Трикутник";
            this.Width = widthABC;
            this.dX = x;
            this.dY = y;
            this.Color = color;
        }
       
    }
}
