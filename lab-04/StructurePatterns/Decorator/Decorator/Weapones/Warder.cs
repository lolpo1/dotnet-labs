using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator.Weapones
{
    public class Warder : Decorator
    {
        public Warder(Hero her) : base(her)
        {
            this.hero.Attack += 34;
            this.hero.Weapons.Add("Warder");
        }
    }
}
