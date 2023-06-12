using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public interface ISubsciption
    {
        public double MonthFee { get;}
        public int MinSubscriptionPeriod { get;}
        public List<Channel>  Channels { get; }
        public void DisplayPlan();
    }
}
