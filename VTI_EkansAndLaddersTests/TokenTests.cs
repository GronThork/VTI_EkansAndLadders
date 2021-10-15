using System;
using VTI_EkansAndLadders.Entities;
using Xunit;

namespace VTI_EkansAndLaddersTests
{
    public class TokenTests
    {
        [Fact]
        public void Token_WhenTheGameStartsTheTokenIsOnSquareOne()
        {
            //Arrange
            int expected = 1;

            Board board = new();

            //Act
            int initialPosition = board.Token().GetTokenPosition();

            // Assert
            Assert.Equal(expected, initialPosition);
        }

        [Fact]
        public void Token_WhenTheTokenIsMovedTheFirstTimeStaysInTheCorrectPosition()
        {
            //Arrange
            int expected = 4;
            int steps = 3;

            Board board = new();

            //Act
            board.MoveToken(steps);
            int finalPosition = board.Token().GetTokenPosition();

            // Assert
            Assert.Equal(expected, finalPosition);
        }

        [Fact]
        public void Token_WhenTheTokenIsMovedStaysInTheCorrectPosition()
        {
            //Arrange
            int expected = 8;
            int firstStep = 3;
            int secondStep = 4;

            Board board = new();

            //Act
            board.MoveToken(firstStep);
            board.MoveToken(secondStep);

            int finalPosition = board.Token().GetTokenPosition();

            // Assert
            Assert.Equal(expected, finalPosition);
        }
    }
}
