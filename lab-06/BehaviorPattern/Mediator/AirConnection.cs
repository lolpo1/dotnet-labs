using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class AirConnection
    {
        protected CommandCentre? commandCentre;

        public void SetConnectionWithCC(CommandCentre commandCentre)
        { 
            this.commandCentre = commandCentre;
        }
        protected void NotifyCC(string message, int? AirId = null)
        {
            if (this.commandCentre != null)
            {
                commandCentre.Notify(message, AirId);
            }
        }

    }
}
