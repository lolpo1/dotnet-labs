using BlackJack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace blackjack.Game.Strategy
{
    public class StrategyOfLooserBot : IStartegy
    {
        private int POINT = 0;
        public List<int> HandlePlayer(Player player, CardsDeck Deck, List<int> Scores)
        {
            Console.WriteLine($"--{player.Name}: Я здаюсь...");
            player.DrawnCards = new List<Card>();
            return Scores;
        }
    }
}
