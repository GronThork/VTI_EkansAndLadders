using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTI_EkansAndLadders.Entities;
using VTI_EkansAndLadders.Entities.Interfaces;

namespace VTI_EkansAndLadders
{
    public class Game
    {
        private IBoard _board;
        private IToken _token;
        private IDice _dice;

        public Game(IDice dice, IBoard board, IToken token)
        {
            _dice = dice;
            _board = board;
            _token = token;
        }

        public void Initialize()
        {
            int roll;

            while (!_board.IsGameOver(_token))
            {
                Console.WriteLine($"{_token.Name}, roll the dice!");
                roll = _dice.Roll();
                _board.MoveToken(roll, _token);
                Console.WriteLine($"Good wrist {_token.Name}! You have rolled for a {roll}. You move to position {_token.GetPosition() + 1}.");
            }

            Console.WriteLine($"Congratulations {_token.Name}, you are the winner!");
        }
    }
}
