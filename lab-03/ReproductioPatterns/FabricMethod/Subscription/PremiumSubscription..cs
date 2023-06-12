using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Subscription
{
    public class PremiumSubscription : ISubsciption
    {
        public double MonthFee { get; } = 16.99;
        public int MinSubscriptionPeriod { get; } = 1;
        public List<Channel> Channels { get; } = new List<Channel>() { new Channel("Tv1HD"), new Channel("Tv2HD"), new Channel("Tv3HD") };

        public PremiumSubscription() { }

        public void DisplayPlan()
        {
            Console.WriteLine($"\nPremium Plan:\n" +
                $"Month fee - {this.MonthFee}\n" +
                $"Channels: \n{GetChannelsInString()}\n");
        }

        public string GetChannelsInString()
        {
            string str = "";
            foreach (Channel c in Channels)
            {
                str += $" {c.Name}\n";
            }
            return str;
        }
    }
}
