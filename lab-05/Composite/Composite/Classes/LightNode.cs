using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Classes
{
    public abstract class LightNode : IClone
    {
        public virtual string GetOuterHtml()
        {
            return "";
        }
        public virtual string GetContent()
        {
            return "";
        }

        public abstract IClone Clone();
    }
}
