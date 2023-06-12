using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.classes.Meal
{
    public class DoubleBurger : Burger 
    {
        public override string Name { get; } = "DoubleBurger Classic";
        public override double Price { get; } = 3.99;
        public override string Weight { get; } = "340g";
        public override string Ingridients { get; } = "100% beef patty with onions, pickles, mustard and a dollop of tomato ketchup, all in a soft bun";
        public override string Calories { get; } = "350 Cal";
        public DoubleBurger():base() { }
    }
}
