using Decorator.Decorator.Artifacts;
using Decorator.Decorator.Weapones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator;
using Decorator.Decorator.Artifacts;
using Decorator.Decorator.Weapones;
using Decorator.Decorator.Clothes;

namespace Decorator
{
    class TestClass
    {
        static void Main(string[] args)
        {

            Hero warrior = new Warrior("John");
            warrior.ShowHero();
            new RulingRing(warrior);
            warrior.ShowHero();
            new Sword(warrior);
            warrior.ShowHero();

            Hero Mage = new Warrior("Alex");
            Mage.ShowHero();
            new Warder(Mage);
            Mage.ShowHero();
            new Mantle(Mage);
            Mage.ShowHero();
            new RulingRing(Mage);
            Mage.ShowHero();


        }
    }
}
