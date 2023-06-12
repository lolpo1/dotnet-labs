using Decorator.Wrapee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public float Hp { get; set; }
        public float Attack { get; set; }
        public List<string>? Weapons { get; set; } = new List<string>();
        public List<string>? Clothes { get; set; } = new List<string>();
        public List<string>? Artefacts { get; set; } = new List<string>();

        public virtual void ShowHero()
        {
            Console.WriteLine($"Name {Name}\n" +
                $"Hp: {Hp}\n" +
                 $"Attack: {Attack}\n" +
                  $"Weapons: {this.ShowFeatures(this.Weapons)}\n" +
                   $"Clothes: {this.ShowFeatures(this.Clothes)}\n" +
                    $"Artefacts: {this.ShowFeatures(this.Artefacts)}\n");
        }


        protected string ShowFeatures(List<string> features)
        { 
           return String.Join(", ", features);
        }

    }
}
