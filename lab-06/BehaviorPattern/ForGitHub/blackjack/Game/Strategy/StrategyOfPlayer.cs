using BlackJack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace blackjack.Game.Strategy
{
    public class StrategyOfPlayer : IStartegy
    {
        public List<int> HandlePlayer(Player player, CardsDeck Deck, List<int> Scores)
        {
            while (PointsCounter.CountSum(player.DrawnCards) < PointsCounter.MAX_POINTS_COUNT && player.ConfirmNextDraw())
            {
                var card = player.DrawCard(Deck);
                Scores.Add(PointsCounter.GetCardPower(card));
            }
            return Scores;
        }
    }
}
