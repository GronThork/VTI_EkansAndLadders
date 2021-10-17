using System;
using System.Linq;
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
            Token token = new(board.Cells[0], "Samuel");
            Dice dice = new();

            //Act
            board.MoveToken(dice.Roll(), token);
            int finalPosition = token.GetTokenPosition();

            // Assert
            Assert.NotEqual(Notexpected, finalPosition);
        }

        [Fact]
        public void Dice_TheResultOfTheRollWillBeBetweenOneAndSixInclusive()
        {
            //Arrange
            bool expected = true;

            Board board = new();
            Token token = new(board.Cells[0], "Samuel");
            Dice dice = new();

            //Act
            bool correctResult = true;

            for (int i = 0; i < 60; i++)
            {
                if (!Enumerable.Range(1, 6).Contains(dice.Roll()))
                {
                    correctResult = false;
                    break;
                }
            }

            // Assert
            Assert.Equal(expected, correctResult);
        }
    }
}
