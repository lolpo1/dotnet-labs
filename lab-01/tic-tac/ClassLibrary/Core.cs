using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Core
    {
        protected static Core instance = null;
        protected Player player1;
        protected Player player2;
        protected Player CurrentPlayer;
        protected Player Winner = null;
        protected Board board;
        protected bool currentStateGame = true;
        protected bool ShowPlayerScore = false;

        private Core()
        {
            this.Initialize();
        }
        public static Core GetInstance()
        {
            if (Core.instance == null)
            {
                Core.instance = new Core();
            }
            return Core.instance;
        }
        protected void Initialize()
        {
            this.player1 = new Player("Player 1");
            this.player2 = new Player("Player 2");
            this.board = new Board();
            Player.RandomTurn(this.player1, this.player2);
            Player.RandomSign(this.player1, this.player2);
        }

        public void Start()
        {
            bool gameRepeating = true;
            while(gameRepeating)
            {
                this.Play();
                Console.WriteLine("Do you want to play again? (y/n)");
                string state = Console.ReadLine();
                if (state == "y")
                {
                    ReloadParamsForContinuing();
                    gameRepeating = true;
                }
                else 
                    gameRepeating = false;
            }
        }

        protected void Play()
        {
            do
            {
                
                if (this.VerifyWinner())
                {
                    this.PrintInfo();
                    this.currentStateGame = false;
                    this.board.ShowBoard();
                    this.WinnerMessage();
                }
                else
                {
                    this.PrintInfo();
                    this.SetCurrentPlayer();
                    this.BoardAction();
                    this.ChangeTurn();
                }

            } while (this.currentStateGame);
        }
        protected void PrintInfo()
        {
            Console.Clear();
            Console.WriteLine("Let's play Tic Tac Toe!");
            this.player1.GetSignMessage(this.ShowPlayerScore);
            this.player2.GetSignMessage(this.ShowPlayerScore);
            Console.WriteLine("\n");
        }
        protected void SetCurrentPlayer()
        {
            this.CurrentPlayer = Player.ReturnCurrentPlayer(player1, player2);
            this.CurrentPlayer.TurnMessage();
            Console.Write("\n");

        }
        protected void BoardAction()
        {
           
            board.ShowBoard();
            int number = VerifyCellNumber();
            board.InsertSignToCurrentPlace(number, this.CurrentPlayer);
        }
        protected void ChangeTurn()
        {
            Player.ChangeTurn(this.CurrentPlayer, this.player1, this.player2);
        }
        protected bool VerifyWinner()
        {
            bool state = false;
            int rowCount = this.board.rowCount;
            int columnCount = this.board.columnCount;

            List<int[]> lines = new List<int[]> { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 },
            new int[] { 1, 4, 7 },new int[] { 2, 5, 8 },new int[] { 3, 6, 9 },new int[] { 1, 5, 9 },new int[] { 3, 5, 7 }};

            for (int i = 0; i < lines.Count; i++)
            {
                Cell SignOne = Cell.GetCellInNumber(lines[i][0], board.Grid);
                Cell SignTwo = Cell.GetCellInNumber(lines[i][1], board.Grid);
                Cell SignThree = Cell.GetCellInNumber(lines[i][2], board.Grid);
                if (SignOne.CurrentSign == SignTwo.CurrentSign && SignOne.CurrentSign == SignThree.CurrentSign)
                {
                    this.Winner = SignOne.WhoChanged;
                    this.IncrementWinnerScore();
                    state = true;
                }
            }
            if (board.IsBoardFilled())
                state = true;

            return state;
        }
        protected void WinnerMessage()
        {
            if (this.Winner != null)
            {
                Console.WriteLine($"{this.Winner.Name} won. Congratulations.");
            }
            else { 
                Console.WriteLine($"It’s a draw.. Congratulations.");

            }
        }
        protected int VerifyCellNumber()
        {
            string strNumber = "0";
            int number = 0;
            bool condition = false; 
            while (!condition)
            {
                Console.Write("Enter position: ");
                if ((!int.TryParse(strNumber = Console.ReadLine(), out number)) || (number > 9 || number < 1))
                {
                    Console.WriteLine($"There is no cell \"{strNumber}\" on the field");
                }
                else
                {
                    Cell cell = Cell.GetCellInNumber(number, board.Grid);
                    if (cell.Number.ToString() != cell.CurrentSign)
                    {
                        Console.WriteLine($"Cell \"{number}\" is already set.");
                    }
                    else
                        condition = true;
                }

            };
            return number;
        }

        protected void IncrementWinnerScore()
        {
            if (this.Winner != null)
            {
                this.Winner.Score++;
            }
        }
        protected void ReloadParamsForContinuing()
        {

            this.Winner = null;
            this.ShowPlayerScore = true;
            Player.ExChangeSigns(this.player1, this.player2);
            Player.RandomTurn(this.player1, this.player2);
            this.currentStateGame = true;
            this.board.FillBoardFrom1To9();
        }














        //protected bool VerifyWinner(out Player player)
        //{
        //    //Row
        //    //for (int i = 0; i < rowCount; i++)
        //    //{
        //    //    if (this.board.Grid[i, 0].CurrentSign == this.board.Grid[i, 1].CurrentSign && this.board.Grid[i, 0].CurrentSign == this.board.Grid[i, 2].CurrentSign)  
        //    //    {
        //    //        player = this.board.Grid[i, 0].WhoChanged;
        //    //        return true;
        //    //    }
        //    //}
        //    ////Column
        //    //for (int i = 0; i < rowCount; i++)
        //    //{
        //    //    if (this.board.Grid[0, i].CurrentSign == this.board.Grid[1, i].CurrentSign && this.board.Grid[0, i].CurrentSign == this.board.Grid[2, i].CurrentSign)
        //    //    {
        //    //        player = this.board.Grid[0, i].WhoChanged;
        //    //        return true;
        //    //    }
        //    //}
        //    ////Diagonal Main
        //    //if (this.board.Grid[0, 0].CurrentSign == this.board.Grid[1, 1].CurrentSign && this.board.Grid[0, 0].CurrentSign == this.board.Grid[2, 2].CurrentSign)
        //    //{

        //    //    player = this.board.Grid[0, 0].WhoChanged;
        //    //    return true;
        //    //}
        //    ////Diagonal Second
        //    //if (this.board.Grid[0, 2].CurrentSign == this.board.Grid[1, 1].CurrentSign && this.board.Grid[0, 2].CurrentSign == this.board.Grid[2, 0].CurrentSign)
        //    //{
        //    //    player = this.board.Grid[0, 2].WhoChanged;
        //    //    return true;
        //    //}
        //    //else
        //    {
        //        player = null;
        //        return false;
        //    }

        //}
    }
}
