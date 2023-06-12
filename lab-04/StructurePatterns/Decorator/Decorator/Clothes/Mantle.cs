using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator.Clothes
{
    public class Mantle : Decorator
    {
        public Mantle(Hero her) : base(her)
        {
            this.hero.Clothes.Add("mantle");
            this.hero.Hp += 18;

        }
    }
}
