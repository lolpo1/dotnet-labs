using blackjack.Game.EventHandlers;
using blackjack.Game.Handlers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack.Game.Finshers
{
    public class FileStatiscticLogger
    {
        public string FileNameForOver21 { get; private set; } = "..\\..\\..\\Over21.txt";
        public string FileNameForStatistics { get; private set; } = "..\\..\\..\\AvgStat.txt";

        public FileStatiscticLogger()
        { }
        public void WriteOver21Statistics(object? sender, Over21HandlerLog e)
        {
            this.Write(FileNameForOver21, e.ToString());
        }
        public void WriteAvgStatistics(object? sender, AvgStatHandler e)
        {
            this.Write(FileNameForStatistics, e.ToString());
        }

        private void Write(string FileName, string message)
        {
            using (StreamWriter file = new StreamWriter(FileName, true))
            {
                file.WriteLine(message);
            }
        }


    }
}
