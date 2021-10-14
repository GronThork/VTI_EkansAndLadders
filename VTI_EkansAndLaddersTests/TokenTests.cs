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
    }
}
