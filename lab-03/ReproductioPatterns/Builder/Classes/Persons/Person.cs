using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Person : IPerson
    {
        public Person() { }
        public string? Height { get; set; }
        public string? Body { get; set; }
        public string? HairStyle { get; set; }
        public string? HairColor { get; set; }
        public string? EyesColor { get; set; }
        public string? ClothesStyle { get; set; }
        public string? MainWeapon { get; set; }
        public string[]? Features { get; set; }
        public string State { get; set; }
        public string Name { get; set; }
        public string[]? Vulnerable { get; set; }

        public void ShowPerson()
        {
            Console.WriteLine($"\n{this.State} characteristics:\n");
            if(this.Name != null)
                Console.WriteLine($"Name: {this.Name}\n");
            if (this.Body != null)
                Console.WriteLine($"Body: {this.Body}\n");
            if (this.HairStyle != null)
                Console.WriteLine($"HairStyle: {this.HairStyle}\n");
            if (this.HairColor != null)
                Console.WriteLine($"HairColor: {this.HairColor}\n");
            if (this.EyesColor != null)
                Console.WriteLine($"EyesColor: {this.EyesColor}\n");
            if (this.ClothesStyle != null)
                Console.WriteLine($"ClothesStyle: {this.ClothesStyle}\n");
            if (this.Features != null)
            {
                Console.WriteLine($"Features: {String.Join(", ", this.Features)}\n");
            }
            if (this.Vulnerable != null)
            {
                Console.WriteLine($"Weaknesses: {String.Join(", ", this.Vulnerable)}\n");
            }

        }
    }
}
