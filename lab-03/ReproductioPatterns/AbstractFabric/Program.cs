

using AbstractFabric.Factories;
using AbstractFabric.interfaces;

IClothesFactory factory;
Console.WriteLine("Choose a cloth type:");
Console.WriteLine(" 1 - for man:");
Console.WriteLine(" 2 - for woman:");
Console.WriteLine(" 3 - for children:");
string num = Console.ReadLine();
switch (num)
{
    case "1": factory = new ManClothesFactory();
        break; 
    case "2": factory = new WomanClothesFactory();
        break;
    case "3": factory = new ChildrenClothesFactory();
        break;
    default: throw new Exception("no cloth type");
}



IClothe clothe;
Console.WriteLine("Choose a cloth:");
Console.WriteLine(" 1 - for shoe:");
Console.WriteLine(" 2 - for cap:");
Console.WriteLine(" 3 - for sock:");
Console.WriteLine(" 4 - for t-shirt:");
string num2 = Console.ReadLine();
Console.WriteLine("Write a size:");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Write a color:");
string color = Console.ReadLine();
Console.WriteLine("Write a price:");
double price = double.Parse(Console.ReadLine());

switch (num2)
{
    case "1":
        clothe = factory.CreateShoe(color,size,price);
        break;
    case "2":
        clothe = factory.CreateCap(color, size, price);
        break;
    case "3":
        clothe = factory.CreateSock(color, size, price); 
        break;
    case "4":
        clothe = factory.CreateTShirt(color, size, price);
        break;
    default: throw new Exception("no cloth");
}

clothe.ShowInfo();