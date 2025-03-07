using SelfPractise;

namespace CalculatorTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Addition()
        {
            // Arrange
            Calculator c = new Calculator();
            // Act
            int result = c.Add(2, 5);
            // Assert
            Assert.AreEqual(7, result);
        }
        [TestMethod]
        public void Substraction()
        {
            // Arrange
            Calculator c = new Calculator();
            // Act
            int result = c.Sub(7, 5);
            // Assert
            Assert.AreEqual(2, result);
        }
    }
}