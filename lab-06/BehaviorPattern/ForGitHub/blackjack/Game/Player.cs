namespace BlackJack
{
  public class Player
  {
    public bool IsBOT { set; get; } = false;
    public string Name { get; }
    public List<Card> DrawnCards { set; get; } = new List<Card>();
    public Player(string name)
    {
      this.Name = name;
    }
    public bool ConfirmNextDraw()
    {
      return InputHandler.Confirm("Do you want to draw next card?");
    }
    public Card DrawCard(CardsDeck cardsDeck)
    {
      Card card = cardsDeck.Draw();
      this.DrawnCards.Add(card);
      Logger.ShowDrawnCard(card, PointsCounter.CountSum(this.DrawnCards));
      return card;
    }
  }
}