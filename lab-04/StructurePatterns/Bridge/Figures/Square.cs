using Bridge.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Figures
{
    public class Square : Shape
    {
        public double Height { get; set; }
        Square(IRendering drawtype,double x, double y, double width, string color):base(drawtype)
        {
            this.Name = "Квадрат";
            this.Width = width;
            this.Height = width;
            this.dX = x;
            this.dY = y;
            this.Color = color;
        }
      
    }
}
