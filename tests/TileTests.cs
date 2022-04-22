using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ms;

namespace ms
{
    [TestClass]
    public class TileTests
    {
        [TestMethod]
        public void IsMine_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var tile = new Tile();

            // Act
            var result = tile.IsMine();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void SetMine_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var tile = new Tile();

            // Act
            tile.SetMine();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void Hidden_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var tile = new Tile();

            // Act
            var result = tile.Hidden();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void SetHidden_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var tile = new Tile();
            bool hidden = false;

            // Act
            tile.SetHidden(
                hidden);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void GetNearbyMines_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var tile = new Tile();

            // Act
            var result = tile.GetNearbyMines();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void SetNearbyMines_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var tile = new Tile();
            int nearbyMines = 0;

            // Act
            tile.SetNearbyMines(
                nearbyMines);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void IncrementNearbyMines_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var tile = new Tile();

            // Act
            tile.IncrementNearbyMines();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void Reveal_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var tile = new Tile();

            // Act
            tile.Reveal();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void GetTile_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var tile = new Tile();

            // Act
            var result = tile.GetTile();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void setTile_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var tile = new Tile();
            char tile1 = default(global::System.Char);

            // Act
            tile.setTile(
                tile1);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void IsUnmarked_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var tile = new Tile();

            // Act
            var result = tile.IsUnmarked();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void switcheTile_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var tile = new Tile();

            // Act
            tile.switcheTile();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void DrawTile_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var tile = new Tile();

            // Act
            var result = tile.DrawTile();

            // Assert
            Assert.Fail();
        }
    }
}
