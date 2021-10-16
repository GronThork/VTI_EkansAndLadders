using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTI_EkansAndLadders.Entities;

namespace VTI_EkansAndLadders
{
    public class Game
    {
        private Board board;
        private Token token;

        public Game()
        {
            board = new();
            token = new(board.Cells()[0]);
        }

        //Returns a boolean if the player reaches the cell 100
        public bool IsGameOver()
        {
            return token.GetTokenPosition() == 100 ? true : false;
        }

        public Board Board()
        {
            return board;
        }
    }
}
