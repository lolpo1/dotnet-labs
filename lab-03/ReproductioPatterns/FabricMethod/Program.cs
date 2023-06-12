
using FabricMethod;
using FabricMethod.Interfaces;
using FabricMethod.SubscriptionCreate;

ISubscriptionCreator creator;
Console.WriteLine("Take a subscription method:");
Console.WriteLine("1 - Mobile app;");
Console.WriteLine("2 - WebSite;");
Console.WriteLine("3 - ManagerCall;");
string num = Console.ReadLine();

switch (num)
{
    case "1": creator = new MobileAppCreator();
        break;
    case "2": creator = new WebSiteCreator();
        break;
    case "3": creator = new ManagerCallCreator();
        break;
    default:
        throw new Exception("no action");
}

ISubsciption subsciption = creator.CreateSubscription();
subsciption.DisplayPlan();