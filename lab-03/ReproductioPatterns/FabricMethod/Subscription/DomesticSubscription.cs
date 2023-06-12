using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Subscription
{
    public class DomesticSubscription : ISubsciption
    {
        public double MonthFee { get; } = 9.99;
        public int MinSubscriptionPeriod { get; } = 1;
        public List<Channel> Channels { get; } = new List<Channel>() {new Channel("Tv1"), new Channel("Tv2"), new Channel("Tv3") };

        public DomesticSubscription() { }   

        public void DisplayPlan()
        {
            Console.WriteLine($"\nDomestic Plan:\n" +
                $"Month fee - {this.MonthFee}\n" +
                $"Channels: {GetChannelsInString()}\n");
        }

        protected string GetChannelsInString()
        {
            string str = "";
            foreach ( Channel c in Channels )
            {
                str += $" {c.Name}";
            }
            return str;
        }
    }
}
