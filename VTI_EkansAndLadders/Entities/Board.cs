using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTI_EkansAndLadders.Entities.Interfaces;

namespace VTI_EkansAndLadders.Entities
{
    public class Board : IBoard
    {
        private ICell[] _cells;

        public ICell[] Cells { get { return _cells; } }

        public Board(ICell[] cells)
        {
            _cells = cells;
        }

        public void MoveToken(int steps, IToken token)
        {
            // If the new position is beyond to the last cell, then the token will stay in the same place. 
            int NewCellIndex = token.GetPosition() + steps < _cells.Length ? token.GetPosition() + steps : token.GetPosition();
            token.SetTokenPosition(_cells[NewCellIndex]);
        }

        //Returns a boolean if the player reaches the cell number 100
        public bool IsGameOver(IToken token)
        {
            return token.GetPosition() == _cells.Length - 1 ? true : false;
        }
    }
}