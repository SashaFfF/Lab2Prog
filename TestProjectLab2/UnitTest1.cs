using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2._1;
using lab2._2;

namespace TestProjectLab2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int number = 57;
            int expectedResult = 12;

            int actualResult = Calc.SumOfDigits(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int x = 0;
            int y = -10;

            int expectedResult = 2;

            int actualResult = Check.checkPresence(x, y);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int x = 0;
            int y = 0;

            int expectedResult = 1;

            int actualResult = Check.checkPresence(x, y);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int x = 0;
            int y = 10;

            int expectedResult = 0;

            int actualResult = Check.checkPresence(x, y);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
