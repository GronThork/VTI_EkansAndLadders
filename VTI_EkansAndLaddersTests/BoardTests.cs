using System;
using VTI_EkansAndLadders.Entities;
using Xunit;

namespace VTI_EkansAndLaddersTests
{
    public class BoardTests
    {
        [Fact]
        public void Board_TheTokenCanMove()
        {
            //Arrange
            int Notexpected = 0;
            int steps = 1;

            Board board = new();
            Token token = new(board.Cells[0]);

            //Act
            board.MoveToken(steps, token);
            int finalPosition = token.GetTokenPosition();

            // Assert
            Assert.NotEqual(Notexpected, finalPosition);
        }

        [Fact]
        public void Board_WhenTheTokenIsMovedTheFirstTimeStaysInTheCorrectPosition()
        {
            //Arrange
            int expected = 3;
            int steps = 3;

            Board board = new();
            Token token = new(board.Cells[0]);

            //Act
            board.MoveToken(steps, token);
            int finalPosition = token.GetTokenPosition();

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

            Board board = new();
            Token token = new(board.Cells[0]);

            //Act
            board.MoveToken(firstStep, token);
            board.MoveToken(secondStep, token);

            int finalPosition = token.GetTokenPosition();

            // Assert
            Assert.Equal(expected, finalPosition);
        }

        [Fact]
        public void Board_TheTokenCantBeMovedBeyondLastCell()
        {
            //Arrange
            int expected = 96;
            int steps = 4;

            Board board = new();
            Token token = new(board.Cells[96]); // Move to cell 96 (position 97)

            //Act
            board.MoveToken(steps, token);

            int finalPosition = token.GetTokenPosition();

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

            Board board = new();
            Token token = new(board.Cells[96]); // Move to cell 96 (position 97)

            //Act
            board.MoveToken(initialCell,token);
            board.MoveToken(steps, token);

            // Assert
            Assert.Equal(expected, board.IsGameOver(token));
        }

        [Fact]
        public void Board_IfTheTokenDoesntReachTheLastCellTheGameContinues()
        {
            //Arrange
            bool expected = false;
            int expectedPosition = 96;
            int initialCell = 96; // (position 97)
            int steps = 4;

            Board board = new();
            Token token = new(board.Cells[96]); // Move to cell 96 (position 97)

            //Act
            board.MoveToken(initialCell, token);
            board.MoveToken(steps, token);

            // Assert
            Assert.Equal(expected, board.IsGameOver(token));
            Assert.Equal(expectedPosition, token.GetTokenPosition());
        }
    }
}
