using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.classes.Meal
{
    public class Burger : Meal
    {
        public override string Name { get; } = "Burger Classic";
        public override double Price { get; } =2.99;
        public override int Count { get; } = 1;
        public override string Weight { get; } = "240g";
        public override string Ingridients { get; } = "100% beef patty with onions, pickles, mustard and a dollop of tomato ketchup, all in a soft bun";
        public override string Calories { get; } = "250 Cal";
        public Burger() { }
    }
}
