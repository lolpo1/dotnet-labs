using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.classes.Meal
{
    public abstract class Meal
    {
        public abstract string Name { get; }
        public abstract double Price { get; }
        public abstract int Count { get; }
        public abstract string Ingridients { get; }
        public abstract string Calories { get; }
        public abstract string Weight { get; }

    }
}
