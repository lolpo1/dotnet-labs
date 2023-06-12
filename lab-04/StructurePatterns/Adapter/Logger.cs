using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Logger
    {
        public virtual void Log(string str)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str);
            Console.ResetColor();
        }
        public virtual void Error(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
            Console.ResetColor();
        }
        public virtual void Warn(string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(str);
            Console.ResetColor();
        }

    }
}
