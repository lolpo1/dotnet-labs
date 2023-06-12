
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.HTML
{
    public abstract class LightNode
    {
        public virtual string GetOuterHtml()
        {
            return "";
        }
        public virtual string GetContent()
        {
            return "";
        }
    }
}
