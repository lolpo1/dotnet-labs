using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack.Game.Handlers
{
    public class Over21HandlerLog : EventArgs
    {
        public string PlayerName { get; set; }
        public int Score  { get; set; }
        public string Time { get; set; }

        public Over21HandlerLog(string PlayerName,int Score) 
        {
            this.PlayerName = PlayerName;
            this.Score = Score;
            this.Time = DateTime.Now.ToLongDateString();
        }

        public override string ToString() 
        {
            return $"Time:{this.Time};Player:{this.PlayerName};Score:{this.Score}\n";
        }
    }
}
