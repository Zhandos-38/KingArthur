using Microsoft.VisualStudio.TestTools.UnitTesting;
using KingArthur;
using System;
namespace KingArthurTest
{
    [TestClass]
    public class KingArthurTest
    {
        [TestMethod]
        public void TestFor0()
        {
            //Arrange
            int testNumberOfKnights = 0;
            KnightApp app = new KnightApp(testNumberOfKnights);
            //Act
            try
            {
                int answer = app.FindBestKnight();
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
            }
        }
        [TestMethod]
        public void TestForNormalNumber()
        {
            //Arrange
            int testNumberOfKnights = 20;
            int expected = 9;
            KnightApp app = new KnightApp(testNumberOfKnights);
            //Act
            int answer = app.FindBestKnight();

            //Assert
            Assert.AreEqual(expected, answer);
        }
    }
}
