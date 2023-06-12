using BlackJack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace blackjack.Game.Strategy
{
    public class StrategyOfRiskyBot : IStartegy
    {
        private int POINT = 19;
        public List<int> HandlePlayer(Player player, CardsDeck Deck, List<int> Scores)
        {
            while (PointsCounter.CountSum(player.DrawnCards) < this.POINT)
            {
                var card = player.DrawCard(Deck);
                Scores.Add(PointsCounter.GetCardPower(card));
            }
            return Scores;
        }
    }
}
