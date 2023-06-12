using BlackJack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack.Game.Strategy
{
    public interface IStartegy
    {
        public List<int> HandlePlayer(Player player, CardsDeck Deck, List<int> scores);
    }
} 
