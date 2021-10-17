using System;
using VTI_EkansAndLadders.Entities;
using VTI_EkansAndLadders.Entities.Interfaces;

namespace VTI_EkansAndLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            Cell[] cells = new Cell[100];

            for (int i = 0; i < 100; i++)
            {
                cells[i] = new NormalCell(i);
            }

            Dice dice = new();
            
            Board board = new(cells);

            Console.WriteLine("Welcome to the Ekans & Ladders Game!");
            Console.WriteLine("Tell me player!! Whats your name?");
            string name = Console.ReadLine();

            Token token = new(board.Cells[0], name);
            Console.WriteLine($"Nice to meet you {token.Name}. Get ready to play!");

            Game game = new(dice, board, token);
            game.Initialize();
        }
    }
}
