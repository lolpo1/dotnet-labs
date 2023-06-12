using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.MoneyPart
{
    //Деталі залежать від абстракції
    public class Euro : Money
    {
        public Euro(string num) : base(num) { }
        public Euro() { }
        public Euro(Euro obj) : base(obj) { }
        public override string Name { set; get; } = "EUR";
        public override char Sign { set; get; } = '€';

        public override void ShowValue()
        {
            Console.WriteLine($"Currency: {this.Name}.\n Account: {this.IntPart} euros and {this.FractionPart} cents.");

        }
    }
}
