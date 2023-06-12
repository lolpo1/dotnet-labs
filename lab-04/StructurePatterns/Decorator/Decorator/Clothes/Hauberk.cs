using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator.Clothes
{
    public class Hauberk : Decorator
    {
        public Hauberk(Hero her) : base(her)
        {
            this.hero.Clothes.Add("Hauberk");
            this.hero.Attack -= 7;
            this.hero.Hp += 30;
        }
    }
}
