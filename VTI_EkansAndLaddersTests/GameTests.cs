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
            int initialPosition = 97;
            int steps = 3;

            Game game = new();

            //Act
            game.Board().MoveToken(initialPosition - 1); // Move the token to the cell 97
            game.Board().MoveToken(steps); 

            // Assert
            Assert.Equal(expected, game.IsGameOver());
        }
    }
}
