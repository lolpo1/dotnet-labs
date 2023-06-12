using FlyWeight.AfterFlyWeight;
using FlyWeight.BeforeFlyWeight;



string path = "book.txt";

/*Console.WriteLine("----------BeforeFlyWeight");
LightHTML html = new LightHTML(path);
*/
///Після тестування викорисатння пам'яті = 35,45 МБ
//--------------------------------------------------------

Console.WriteLine("----------AfterFlyWeight");
LightHTMLFly htmlFly = new LightHTMLFly(path);
///Після тестування викорисатння пам'яті = 34,96 МБ
///
/*InstricTagFactory.ShowDictCount();*/ //Метод для перегляду кількості створених InstricTag у InstricTagFactory