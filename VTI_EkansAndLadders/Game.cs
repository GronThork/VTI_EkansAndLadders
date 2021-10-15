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
            Board board = new();
        }

        
        public bool GameOver()
        {
            return false;
        }

        public Board Board()
        {
            return board;
        }
    }
}
