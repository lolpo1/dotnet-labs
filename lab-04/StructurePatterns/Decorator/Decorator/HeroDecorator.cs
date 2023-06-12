using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public abstract class Decorator : Hero
    {
        protected Hero hero;
        public Decorator(Hero her):base() 
        {
            this.hero = her;
        }
        public override void ShowHero()
        {
            this.hero.ShowHero();
        }

    }


}
