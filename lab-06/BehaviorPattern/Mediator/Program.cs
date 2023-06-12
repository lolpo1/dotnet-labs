








using DesignPatterns.Mediator;
using Mediator;
Aircraft plane1 = new Aircraft(35);
Aircraft plane2 = new Aircraft(777);
Aircraft plane3 = new Aircraft(7);

Runway runway1 = new Runway(1);
Runway runway2 = new Runway(2);

List<Aircraft> aircrafts = new List<Aircraft>() {plane1,plane2, plane3 };
List<Runway> runways = new List<Runway>() { runway1, runway2 };
CommandCentre CC = new CommandCentre(runways,aircrafts);

plane1.Land();
plane2.Land();
plane3.Land();

plane2.TakeOff();



