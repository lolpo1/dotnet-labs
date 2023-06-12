using Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Classes
{
    public class Virus : IClone
    {
        public string Name { set; get; }
        public int Weight { set; get; }
        public int Age { set; get; }
        public string Type { set; get; }
        public List<VirusChild> Children { set; get; } = new List<VirusChild>();

        public Virus(string name, int weight,int age, string type)
        {
            this.Name = name;
            this.Weight = weight;
            this.Age = age;
            this.Type = type;
          
        }

        public Virus(Virus obj) 
        { 
            this.Name = obj.Name;
            this.Weight = obj.Weight;
            this.Age = obj.Age;
            this.Type = obj.Type;
            this.Children = new List<VirusChild>(obj.Children);
        }

        protected string ChildrenOutPut()
        { 
            StringBuilder str = new StringBuilder();
            foreach (VirusChild child in Children)
            { str.Append($" {child.Name}"); }
            return str.ToString();

        }
        public virtual void ShowVirysInfo()
        {
            Console.WriteLine("Virus: \n" +
                $"Name: {this.Name}.\n" +
                $"Type: {this.Type}.\n" +
                $"Weight: {this.Weight}.\n" +
                $"Age: {this.Age}.\n" +
                $"Children count: {this.Children.Count()}.\n" +
                $"Children: {this.ChildrenOutPut()}");
        }

        public virtual IClone Clone()
        {
            return new Virus(this);
        }
    }
}
