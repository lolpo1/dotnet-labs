using blackjack.Game.Handlers;

namespace BlackJack
{
  public static class PointsCounter
  {
    public static event EventHandler<Over21HandlerLog> Over21HandlerLog;
        private static void CreateEvent(string PlayerName, int Score)
        {
            if (Over21HandlerLog != null)
                Over21HandlerLog(null, new Over21HandlerLog(PlayerName, Score));
        }
        public const int MAX_POINTS_COUNT = 21;
    private static Dictionary<CardName, int> _cardValueMap = new Dictionary<CardName, int>(){
      { CardName.Two, 2 },
      { CardName.Three, 3 },
      { CardName.Four, 4 },
      { CardName.Five, 5 },
      { CardName.Six, 6 },
      { CardName.Seven, 7 },
      { CardName.Eight, 8 },
      { CardName.Nine, 9 },
      { CardName.Ten, 10 },
      { CardName.Jack, 10 },
      { CardName.Queen, 10 },
      { CardName.King, 10 },
      { CardName.Ace, 11 },
    };
    public const int MIN_ACE_VALUE = 1;
        
   
    private static int _countNoAcesSum(List<Card> cards)
    {
      return cards.Aggregate(0, (int sum, Card card) => {
        int toAdd = card.Name == CardName.Ace ? 0 : PointsCounter._cardValueMap[card.Name];
        return sum += toAdd;
      });
    }

    private static int _addAcesSum(int noAcesSum, List<Card> aces)
    {
      return aces.Aggregate(noAcesSum, (int sum, Card card) => {
        int maxAceValue = PointsCounter._cardValueMap[CardName.Ace];
        int minAceValue = PointsCounter.MIN_ACE_VALUE;

        int toAdd = sum + maxAceValue > PointsCounter.MAX_POINTS_COUNT ? minAceValue : maxAceValue;
        return sum += toAdd;
      });
    }

    public static int CountSum(List<Card> cards)
    {
      int noAcesSum = PointsCounter._countNoAcesSum(cards);
      List<Card> aces = cards.Where(card => card.Name == CardName.Ace).ToList();
      return PointsCounter._addAcesSum(noAcesSum, aces);
    }

    public static int GetCardPower(Card card)
    {
        return _cardValueMap[card.Name];
    }
        // returns points sum, but only if they are less than MAX_POINTS_COUNT
    public static int? CountWinningPoints(Player player)
    {
      int sum = PointsCounter.CountSum(player.DrawnCards);
        if (sum <= MAX_POINTS_COUNT)
            return sum;
        else
        {
           CreateEvent(player.Name, sum);
           return null;
        }
    }
  }
}