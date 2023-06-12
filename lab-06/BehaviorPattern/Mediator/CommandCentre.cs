
using DesignPatterns.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(List<Runway> runways, List<Aircraft> aircrafts)
        {
            this._runways = runways;
            foreach (var way in this._runways)
                way.SetConnectionWithCC(this);
            this._aircrafts = aircrafts;
            foreach (var way in this._aircrafts)
                way.SetConnectionWithCC(this);
        }

        public void Notify(string message, int? AirID)
        {
            Aircraft aircraft = this._aircrafts.Find(x => x.BortID == AirID);

            if (message == "Land")
            {
                bool FoundLine = false;
                Console.WriteLine($"Checking runway.");
                foreach (var way in this._runways)
                {
                    if (!way.IsBusy)
                    {
                        way.SetLineInBusyStatus(AirID);
                        FoundLine = true;
                        aircraft.CurrentRunwayID = way.Id;
                        break;
                    }
                }
                
                if (!FoundLine)
                { 
                    Console.WriteLine($"Could not land, the runway is busy.");
                }
            }

            if (message == "TakeOff")
            {
                aircraft.CurrentRunwayID = null;
                foreach (var way in this._runways)
                {
                    if (way.AirPlaneId == AirID)
                    {   
                        way.UnSetLineInBusyStatus();
                    }
                }
            }

        }

    }
}
