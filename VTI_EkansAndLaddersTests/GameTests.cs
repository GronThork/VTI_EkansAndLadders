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
            game.Board().MoveToken(99); // Move the token to the last cell (100)

            // Assert
            Assert.Equal(expected, game.IsGameOver());
        }
    }
}
