using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Palladin : Hero
    {
        public Palladin(string name):base() 
        {
            this.Name = name;
            this.Hp = 100;
            this.Attack = 120;
        }
    }
}
