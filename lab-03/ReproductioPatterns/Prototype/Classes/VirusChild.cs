using Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Classes
{
    public class VirusChild : Virus
    {
        public DateTime BirthDate { set; get; }

        protected Virus parent;
        public Virus Parent 
        { 
            set {
                if (this.parent != null)
                {
                    this.parent.Children.Remove(this);
                    this.parent = value;
                    this.parent.Children.Add(this);
                }
                else
                this.parent = value;
            }
            get { return parent; } 
        }
        public VirusChild(string name, int weight, int age, string type, Virus parent):base(name,weight,age,type) { 
            this.BirthDate = DateTime.Now;
            this.Parent = parent;
            this.Parent.Children.Add(this);
        }

        public VirusChild(VirusChild obj) : base(obj)
        { 
            this.BirthDate = obj.BirthDate;
            this.Parent = obj.Parent;
            obj.Parent.Children.Add(this);
        }

        public override void ShowVirysInfo()
        {
            Console.WriteLine("ChildVirus:------------------------------------------------ \n" +
                 $"Name: {this.Name}.\n" +
                 $"Type: {this.Type}.\n" +
                $"Weight: {this.Weight}.\n" +
                $"Age: {this.Age}.\n" +
                $"ParentInfo:----------------------");
            this.Parent.ShowVirysInfo();
            Console.WriteLine("\n");
        }

        public override IClone Clone()
        {
            return new VirusChild(this);
        }
    }
}
