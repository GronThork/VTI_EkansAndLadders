using System;
using VTI_EkansAndLadders.Entities;
using VTI_EkansAndLaddersTests.Helpers;
using Xunit;

namespace VTI_EkansAndLaddersTests.Tests
{
    public class BoardTests
    {
        private readonly Cell[] _cells;

        public BoardTests()
        {
            _cells = CellHelper.GetDefaultCells();
        }

        [Fact]
        public void Board_TheTokenCanMove()
        {
            //Arrange
            int Notexpected = 0;
            int steps = 1;

            Board board = new(_cells);
            Token token = new(board.Cells[0], "Samuel");

            //Act
            board.MoveToken(steps, token);
            int finalPosition = token.GetPosition();

            // Assert
            Assert.NotEqual(Notexpected, finalPosition);
        }

        [Fact]
        public void Board_WhenTheTokenIsMovedTheFirstTimeStaysInTheCorrectPosition()
        {
            //Arrange
            int expected = 3;
            int steps = 3;

            Board board = new(_cells);
            Token token = new(board.Cells[0], "Samuel");

            //Act
            board.MoveToken(steps, token);
            int finalPosition = token.GetPosition();

            // Assert
            Assert.Equal(expected, finalPosition);
        }

        [Fact]
        public void Board_WhenTheTokenIsMovedStaysInTheCorrectPosition()
        {
            //Arrange
            int expected = 7;
            int firstStep = 3;
            int secondStep = 4;

            Board board = new(_cells);
            Token token = new(board.Cells[0], "Samuel");

            //Act
            board.MoveToken(firstStep, token);
            board.MoveToken(secondStep, token);

            int finalPosition = token.GetPosition();

            // Assert
            Assert.Equal(expected, finalPosition);
        }

        [Fact]
        public void Board_TheTokenCantBeMovedBeyondLastCell()
        {
            //Arrange
            int expected = 96;
            int steps = 4;

            Cell[] cells = new Cell[100];

            for (int i = 0; i < 100; i++)
            {
                cells[i] = new Cell(i);
            }

            Board board = new(cells);
            Token token = new(board.Cells[96], "Samuel"); // Move to cell 96 (position 97)

            //Act
            board.MoveToken(steps, token);

            int finalPosition = token.GetPosition();

            // Assert
            Assert.Equal(expected, finalPosition);
        }

        [Fact]
        public void Board_TheGameEndsWhenATokenReachesTheLastCell()
        {
            //Arrange
            bool expected = true;
            int initialCell = 96; // (position 97)
            int steps = 3;

            Cell[] cells = new Cell[100];

            for (int i = 0; i < 100; i++)
            {
                cells[i] = new Cell(i);
            }

            Board board = new(cells);
            Token token = new(board.Cells[96], "Samuel"); // Move to cell 96 (position 97)

            //Act
            board.MoveToken(initialCell, token);
            board.MoveToken(steps, token);

            // Assert
            Assert.Equal(expected, board.IsGameOver(token));
        }

        [Fact]
        public void Board_IfTheTokenDoesntReachTheLastCellThenTheGameContinues()
        {
            //Arrange
            bool expected = false;
            int expectedPosition = 96;
            int initialCell = 96; // (position 97)
            int steps = 4;

            Cell[] cells = new Cell[100];

            for (int i = 0; i < 100; i++)
            {
                cells[i] = new Cell(i);
            }

            Board board = new(cells);
            Token token = new(board.Cells[96], "Samuel"); // Move to cell 96 (position 97)

            //Act
            board.MoveToken(initialCell, token);
            board.MoveToken(steps, token);

            // Assert
            Assert.Equal(expected, board.IsGameOver(token));
            Assert.Equal(expectedPosition, token.GetPosition());
        }
    }
}
