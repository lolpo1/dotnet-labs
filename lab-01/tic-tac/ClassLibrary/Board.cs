using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Board
    {
        public int rowCount { private set; get; } = 3;
        public int columnCount { private set; get; } = 3;
        protected Cell[,] grid;
        public Cell[,] Grid
        {
            get { return grid; }
        }

        public Board() {
            this.grid = new Cell[rowCount, columnCount];
            this.FillBoardFrom1To9();
        }
        public void FillBoardFrom1To9()
        {
            int counter = 1;
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < columnCount; j++)
                {
                    this.grid[i, j] = new Cell(counter++);
                }
        }

        public void ShowBoard()
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write($"{this.grid[i,j].CurrentSign,3}");
                    if(j < columnCount-1)
                        Console.Write($"{"|",3}");

                }
                Console.WriteLine("");
                Console.WriteLine("-----+-----+-----");
            }
        }

        public void InsertSignToCurrentPlace(int number, Player player)
        {
            switch (number)
            {
                case 1:this.InsertSign(1, player);
                    break;
                case 2:
                    this.InsertSign(2, player);
                    break;
                case 3:
                    this.InsertSign(3, player);
                    break;
                case 4:
                    this.InsertSign(4, player);
                    break;
                case 5:
                    this.InsertSign(5, player);
                    break;
                case 6:
                    this.InsertSign(6, player);
                    break;
                case 7:
                    this.InsertSign(7, player);
                    break;
                case 8:
                    this.InsertSign(8, player);
                    break;
                case 9:
                    this.InsertSign(9, player);
                    break;
            }
        }

        protected void InsertSign(int number, Player player)
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (this.grid[i, j].Number == number)
                    {
                        this.grid[i, j].CurrentSign = player.Sign;
                        this.grid[i, j].WhoChanged = player;
                    }
                }
            }
        }

        public bool IsBoardFilled()
        {
            bool state = false;
            int countOfFilled = 0;
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < columnCount; j++)
                {
                    if (this.grid[i, j].CurrentSign != this.grid[i, j].Number.ToString())
                    {
                        countOfFilled++;
                    }
                }
            if (countOfFilled == (this.rowCount * this.columnCount))
                state = true;
            return state;
        }
        
    }
}
