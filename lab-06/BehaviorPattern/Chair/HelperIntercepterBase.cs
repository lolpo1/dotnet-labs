using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chair
{
    public class HelperIntercepterBase : iHelperIntercepter
    {
        private iHelperIntercepter _next;
        public bool LastIntercepter { get; set; }
        public HelperIntercepterBase() 
        {
            this.LastIntercepter = false;
        }
        public void SetNext(iHelperIntercepter next)
        { 
            this._next = next;
        }
        public virtual string Handle()
        {
            if (this._next == null)
            {
                Console.WriteLine("----------------SpeakEnd");
                return "";
            }
            else
            return this._next.Handle();
        }
    }
}
