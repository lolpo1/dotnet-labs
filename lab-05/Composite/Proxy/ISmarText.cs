using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface ISmartText
    {
        public string FileName { set; get; }
        public char[][] Read();
    }
}
