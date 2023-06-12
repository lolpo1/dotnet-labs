using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chair
{
    public class AnswerEnd : HelperIntercepterBase
    {
        public override string Handle()
        {
            Console.WriteLine("Do you want to reread quetions again?Choose either: yes or no!");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                return "";
            }
            this.LastIntercepter = true;
            return base.Handle();

        }
    }
}
