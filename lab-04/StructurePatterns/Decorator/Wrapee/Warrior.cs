using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base()
        {
            this.Name = name;
            this.Hp = 120;
            this.Attack = 90;
        }
    }
}
