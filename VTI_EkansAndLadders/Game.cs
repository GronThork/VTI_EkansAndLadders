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
        Board board;

        public Game()
        {
            board = new();
        }

        //Returns a boolean if the player reaches the cell 100
        public bool IsGameOver()
        {
            return board.Token().GetTokenPosition() == 100 ? true : false;
        }

        public Board Board()
        {
            return board;
        }
    }
}
