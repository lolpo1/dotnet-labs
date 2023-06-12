


using Prototype.Classes;

var virusFather1 = new Virus("virusFather1",1000,1,"Virus - father");
var virusFather2 = (Virus)virusFather1.Clone();
virusFather2.Name = "virusFather2";
virusFather1.ShowVirysInfo();
virusFather2.ShowVirysInfo();


var virusChild1 = new VirusChild("virusChild1",1000,1,"Virus - child", virusFather1);
virusChild1.ShowVirysInfo();
var virusChild2 = (VirusChild)virusChild1.Clone();
virusChild2.Name = "virusChild2";
virusChild2.ShowVirysInfo();

virusChild2.Parent =  virusFather2;
virusChild2.ShowVirysInfo();

virusFather1.ShowVirysInfo();
