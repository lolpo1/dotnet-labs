

using Facade.classes;

BigMacMenu menu = new BigMacMenu();
menu.ShowMenu();
Console.WriteLine($"Total: {menu.GetTotalPrice()}");