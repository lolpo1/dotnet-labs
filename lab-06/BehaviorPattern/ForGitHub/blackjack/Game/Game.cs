using blackjack.Game.EventHandlers;
using blackjack.Game.Strategy;
using BlackJack;
using static System.Formats.Asn1.AsnWriter;

namespace BlackJack
{
  public class Game
  {
    public event EventHandler<AvgStatHandler> AvgStateEvent;
    public static readonly int PLAYER_COUNT = 2;
    public static readonly int CARDS_WITHOUT_CONFIRMATION_COUNT = 2;
    private GameState _state = new GameState();
    private bool? GAME_MODE = false;// false - duo; true - bot

    private void CreateEvent(string PlayerName, List<int> Scores)
    {
        if (AvgStateEvent != null)
        {
            AvgStateEvent(this, new AvgStatHandler(PlayerName, Scores));
        }
    }
    private List<Player> _createPlayers()
    {
      var players = new List<Player>();
      for (int i = 1; i <= PLAYER_COUNT; i++)
      {
        string defaultName = $"Player {i}";
        string name = InputHandler.RequestAnswer($"Write a name for [{defaultName}]", defaultName);
        players.Add(new Player(name));
      }
      if(this.GAME_MODE == true)
        players.Last().IsBOT = true;
      return players;
    }
    private void _greet()
    {
      Logger.Greet();
    }
    private void _initiateState()
    {
      this._state.SetPlayers(this._createPlayers());
    }

    private void GameMode()
    {
        bool? tempBool = InputHandler.ChoosePoint($"Write a game mode:\n" +
            $"Enter 0 to start duo mode game.\n" +
            $"Enter 1 to start game with bot.\n");
        if (tempBool != null)
            this.GAME_MODE = tempBool;
    }
    public void Start()
    {
      this._greet();
      this.GameMode();
      this._initiateState();
      do
      {
        if (this._state.ActivePlayer == null)
        {
          throw new Exception("No active player detected!");          
        }
        this.HandlePlayer(this._state.ActivePlayer);
      }
      while(this._state.SwitchPlayer());
      this.End();
    }

   
    public void End()
    {
      List<Player> winners = this._state.GetWinners();
      Logger.EndGame(winners);
    }

    public void HandlePlayer(Player player)
    {
      List<int> Scores = new List<int>();
      Logger.StartPlayersTurn(player.Name);
      for (int i = 0; i < CARDS_WITHOUT_CONFIRMATION_COUNT; i++)
      {
        var card = player.DrawCard(this._state.Deck);
        Scores.Add(PointsCounter.GetCardPower(card));
      }
      Context context = new Context();
        if (this.GAME_MODE == false)
        {
            context.BusinessHandle(player, this._state.Deck, Scores);
        }
        else
        {
            if (player.IsBOT)
            {
                    
                 // context.SetStrategy(new StrategyOfLooserBot());
                  context.SetStrategy(new StrategyOfEasyBot());    ///// >13
                //context.SetStrategy(new StrategyOfRiskyBot()); ///// >19
                context.BusinessHandle(player, this._state.Deck, Scores);
            }
            else
                context.BusinessHandle(player, this._state.Deck, Scores);
        }
      CreateEvent(player.Name, Scores);
    }
  }
}
