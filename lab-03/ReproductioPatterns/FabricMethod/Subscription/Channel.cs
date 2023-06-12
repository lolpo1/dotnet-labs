using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public class Channel
    {
        public string Name { get; set; }

        public string? Description { get; set; }

        public Channel(string name)
        {
            Name = name;
        }

        public Channel() { }
    }
}
