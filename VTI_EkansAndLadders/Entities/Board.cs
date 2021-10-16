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

        public Cell[] Cells { get { return _cells; } }

        public Board()
        {
            //Create the board with 100 cells
            _cells = new Cell[100];

            for (int i = 0; i < 100; i++)
            {
                Cell cell = new(i);
                _cells[i] = cell;
            }
        }

        public void MoveToken(int steps, Token token)
        {
            // If the new position is beyond to the last cell, then the token will stay in the same place. 
            int NewCellIndex = token.GetTokenPosition() + steps < _cells.Length ? token.GetTokenPosition() + steps : token.GetTokenPosition();
            token.SetTokenPosition(_cells[NewCellIndex]);
        }

        //Returns a boolean if the player reaches the cell number 100
        public bool IsGameOver(Token token)
        {
            return token.GetTokenPosition() == _cells.Length - 1 ? true : false;
        }
    }
}