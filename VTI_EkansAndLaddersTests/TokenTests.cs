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

            Cell[] cells = new Cell[100];

            for (int i = 0; i < 100; i++)
            {
                cells[i] = new Cell(i);
            }

            Board board = new(cells);
            Token token = new(board.Cells[0], "Samuel");

            //Act
            int initialPosition = token.GetTokenPosition();

            // Assert
            Assert.Equal(expected, initialPosition);
        }
    }
}
