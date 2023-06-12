using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chair
{
    public class AnswerNetwork : HelperIntercepterBase
    {
        public override string Handle()
        {
            Console.WriteLine("Do you have a problem with network connection?Choose either: yes or no!");
            string answer = Console.ReadLine();
            if(answer == "yes")
            {
                Console.WriteLine("There is a solve...");
                return answer;
            }
            return base.Handle();

        }
    }
}
