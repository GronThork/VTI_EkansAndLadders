using System;
using VTI_EkansAndLadders.Entities;
using Xunit;

namespace VTI_EkansAndLaddersTests
{
    public class DiceTests
    {
        [Fact]
        public void Dice_MoveTheTokenBasedOnDiceRoll()
        {
            //Arrange
            int Notexpected = 0;

            Board board = new();
            Token token = new(board.Cells[0]);
            Dice dice = new();

            //Act
            board.MoveToken(dice.Roll(), token);
            int finalPosition = token.GetTokenPosition();

            // Assert
            Assert.NotEqual(Notexpected, finalPosition);
        }
    }
}
