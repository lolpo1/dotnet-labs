using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Cell
    {
        protected string currentSign;
        protected int number;
        protected Player whoChanged = null;
        public int Number{
            set { this.number = value; }
            get { return number; }
        }
        public string CurrentSign
        {
            set { this.currentSign = value; }
            get { return currentSign; }
        }
        public Player WhoChanged
        {
            set { this.whoChanged = value; }
            get { return whoChanged; }
        }

        public Cell(int number)
        {
            this.CurrentSign = number.ToString();
            this.number = number;
        }

        public static Cell GetCellInNumber(int number, Cell[,] grid)
        {
            Cell found = null;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j].Number == number)
                    {
                        found = grid[i, j];
                    }
                }
            }
            return found;
        }
    }
}
