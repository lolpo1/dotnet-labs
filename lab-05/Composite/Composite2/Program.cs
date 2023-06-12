





using Composite2;


Console.WriteLine("Artefacts:");
var hero = new MarvelHero("BlackWidow", 1);
var ring = new Artefact("PowerRing", 5, 50);
var necklace = new Artefact("PerlNecklace", 10, 100);
var husband = new ArtefactContainer("Thanos");
husband.AddArtefact(ring);
husband.AddArtefact(necklace);
hero.AddArtefact(husband);
hero.CountArtefacts();
hero.CalculateArtefactsWeight();
hero.Strike();
husband.RemoveArtefact(ring);
hero.CountArtefacts();
hero.CalculateArtefactsWeight();
hero.Strike();



Console.WriteLine("------------------------");
var powerStone1 = new Artefact("powerStone1", 1, 100);
var powerStone2 = new Artefact("powerStone1", 1, 100);
var powerStone3 = new Artefact("powerStone1", 1, 100);
var powerStone4 = new Artefact("powerStone1", 1, 100);
var powerStone5 = new Artefact("powerStone1", 1, 100);
var gloveOfPower = new CompositeArtefact("GloveOfPower", 10, 0);
var Molot = new CompositeArtefact("Tor'sMolot", 10, 0);
var lightning = new Artefact("lightning", 1, 100);
Molot.AddArtefact(lightning);
gloveOfPower.AddArtefact(powerStone1);
gloveOfPower.AddArtefact(powerStone2);
gloveOfPower.AddArtefact(powerStone3);
gloveOfPower.AddArtefact(powerStone4);
gloveOfPower.AddArtefact(powerStone5);
var ironMan = new MarvelHero("IronMan", 100);
ironMan.AddArtefact(gloveOfPower);
ironMan.AddArtefact(Molot);
var mainHero = new MarvelHero("MainHero", 1, true);
mainHero.AddFriend(ironMan);
ironMan.CountArtefacts();
ironMan.CalculateArtefactsWeight();
ironMan.Strike();

Console.WriteLine("---------------- logs:");
mainHero.AddArtefact(gloveOfPower);
mainHero.RemoveArtefact(gloveOfPower);