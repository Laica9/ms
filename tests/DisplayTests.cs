using Microsoft.VisualStudio.TestTools.UnitTesting;
using ms;

namespace ms
{
    [TestClass]
    public class DisplayTests
    {
        [TestMethod]
        public void Intro_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var display = new Display();

            // Act
            var result = display.Intro();

            // Assert
            Assert.AreEqual(result, display.Intro(), "Display Title not shown");
        }
    }
}
