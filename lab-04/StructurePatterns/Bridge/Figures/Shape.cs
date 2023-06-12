using Bridge.Implementation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Shape
    {
        public IRendering DrawType = new VectorDrawer();
        public string Name { set; get; }
        public double dX { set; get; }
        public double dY { set; get; }

        public double Width { set; get; }
        public string Color { set; get; }
        public double? BorderWidth { set; get; }
        public string? BorderColor { set; get; }

        public Shape(IRendering drawtype) {
            this.DrawType = drawtype;
        }
        public Shape() { }
        public void SetDrawType(IRendering type)
        {
            this.DrawType = type;
        }
        public virtual void Draw()
        {
            this.DrawType.GraphicDraw(this.Name);
        }
    }
}
