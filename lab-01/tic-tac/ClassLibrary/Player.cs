using System;
using ClassLibrary;

namespace ClassLibrary
{
    public class Player
    {
        protected string name;
        protected string sign;
        protected int score;
        protected bool currenTurn;
        public string Sign
        {
            set { sign = value; }
            get { return sign; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public bool CurrentTurn
        {
            set { currenTurn = value; }
            get { return currenTurn; }
        }
        public int Score
        {
            set { score = value; }
            get { return score; }
        }

        public Player() { this.score = 0; }
        public Player(string name, string sign = null) 
        {
            this.name = name;
            this.sign = sign; 
            this.score = 0; 
        }

        public void GetSignMessage(bool ShowScore)
        {
            if (ShowScore)
            {
                Console.WriteLine($"{this.name}: \"{this.sign}\" {{{this.score}}}");
            }
            else
                Console.WriteLine($"{this.name}: \"{this.sign}\"");
        }
        public void TurnMessage()
        {
            Console.WriteLine($"{name}'s turn. Select from 1 to 9 from the game board.");
        }
        public static void RandomSign(Player player1, Player player2)
        {
            //Where will be sign 'X';
            Random random = new Random();
            int tempNum = random.Next(0, 2);
            if (tempNum == 0)
            {
                player1.sign = "X";
                player2.sign = "O";
            }
            else
            {
                player1.sign = "O";
                player2.sign = "X";
            }

        }
        public static Player ReturnCurrentPlayer(Player player1, Player player2)
        {
            if (player1.currenTurn)
                return player1;
            else return player2;
        }

        public static void ChangeTurn(Player Current ,Player player1, Player player2)
        {
            if (Current == player1)
            {
                player1.CurrentTurn = false;
                player2.CurrentTurn = true;
            }
            else {
                player1.CurrentTurn = true;
                player2.CurrentTurn = false;
            }
        }
        public static void RandomTurn(Player player1, Player player2)
        {
            Random random = new Random();
            int tempNum = random.Next(0, 2);
            if (tempNum == 0)
            {
                player1.CurrentTurn = true;
                player2.CurrentTurn = false;
            }
            else
            {
                player1.CurrentTurn = false;
                player2.CurrentTurn = true;
            }
        }
        public static void ExChangeSigns(Player player1, Player player2)
        {
            string tempSign = player1.Sign;
            player1.Sign = player2.Sign;
            player2.Sign = tempSign;
        }
    }
}
