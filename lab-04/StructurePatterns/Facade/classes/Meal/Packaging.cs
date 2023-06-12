using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.classes.Meal
{
    public class Packaging
    {
        public string Name { get; } = "Standart package";
        public int Count { get; } =1;
        public double Price { get; } = 1; 
        public Packaging()
        {
        }
    }
}
