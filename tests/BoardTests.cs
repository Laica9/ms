using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ms;

namespace ms
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void Display_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var board = new Board();

            // Act
            board.Display();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void newTileMap_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var board = new Board();
            int rows = 0;
            int columns = 0;
            int number_of_mines = 0;

            // Act
            board.newTileMap(
                rows,
                columns,
                number_of_mines);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void GameOver_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var board = new Board();

            // Act
            var result = board.GameOver();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void Win_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var board = new Board();

            // Act
            var result = board.Win();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void RevealTile_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var board = new Board();
            int row = 0;
            int col = 0;

            // Act
            board.RevealTile(
                row,
                col);

            // Assert
            Assert.Fail();
        }
    }
}
