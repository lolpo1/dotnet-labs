using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Subscription
{
    public class EducationalSubscription : ISubsciption
    {
        public double MonthFee { get; } = 5.99;
        public int MinSubscriptionPeriod { get;} = 1;
        public List<Channel> Channels { get; } = new List<Channel>() { new Channel("Tv1"), new Channel("Tv2"), new Channel("Tv3") };

        public EducationalSubscription() { }

        public void DisplayPlan()
        {
            Console.WriteLine($"\nEducational Plan:\n" +
                $"Month fee - {this.MonthFee}\n" +
                $"Channels: {GetChannelsInString()}\n");
        }

        public string GetChannelsInString()
        {
            string str = "";
            foreach (Channel c in Channels)
            {
                str += $" {c.Name}";
            }
            return str;
        }
    }
}
