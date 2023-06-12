using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextReader : ISmartText
    {
        public string FileName {set;get;}
        public char[][] Letters { set; get; }
        public SmartTextReader(string FileName)
        { 
            this.FileName = FileName;
        }
        public void GetLetters()
        {
            if (this.Letters != null)
            {
                for (int i = 0; i < this.Letters.Length; i++)
                {
                    for (int j = 0; j < this.Letters[i].Length; j++)
                    {
                        Console.Write($"{this.Letters[i][j]} ");
                    }
                    Console.Write("\n");
                }
            }
            
        }
        public char[][] Read()
        {
            if (this.FileName != null)
            {
                try {
                    using (StreamReader reader = new StreamReader(this.FileName))
                    {
                        List<char[]> list = new List<char[]>();
                        List<char> chars = new List<char>();
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {

                            foreach (char letter in line)
                            {
                                chars.Add(letter);
                            }
                            char[] LineCharArray = chars.ToArray();
                            list.Add(LineCharArray);
                            chars.Clear();
                        }
                        this.Letters = list.ToArray();
                        return this.Letters;
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            return null;
        }
    }
}
