using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.MoneyPart
{
    //Деталі залежать від абстракції
    public class Dollar : Money
    {
        public Dollar(string num) : base(num)
        { }
        public Dollar() { }

        public Dollar(Dollar obj) : base(obj) { }
        public override string Name { set; get; } = "USD";
        public override char Sign { set; get; } = '$';
        public override void ShowValue()
        {
            Console.WriteLine($"Currency: {this.Name}.\n Account: {this.IntPart} dollars and {this.FractionPart} cents.");       
        }
    }
}
