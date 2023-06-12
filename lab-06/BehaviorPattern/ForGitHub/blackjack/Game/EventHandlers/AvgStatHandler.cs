using BlackJack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace blackjack.Game.EventHandlers
{
    public class AvgStatHandler : EventArgs
    {
        public string PlayerName { get; set; }
        public List<int> Scores { get; set; }
        public string Time { get; set; }

        public AvgStatHandler(string PlayerName, List<int> Score)
        {
            this.PlayerName = PlayerName;
            this.Scores = Score;
            this.Time = DateTime.Now.ToString();
        }

        public override string ToString()
        {
            return $"Time:{this.Time};Player:{this.PlayerName};Scores:{String.Join(", ", this.Scores)};" +
                $"Avg:{this.Scores.Aggregate(0, (int sum,int score) => { return sum += score; })/this.Scores.Count()}\n";
        }
    }
}

