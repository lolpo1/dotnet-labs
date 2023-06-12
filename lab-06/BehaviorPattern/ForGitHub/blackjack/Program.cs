using blackjack.Game.Finshers;
using blackjack.Game.Handlers;
using BlackJack;

public class Program
{
    private static void Main(string[] args)
    {
        var game = new Game();
        var FileLog = new FileStatiscticLogger();
        PointsCounter.Over21HandlerLog += FileLog.WriteOver21Statistics;
        game.AvgStateEvent += FileLog.WriteAvgStatistics;
        game.Start();
    }
}