using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator.Weapones
{
    public class Sword : Decorator
    {
        public Sword(Hero her) : base(her)
        {
            this.hero.Weapons.Add("Iron Sword");
            this.hero.Attack += 30;
        }
    }

}
