using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]

        public void JustTest()
        {
            // Arrange
            const int one = 1;
            const int two = 2;

            // Act
            int three = one + two;

            // Assert
            Assert.AreEqual(three, 3);
        }
    }
}
