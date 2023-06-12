using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.classes.Meal
{
    public class Cola : Meal
    {
        public override string Name { get; } = "Coca Cola 0.5l";
        public override double Price { get; } = 1.69;
        public override int Count { get; } = 1;
        public override string Ingridients { get; } = "Potatoes, Non-Hydrogenated Vegetable Oils (Rapeseed), Dextrose (predominantly added at beginning of the potato season)";
        public override string Calories { get; } = "230 Cal";
        public override string Weight { get; } = "0.5l";

        public Cola() { }
    }
}
