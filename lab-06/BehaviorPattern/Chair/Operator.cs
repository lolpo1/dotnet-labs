using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chair
{
    public class Operator : HelperIntercepterBase
    {
        public override string Handle()
        { 
            Console.WriteLine("Do you want to talk to an operator? Choose either: yes or no!");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("Please, wait a few...");
                Console.WriteLine("We are putting you through an operator...");
                Console.WriteLine("Hello...");
                return answer;
            }
            return base.Handle();
        }
    }
}
