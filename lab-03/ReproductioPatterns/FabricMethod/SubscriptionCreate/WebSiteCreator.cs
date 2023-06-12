using FabricMethod.Interfaces;
using FabricMethod.Subscription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.SubscriptionCreate
{
    public class WebSiteCreator : ISubscriptionCreator
    {
        public ISubsciption CreateSubscription()
        {
            Console.WriteLine("-----------------Buying subscription through a website...");
            Console.WriteLine("Choose your plan:\n");
            Console.WriteLine("1 - Home\n");
            Console.WriteLine("2 - Educational\n");
            Console.WriteLine("3 - Premium\n");
            string num = Console.ReadLine();
            switch (num)
            {
                case "1": return new DomesticSubscription();
                    break;
                case "2":
                    return new EducationalSubscription();
                    break;
                case "3":
                    return new PremiumSubscription();
                    break;
                default:
                    throw new NotImplementedException($"no plan {num}");
                    
            }
        }

    }
}
