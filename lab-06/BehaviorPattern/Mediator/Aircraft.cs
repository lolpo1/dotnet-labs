using Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class Aircraft : AirConnection
    {
        public int BortID { get; }
        public int? CurrentRunwayID { get; set; }
        public bool IsTakingOff { get; set; }
        public Aircraft(int id)
        {
            this.BortID = id;
        }
        public void Land()
        {
            Console.WriteLine($"Aircraft {this.BortID} is landing.");
            this.NotifyCC("Land",this.BortID);
        }
        public void TakeOff()
        {
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Aircraft {this.BortID} is taking off.");
            Console.WriteLine($"Taking off.....");
            Console.WriteLine($"        -улетiв\n" +
           $"       -\n" +
           $"      -\n" +
           $"     -\n" +
           $"    -\n" +
           $"   -\n" +
           $"---\n");
            this.NotifyCC("TakeOff", this.BortID);
            Console.WriteLine($"Aircraft {this.BortID} has took off.");
        }
    }
}
