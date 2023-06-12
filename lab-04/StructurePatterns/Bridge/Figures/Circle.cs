using Bridge.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Figures
{
    public class Circle : Shape
    {
        public Circle(IRendering drawtype) :base(drawtype) { }
        public Circle(IRendering drawtype,double x, double y, double radius,string color):base(drawtype)
        {
            this.Name = "Коло";
            this.Width = radius;
            this.dX = x;
            this.dY = y;
            this.Color = color;
        }
      
    }
}
