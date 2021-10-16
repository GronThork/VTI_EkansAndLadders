using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTI_EkansAndLadders.Entities
{
    public class Board
    {
        private Cell[] _cells;

        public Board()
        {
            //Create the board with 100 cells
            _cells = new Cell[100];
            for (int i = 1; i <= 100; i++)
            {
                Cell cell = new(i);
                _cells[i - 1] = cell;
            }
        }

        public void MoveToken(int steps, Token token)
        {
            // If the new position is beyond to the last cell (100), then the token will stay in the same place. 
            int NewCellIndex = token.GetTokenPosition() + steps <= 100 ? token.GetTokenPosition() + steps : token.GetTokenPosition();
            token.SetTokenPosition(_cells[NewCellIndex-1]);
        }

        public Cell[] Cells()
        {
            return _cells;
        }
    }
}