using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FileWriter
    {
        public FileWriter() { }
        public void Write(string file, string message)
        {
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.Write(message);
            }
        }

        public void WriteLine(string file, string message)
        {
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine(message);
            }
        }

    }
}
