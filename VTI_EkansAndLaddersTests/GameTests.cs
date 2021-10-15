using System;
using VTI_EkansAndLadders;
using Xunit;

namespace VTI_EkansAndLaddersTests
{
    public class GameTests
    {
        [Fact]
        public void Game_TheGameEndsWhenATokenReachesTheLastCell()
        {
            //Arrange
            bool expected = true;

            Game game = new();

            //Act
            game.Board().MoveToken(96);// Move the token to the cell 97
            game.Board().MoveToken(3); // Move the token three steps

            // Assert
            Assert.Equal(expected, game.IsGameOver());
        }
    }
}
