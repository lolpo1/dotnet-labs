using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator.Artifacts
{
    public class RulingRing : Decorator
    {
        public RulingRing(Hero her) : base(her)
        {
            this.hero.Artefacts.Add("RulingRing");
            this.hero.Hp+= 50;
            this.hero.Weapons.Add("Invisibility");
        }
    }
}
