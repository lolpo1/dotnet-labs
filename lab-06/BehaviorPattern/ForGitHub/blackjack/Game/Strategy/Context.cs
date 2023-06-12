using BlackJack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack.Game.Strategy
{
    public class Context
    {
        private IStartegy _strategy = new StrategyOfPlayer();
        public Context() { }

        public void SetStrategy(IStartegy strategy)
        { 
            this._strategy = strategy;
        }
        public List<int> BusinessHandle(Player player, CardsDeck Deck, List<int> Scores)
        {
            return this._strategy.HandlePlayer(player,Deck,Scores);   
        }
    }
}
