using DesignPatterns.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Runway : AirConnection
    {
        public int Id { get; }
        public bool IsBusy;
        public int? AirPlaneId { set; get; }
        public Runway(int id)
        { 
            this.Id = id;
            this.IsBusy = false;
        }
        public int? SetLineInBusyStatus(int? AirPlaneId)
        {
            if (AirPlaneId != null)
            {
                this.IsBusy = true;
                this.AirPlaneId = AirPlaneId;
                this.HighLightRed();
                Console.WriteLine($"-------------------------");
                return this.Id;
            }
            return null;
        }
        public int UnSetLineInBusyStatus()
        {
            this.IsBusy = false;
            this.AirPlaneId = null;
            this.HighLightGreen();
            return this.Id;
        }
        private void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} is busy!");
        }

        private void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} is free!");
        }
    }
}
