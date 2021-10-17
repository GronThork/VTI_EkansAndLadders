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
        private Board _board;
        private Token _token;
        private Dice _dice;

        public Game()
        {
            _board = new();
            _dice = new();
        }

        public void Initialize()
        {
            Console.WriteLine("Welcome to the Ekans & Ladders Game!");
            Console.WriteLine("Tell me player!! Whats your name?");
            string name = Console.ReadLine();

            _token = new(_board.Cells[0], name);
            Console.WriteLine($"Nice to meet you {_token.Name}. Get ready to play!");

            int roll;
            while (!_board.IsGameOver(_token))
            {
                Console.WriteLine($"{_token.Name}, roll the dice!");
                roll = _dice.Roll();
                _board.MoveToken(roll, _token);
                Console.WriteLine($"Good wrist {_token.Name}! You have rolled for a {roll}. You move to position {_token.GetTokenPosition() + 1}.");
            }

            Console.WriteLine($"Congratulations {_token.Name}, you are the winner!");
        }
    }
}
