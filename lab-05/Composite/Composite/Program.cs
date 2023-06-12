

using Composite.Classes;
//--------------TABLE

LightElementNode table = new LightElementNode("table");

LightElementNode tr1 = new LightElementNode("tr");
LightElementNode td1 = new LightElementNode("td");
LightElementNode td2 = new LightElementNode("td");
LightElementNode td3 = new LightElementNode("td");

LightElementNode tr2 = new LightElementNode("tr");
LightElementNode td4 = new LightElementNode("td");
LightElementNode td5 = new LightElementNode("td");
LightElementNode td6 = new LightElementNode("td");

LightElementNode tr3 = new LightElementNode("tr");
LightElementNode td7 = new LightElementNode("td");
LightElementNode td8 = new LightElementNode("td");
LightElementNode td9 = new LightElementNode("td");

table.AppendNode(tr1);
tr1.AppendNode(td1);
tr1.AppendNode(td2);
tr1.AppendNode(td3);
table.AppendNode(tr2);
tr2.AppendNode(td4);
tr2.AppendNode(td5);
tr2.AppendNode(td6);
table.AppendNode(tr3);
tr3.AppendNode(td7);
tr3.AppendNode(td8);
tr3.AppendNode(td9);

td1.AppendNode(new LightTextNode("FirstName"));
td2.AppendNode(new LightTextNode("LastName"));
td3.AppendNode(new LightTextNode("Age"));
td4.AppendNode(new LightTextNode("Vadim"));
td5.AppendNode(new LightTextNode("Bondar"));
td6.AppendNode(new LightTextNode("18"));
td7.AppendNode(new LightTextNode("Vadim2"));
td8.AppendNode(new LightTextNode("Bondar2"));
td9.AppendNode(new LightTextNode("20"));

Console.WriteLine("---------------------GetHTMLS");
Console.WriteLine(table.GetOuterHtml());
Console.WriteLine(td4.GetInnerHtml());

Console.WriteLine("---------------------ReplaceNode");
LightElementNode th1 = new LightElementNode("th");
th1.AppendNode(new LightTextNode("Replaced"));
tr1.ReplaceNode(td1, th1);
Console.WriteLine(tr1.GetOuterHtml());

Console.WriteLine("---------------------InsertBeforeNode");
LightElementNode th2 = new LightElementNode("th");
th2.AppendNode(new LightTextNode("Inserted"));
tr2.InsertBefore(td5, th2);
Console.WriteLine(tr2.GetOuterHtml());

//----CLONE
Console.WriteLine("---------------------CLONE");

var table2 = (LightElementNode)table.Clone();
th1.AppendNode(new LightTextNode("---------------1"));
td2.AppendNode(new LightTextNode("---------------2"));
td3.AppendNode(new LightTextNode("---------------3"));
Console.WriteLine("---------------------TABLE1");
Console.WriteLine(table.GetOuterHtml());
Console.WriteLine("---------------------TABLE2");
Console.WriteLine(table2.GetOuterHtml());
