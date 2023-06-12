



using Proxy;

string path = ".\\textfile\\text.txt";
string path2 = ".\\textfile\\text.cs";

Console.WriteLine("-------------SmartTextReader");
SmartTextReader reader1_0 = new SmartTextReader(path2);
reader1_0.Read();
reader1_0.GetLetters();



Console.WriteLine("-------------SmartTextChecker");
SmarTextChecker reader2_0 = new SmarTextChecker(reader1_0);
reader2_0.Read();


Console.WriteLine("-------------SmartTextReader");
Console.WriteLine("-----Regex with txt");
var reader3_1 = new SmartTextReaderLocker(reader2_0, path);
reader3_1.Read();
Console.WriteLine("-----Regex with cs");
var reader3_2 = new SmartTextReaderLocker(reader2_0, path2);
reader3_2.Read();