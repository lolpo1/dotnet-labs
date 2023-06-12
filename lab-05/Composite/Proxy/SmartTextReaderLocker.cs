using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextReaderLocker : ISmartText
    {
        public string FileName { get; set; }
        protected ISmartText TextReader;
        protected string Regex;
        public SmartTextReaderLocker(ISmartText Reader,string Regex) 
        {
            this.TextReader = Reader;
            this.Regex = Regex;
        }

        

        public char[][] Read()
        {
            Console.WriteLine("Current file - " + this.TextReader.FileName);
            Console.WriteLine("Regex - " + this.Regex.ToString());
            if (this.Regex == this.TextReader.FileName)
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            else
            {
                var val = this.TextReader.Read();
                return val;
            }
        }
    }
}
