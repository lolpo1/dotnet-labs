using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Interfaces
{
    public interface IMoney
    {

        public string Name { set; get; }
        public char Sign { set; get; }
        public string IntPart { set; get; }
        public string FractionPart { set; get; }

        public string GetTotalInString();
        public void Subtruct(double num) { }
        public void WriteMoney(string num) { }
        public void EnterIntPart(string num) { }
        public void EnterFractionPart(string num) { }
        public void ShowValue() { }
    }
}
