using FlyWeight.HTML;
using FlyWeight.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FlyWeight.BeforeFlyWeight
{
    public class LightHTMLFly
    {

        public LightHTMLFly(string fileName)
        {
            this.ParseWithMemoryCheck(fileName);

        }

        public void ParseWithMemoryCheck(string fileName)
        {
            Console.Write("Check memory before\n");
            MemoryCheck.CheckMemory();
            var text = Parse(fileName);
            Console.Write("Check memory after\n");
            MemoryCheck.CheckMemory();
        }
        public LightElementNode Parse(string FileName)
        {
            var body = new LightElementNode("body");
            string text;
            using (StreamReader reader = new StreamReader(FileName))
            {
                var lines = reader.ReadToEnd().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).Where(line => line.Length > 0).ToArray();

                for (int i = 0; i < lines.Length; i++)
                {
                    /*Console.WriteLine(lines[i]);*/
                    var line = lines[i];
                    LightElementNode node;
                    if (i == 0)
                    {
                        node = new LightElementNode("h1");
                        node.AppendNode(new LightTextNode(line));
                    }
                    else if (line.StartsWith(" "))
                    {
                        node = new LightElementNode("blockquote");
                        node.AppendNode(new LightTextNode(line));
                    }
                    else if (line.Length < 20)
                    {
                        node = new LightElementNode("h2");
                        node.AppendNode(new LightTextNode(line));
                    }
                    else
                    {
                        node = new LightElementNode("p");
                        node.AppendNode(new LightTextNode(line));
                    }
                    body.AppendNode(node);

                }
            }

            return body;
        }
    }
}