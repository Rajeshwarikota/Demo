namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator cal = new Calculator();
            int result = cal.Add(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}