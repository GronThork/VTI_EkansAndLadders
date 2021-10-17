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
            int expected = 0;

            Board board = new();
            Token token = new(board.Cells[0], "Samuel");

            //Act
            int initialPosition = token.GetTokenPosition();

            // Assert
            Assert.Equal(expected, initialPosition);
        }
    }
}
