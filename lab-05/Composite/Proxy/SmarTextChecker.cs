using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmarTextChecker : ISmartText
    {
        public string FileName { get; set; }
        protected ISmartText TextReader;
        public SmarTextChecker(ISmartText Reader) 
        {
            this.TextReader = Reader;
            this.FileName = Reader.FileName;
        }

        public char[][] Read()
        {
            try
            {
                Console.WriteLine("File reading start.");
                var array = this.TextReader.Read();
                if (array != null)
                {
                    Console.WriteLine("File is done.");
                    Console.WriteLine("File is closed.");
                    Console.WriteLine("Calculating...");
                    Console.WriteLine($"Total lines count: {array.Length}");
                    int count = 0;
                    foreach (var line in array)
                    {
                        foreach (var letter in line)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"Total symbols count: {count}");
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to read the file.");
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
