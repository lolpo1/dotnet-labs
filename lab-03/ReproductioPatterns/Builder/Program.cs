





using Builder;
using Builder.Classes;
using Builder.Classes.Builders;

SuperPersonDirector director = new SuperPersonDirector(new HeroBuilder());
Person superman = director.GetSuperman();
director.SetBuilder(new EnemyBuilder());
Person rubber = director.GetSimpleRobber();

superman.ShowPerson();
rubber.ShowPerson();